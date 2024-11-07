using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace oop_final
{
    public class AccountStudent 
    {
        #region Singleton
        public static AccountStudent instance;
        public List<Student> Students { get; private set; }

        private readonly string STUDENTS_FILE_PATH;

        public AccountStudent()
        {
            STUDENTS_FILE_PATH = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "students.json");
            LoadStudentsFromFile();
            InitializeDefaultData();
        }

        public static AccountStudent Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountStudent();
                return instance;
            }
        }
        #endregion
        private void LoadStudentsFromFile()
        {
            try
            {
                if (File.Exists(STUDENTS_FILE_PATH))
                {
                    string jsonString = File.ReadAllText(STUDENTS_FILE_PATH);
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        WriteIndented = true
                    };
                    Students = JsonSerializer.Deserialize<List<Student>>(jsonString, options);
                }
                else
                {
                    InitializeDefaultData();
                    SaveStudentsToFile();
                }
            }
            catch (Exception)
            {
                InitializeDefaultData();
            }
        }

        private void SaveStudentsToFile()
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };

                string jsonString = JsonSerializer.Serialize(Students, options);
                File.WriteAllText(STUDENTS_FILE_PATH, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}");
            }
        }
        public SubjectScore CreateDefaultSubjectScore(string maMon, string tenMon)
        {
            return new SubjectScore
            {
                MaMon = maMon,
                TenMon = tenMon,
                DiemMieng = 0,
                Diem15Phut = 0,
                DiemGiuaKi = 0,
                DiemCuoiKi = 0
            };
        }
        public void InitializeDefaultData()
        {
            Students = new List<Student>();

            Student defaultStudent1 = new Student
            {
                maHS = "HS1",
                maLop = "10A1",
                hoVaTen = "Trần Ngọc Mỹ",
                gioiTinh = 0,
                ngSinh = new DateTime(2006, 1, 1),
                tenDangNhapHS = "mytran",
                matKhauHS = "mytran",

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS1", "MATH", 8.0, 8.5, 8.5, 8.5);
            UpdateStudentSubjectScores("HS1", "LIT", 7.0, 7.5, 8.0, 8.5);
            UpdateStudentSubjectScores("HS1", "ENG", 8.5, 9.0, 8.5, 9.0);
            UpdateStudentSubjectScores("HS1", "PHY", 7.5, 8.0, 8.5, 9.0);
            UpdateStudentSubjectScores("HS1", "CHEM", 8.0, 7.5, 8.0, 8.5);
            UpdateStudentSubjectScores("HS1", "BIO", 8.5, 9.0, 9.0, 8.5);
            UpdateStudentSubjectScores("HS1", "HIS", 0.0, 0.0, 0.0, 0.0);
            UpdateStudentSubjectScores("HS1", "GEO", 0.0, 0.0, 0.0, 0.0);
            UpdateStudentSubjectScores("HS1", "CIV", 0.0, 0.0, 0.0, 0.0);
            UpdateStudentSubjectScores("HS1", "IT", 0.0, 0.0, 0.0, 0.0);
            UpdateStudentSubjectScores("HS1", "TECH", 0.0, 0.0, 0.0, 0.0);

            Students.Add(defaultStudent1);

            Student defaultStudent2 = new Student
            {
                maHS = "HS2",
                maLop = "10A1",
                hoVaTen = "Nguyễn Thiên Ân",
                gioiTinh = 0,
                tenDangNhapHS = "annguyen",
                matKhauHS = "annguyen",
                ngSinh = new DateTime(2009, 3, 8),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS2", "MATH", 9.0, 8.0, 9.5, 8.5);
            UpdateStudentSubjectScores("HS2", "LIT", 8.0, 7.5, 8.0, 7.5);
            UpdateStudentSubjectScores("HS2", "ENG", 7.5, 9.5, 8, 9.0);
            UpdateStudentSubjectScores("HS2", "PHY", 8, 8.5, 8.8, 9.0);
            UpdateStudentSubjectScores("HS2", "CHEM", 8.5, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS2", "BIO", 8.5, 9.0, 9.0, 8.5);

            Students.Add(defaultStudent2);

            Student defaultStudent3 = new Student
            {
                maHS = "HS3",
                maLop = "10A1",
                hoVaTen = "Lê An",
                gioiTinh = 1,
                tenDangNhapHS = "anle",
                matKhauHS = "anle",
                ngSinh = new DateTime(2009, 11, 22),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS3", "MATH", 9.0, 8.0, 9.5, 8.5);
            UpdateStudentSubjectScores("HS3", "LIT", 8.0, 7.5, 8.0, 7.5);
            UpdateStudentSubjectScores("HS3", "ENG", 7.5, 9.5, 8, 9.0);
            UpdateStudentSubjectScores("HS3", "PHY", 8, 8.5, 8.8, 9.0);
            UpdateStudentSubjectScores("HS3", "CHEM", 8.5, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS3", "BIO", 8.5, 9.0, 9.0, 8.5);

            Students.Add(defaultStudent3);

            Student defaultStudent4 = new Student
            {
                maHS = "HS4",
                maLop = "10A2",
                hoVaTen = "Lê Hoàng Phương",
                gioiTinh = 0,
                tenDangNhapHS = "phuongle",
                matKhauHS = "phuongle",
                ngSinh = new DateTime(2009, 7, 18),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS4", "HIS", 7.0, 8.5, 8.0, 8.5);
            UpdateStudentSubjectScores("HS4", "GEO", 8.0, 8.5, 9.0, 9.5);
            UpdateStudentSubjectScores("HS4", "CIV", 9.0, 8.0, 9.5, 9.0);
            UpdateStudentSubjectScores("HS4", "IT", 8.5, 9.0, 8.5, 9.0);
            UpdateStudentSubjectScores("HS4", "TECH", 8.5, 7.0, 9.0, 8.5);

            Students.Add(defaultStudent4);

            Student defaultStudent5 = new Student
            {
                maHS = "HS5",
                maLop = "10A2",
                hoVaTen = "Nguyễn Thúc Thùy Tiên",
                gioiTinh = 0,
                tenDangNhapHS = "tiennguyen",
                matKhauHS = "tiennguyen",
                ngSinh = new DateTime(2009, 10, 15),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS5", "HIS", 9.0, 8.5, 8.5, 8.5);
            UpdateStudentSubjectScores("HS5", "GEO", 9.0, 8.5, 9.5, 9.5);
            UpdateStudentSubjectScores("HS5", "CIV", 9.0, 9.0, 9.5, 9.0);
            UpdateStudentSubjectScores("HS5", "IT", 8.5, 9.0, 8.5, 9.0);
            UpdateStudentSubjectScores("HS5", "TECH", 8.5, 7.0, 9.5, 8.5);

            Students.Add(defaultStudent5);

            Student defaultStudent6 = new Student
            {
                maHS = "HS6",
                maLop = "10A2",
                hoVaTen = "Nguyễn Quốc Thiên",
                gioiTinh = 1,
                tenDangNhapHS = "thiennguyen",
                matKhauHS = "thiennguyen",
                ngSinh = new DateTime(2009, 4, 2),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS6", "HIS", 8.0, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS6", "GEO", 10.0, 8.5, 9.0, 9.5);
            UpdateStudentSubjectScores("HS6", "CIV", 10.0, 8.0, 9.0, 9.0);
            UpdateStudentSubjectScores("HS6", "IT", 8.5, 9.0, 8.5, 9.0);
            UpdateStudentSubjectScores("HS6", "TECH", 7.5, 8.0, 9.0, 8.5);

            Students.Add(defaultStudent6);

            Student defaultStudent7 = new Student
            {
                maHS = "HS7",
                maLop = "11A1",
                hoVaTen = "Trần Văn Bình",
                gioiTinh = 1,
                tenDangNhapHS = "binhtran",
                matKhauHS = "binhtran",
                ngSinh = new DateTime(2008, 9, 25),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS7", "MATH", 8.0, 8.0, 9.5, 8.5);
            UpdateStudentSubjectScores("HS7", "LIT", 8.5, 7.5, 8.5, 7.5);
            UpdateStudentSubjectScores("HS7", "ENG", 8.5, 9.5, 8.5, 9.0);
            UpdateStudentSubjectScores("HS7", "PHY", 9, 8.5, 8.5, 9.0);
            UpdateStudentSubjectScores("HS7", "CHEM", 9.5, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS7", "BIO", 8.5, 8.0, 9.0, 8.5);

            Students.Add(defaultStudent7);

            Student defaultStudent8 = new Student
            {
                maHS = "HS8",
                maLop = "11A1",
                hoVaTen = "Nguyễn Thị Hạnh",
                gioiTinh = 0,
                tenDangNhapHS = "hanhnguyen",
                matKhauHS = "hanhnguyen",
                ngSinh = new DateTime(2008, 12, 3),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS8", "MATH", 7.0, 8.0, 8.5, 8.5);
            UpdateStudentSubjectScores("HS8", "LIT", 7.5, 7.5, 8.5, 7.5);
            UpdateStudentSubjectScores("HS8", "ENG", 7.5, 9.5, 8.5, 9.0);
            UpdateStudentSubjectScores("HS8", "PHY", 8, 8.5, 9.5, 9.0);
            UpdateStudentSubjectScores("HS8", "CHEM", 8.5, 8.5, 8.0, 8.5);
            UpdateStudentSubjectScores("HS8", "BIO", 7.5, 8.0, 8.0, 8.5);

            Students.Add(defaultStudent8);

            Student defaultStudent9 = new Student
            {
                maHS = "HS9",
                maLop = "11A1",
                hoVaTen = "Lê Quang Huy",
                gioiTinh = 1,
                tenDangNhapHS = "huyle",
                matKhauHS = "huyle",
                ngSinh = new DateTime(2008, 2, 14),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS9", "MATH", 9.0, 8.0, 9.5, 8.5);
            UpdateStudentSubjectScores("HS9", "LIT", 9.5, 7.5, 8.5, 7.5);
            UpdateStudentSubjectScores("HS9", "ENG", 9.5, 9.5, 9.5, 9.0);
            UpdateStudentSubjectScores("HS9", "PHY", 9, 8.5, 9.5, 9.0);
            UpdateStudentSubjectScores("HS9", "CHEM", 9.5, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS9", "BIO", 9.5, 8.0, 9.0, 8.5);

            Students.Add(defaultStudent9);

            Student defaultStudent10 = new Student
            {
                maHS = "HS10",
                maLop = "11A2",
                hoVaTen = "Trần Minh Hoàng",
                gioiTinh = 1,
                tenDangNhapHS = "hoangtran",
                matKhauHS = "hoangtran",
                ngSinh = new DateTime(2008, 6, 9),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS10", "HIS", 8.0, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS10", "GEO", 10.0, 8.5, 9.0, 9.5);
            UpdateStudentSubjectScores("HS10", "CIV", 10.0, 8.0, 9.0, 9.0);
            UpdateStudentSubjectScores("HS10", "IT", 8.5, 9.0, 8.5, 9.0);
            UpdateStudentSubjectScores("HS10", "TECH", 7.5, 8.0, 9.0, 8.5);

            Students.Add(defaultStudent10);

            Student defaultStudent11 = new Student
            {
                maHS = "HS11",
                maLop = "11A2",
                hoVaTen = "Lê Thị Thu Hà",
                gioiTinh = 0,
                tenDangNhapHS = "hale",
                matKhauHS = "hale",
                ngSinh = new DateTime(2008, 8, 27),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS11", "CHEM", 8.0, 7.5, 8.0, 8.5);
            UpdateStudentSubjectScores("HS11", "BIO", 8.5, 9.0, 9.0, 8.5);
            UpdateStudentSubjectScores("HS11", "HIS", 9.0, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS11", "GEO", 10.0, 8.5, 9.5, 9.5);
            UpdateStudentSubjectScores("HS11", "CIV", 10.0, 8.0, 9.5, 9.0);
            UpdateStudentSubjectScores("HS11", "IT", 9.5, 9.0, 8.5, 8.0);
            UpdateStudentSubjectScores("HS11", "TECH", 8.5, 8.5, 9.0, 8.5);

            Students.Add(defaultStudent11);

            Student defaultStudent12 = new Student
            {
                maHS = "HS12",
                maLop = "11A2",
                hoVaTen = "Ngô Quang Vinh",
                gioiTinh = 1,
                tenDangNhapHS = "vinhngo",
                matKhauHS = "vinhngo",
                ngSinh = new DateTime(2008, 11, 16),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS12", "HIS", 9.0, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS12", "GEO", 9.0, 8.5, 8.5, 9.5);
            UpdateStudentSubjectScores("HS12", "CIV", 9.0, 8.0, 8.5, 8.0);
            UpdateStudentSubjectScores("HS12", "IT", 9.0, 9.0, 8.5, 8.0);
            UpdateStudentSubjectScores("HS12", "TECH", 9.5, 8.5, 8.0, 8.5);

            Students.Add(defaultStudent12);

            Student defaultStudent13 = new Student
            {
                maHS = "HS13",
                maLop = "12A1",
                hoVaTen = "Lê Thị Minh Anh",
                gioiTinh = 0,
                tenDangNhapHS = "anhle",
                matKhauHS = "anhle",
                ngSinh = new DateTime(2007, 1, 5),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS13", "MATH", 7.0, 8.0, 8.5, 8.5);
            UpdateStudentSubjectScores("HS13", "LIT", 7.5, 7.5, 8.5, 7.5);
            UpdateStudentSubjectScores("HS13", "ENG", 7.5, 9.5, 8.5, 9.0);
            UpdateStudentSubjectScores("HS13", "PHY", 8, 8.5, 9.5, 9.0);
            UpdateStudentSubjectScores("HS13", "CHEM", 8.5, 8.5, 8.0, 8.5);
            UpdateStudentSubjectScores("HS13", "BIO", 7.5, 8.0, 8.0, 8.5);

            Students.Add(defaultStudent13);

            Student defaultStudent14 = new Student
            {
                maHS = "HS14",
                maLop = "12A1",
                hoVaTen = "Nguyễn Văn Hùng",
                gioiTinh = 1,
                tenDangNhapHS = "hungnguyen",
                matKhauHS = "hungnguyen",
                ngSinh = new DateTime(2007, 3, 11),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };
            UpdateStudentSubjectScores("HS14", "MATH", 7.0, 8.0, 8.5, 8.5);
            UpdateStudentSubjectScores("HS14", "LIT", 7.5, 7.5, 8.5, 7.5);
            UpdateStudentSubjectScores("HS14", "ENG", 7.5, 9.5, 8.5, 9.0);
            UpdateStudentSubjectScores("HS14", "HIS", 9.0, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS14", "GEO", 9.0, 8.5, 8.5, 9.5);
            UpdateStudentSubjectScores("HS14", "CIV", 9.0, 8.0, 8.5, 8.0);
            UpdateStudentSubjectScores("HS14", "IT", 9.0, 9.0, 8.5, 8.0);
            UpdateStudentSubjectScores("HS14", "TECH", 9.5, 8.5, 8.0, 8.5);

            Students.Add(defaultStudent14);

            Student defaultStudent15 = new Student
            {
                maHS = "HS15",
                maLop = "12A1",
                hoVaTen = "Phạm Thị Quỳnh Như",
                gioiTinh = 0,
                tenDangNhapHS = "quynhpham",
                matKhauHS = "quynhpham",
                ngSinh = new DateTime(2007, 5, 23),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS15", "MATH", 8.0, 8.0, 8.5, 8.5);
            UpdateStudentSubjectScores("HS15", "LIT", 7.5, 8.5, 8.5, 8.5);
            UpdateStudentSubjectScores("HS15", "ENG", 7.5, 8.5, 8.5, 8.0);
            UpdateStudentSubjectScores("HS15", "HIS", 9.0, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS15", "GEO", 9.0, 8.0, 8.5, 9.5);
            UpdateStudentSubjectScores("HS15", "CIV", 9.0, 8.0, 9.5, 8.5);
            UpdateStudentSubjectScores("HS15", "IT", 9.0, 8.0, 8.5, 8.0);
            UpdateStudentSubjectScores("HS15", "TECH", 9.5, 8.0, 8.5, 8.5);

            Students.Add(defaultStudent15);

            Student defaultStudent16 = new Student
            {
                maHS = "HS16",
                maLop = "12A2",
                hoVaTen = "Trần Minh Tuấn",
                gioiTinh = 1,
                tenDangNhapHS = "tuantran",
                matKhauHS = "tuantran",
                ngSinh = new DateTime(2007, 7, 17),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS16", "HIS", 9.0, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS16", "GEO", 9.0, 8.5, 8.5, 9.5);
            UpdateStudentSubjectScores("HS16", "CIV", 9.0, 8.0, 8.5, 8.0);
            UpdateStudentSubjectScores("HS16", "IT", 9.0, 9.0, 8.5, 8.0);
            UpdateStudentSubjectScores("HS16", "TECH", 9.5, 8.5, 8.0, 8.5);

            Students.Add(defaultStudent16);

            Student defaultStudent17 = new Student
            {
                maHS = "HS17",
                maLop = "12A2",
                hoVaTen = "Lê Thị Hồng",
                gioiTinh = 0,
                tenDangNhapHS = "hongle",
                matKhauHS = "hongle",
                ngSinh = new DateTime(2007, 9, 30),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS17", "HIS", 8.0, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS17", "GEO", 9.5, 9.5, 9.5, 9.5);
            UpdateStudentSubjectScores("HS17", "CIV", 9.0, 8.5, 8.0, 8.0);
            UpdateStudentSubjectScores("HS17", "IT", 9.0, 8.0, 8.5, 8.0);
            UpdateStudentSubjectScores("HS17", "TECH", 9.5, 9.5, 8.0, 8.5);

            Students.Add(defaultStudent17);

            Student defaultStudent18 = new Student
            {
                maHS = "HS18",
                maLop = "12A2",
                hoVaTen = "Phạm Quang Anh",
                gioiTinh = 1,
                tenDangNhapHS = "anhpham",
                matKhauHS = "anhpham",
                ngSinh = new DateTime(2007, 12, 12),

                Math = CreateDefaultSubjectScore("MATH", "Toán học"),
                Literature = CreateDefaultSubjectScore("LIT", "Ngữ Văn"),
                ForeignLanguage = CreateDefaultSubjectScore("ENG", "Ngoại Ngữ"),
                Physics = CreateDefaultSubjectScore("PHY", "Vật Lý"),
                Chemistry = CreateDefaultSubjectScore("CHEM", "Hóa Học"),
                Biology = CreateDefaultSubjectScore("BIO", "Sinh Học"),
                History = CreateDefaultSubjectScore("HIS", "Lịch Sử"),
                Geography = CreateDefaultSubjectScore("GEO", "Địa Lý"),
                Civics = CreateDefaultSubjectScore("CIV", "Giáo Dục Công Dân"),
                IT = CreateDefaultSubjectScore("IT", "Tin Học"),
                Technology = CreateDefaultSubjectScore("TECH", "Công Nghệ")
            };

            UpdateStudentSubjectScores("HS18", "HIS", 7.0, 8.5, 9.0, 8.5);
            UpdateStudentSubjectScores("HS18", "GEO", 7.5, 9.5, 9.5, 8.5);
            UpdateStudentSubjectScores("HS18", "CIV", 7.0, 8.5, 8.0, 8.0);
            UpdateStudentSubjectScores("HS18", "IT", 8.0, 8.0, 8.5, 9.0);
            UpdateStudentSubjectScores("HS18", "TECH", 9.5, 10.0, 9.0, 8.5);

            Students.Add(defaultStudent18);

        }
        public List<Student> GetStudents()
        {
            return Students;
        }

        public Student GetStudent(string maHS)
        {
            foreach (Student student in Students)
            {
                if (student.maHS == maHS)
                {
                    return student;
                }
            }
            return null;
        }
        public List<string> GetUniqueClasses()
        {
            List<string> uniqueClasses = new List<string>();

            foreach (Student student in Students)
            {
                if (!uniqueClasses.Contains(student.maLop))
                {
                    uniqueClasses.Add(student.maLop);
                }
            }
            return uniqueClasses;
        }
        public List<Student> GetStudentsByClass(string className)
        {
            List<Student> studentsInClass = new List<Student>();

            // Tìm các học sinh thuộc lớp được chỉ định
            foreach (Student student in Students)
            {
                if (student.maLop == className)
                {
                    studentsInClass.Add(student);
                }
            }

            return studentsInClass;
        }
        public void UpdateStudentSubjectScores(string maHS, string maMon,
            double diemMieng, double diem15Phut, double diemGiuaKi, double diemCuoiKi)
        {
            if (!IsValidScore(diemMieng) || !IsValidScore(diem15Phut) ||
                !IsValidScore(diemGiuaKi) || !IsValidScore(diemCuoiKi))
            {
                throw new ArgumentException("Điểm số phải nằm trong khoảng từ 0 đến 10");
            }

            Student student = GetStudent(maHS);
            if (student == null) return;

            SubjectScore subjectScore = null;

            switch (maMon.ToUpper())
            {
                case "MATH": subjectScore = student.Math; break;
                case "LIT": subjectScore = student.Literature; break;
                case "ENG": subjectScore = student.ForeignLanguage; break;
                case "PHY": subjectScore = student.Physics; break;
                case "CHEM": subjectScore = student.Chemistry; break;
                case "BIO": subjectScore = student.Biology; break;
                case "HIS": subjectScore = student.History; break;
                case "GEO": subjectScore = student.Geography; break;
                case "CIV": subjectScore = student.Civics; break;
                case "IT": subjectScore = student.IT; break;
                case "TECH": subjectScore = student.Technology; break;
            }

            if (subjectScore != null)
            {
                subjectScore.DiemMieng = diemMieng;
                subjectScore.Diem15Phut = diem15Phut;
                subjectScore.DiemGiuaKi = diemGiuaKi;
                subjectScore.DiemCuoiKi = diemCuoiKi;
            }
        }

        private bool IsValidScore(double score)
        {
            return score >= 0 && score <= 10;
        }
    }
}
