using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace oop_final
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
            InitializeData();
        }

        public List<Student> studentAccounts;
        private void InitializeData()
        {

            studentAccounts = new List<Student>();
            // Thêm tất cả dữ liệu học sinh như bạn đã cung cấp
            studentAccounts.Add(new Student { maHS = "HS1", maLop = "10A1", hoVaTen = "Trần Ngọc Mỹ", gioiTinh = 0, tenDangNhapHS = "mytran", matKhauHS = "mytran" });
            studentAccounts.Add(new Student { maHS = "HS2", maLop = "10A1", hoVaTen = "Nguyễn Thiên Ân", gioiTinh = 0, tenDangNhapHS = "annguyen", matKhauHS = "annguyen" });
            studentAccounts.Add(new Student { maHS = "HS3", maLop = "10A1", hoVaTen = "Lê An", gioiTinh = 1, tenDangNhapHS = "anle", matKhauHS = "anle" });
            studentAccounts.Add(new Student { maHS = "HS4", maLop = "10A2", hoVaTen = "Lê Hoàng Phương", gioiTinh = 0, tenDangNhapHS = "phuongle", matKhauHS = "phuongle" });
            studentAccounts.Add(new Student { maHS = "HS5", maLop = "10A2", hoVaTen = "Nguyễn Thúc Thùy Tiên", gioiTinh = 0, tenDangNhapHS = "tiennguyen", matKhauHS = "tiennguyen" });
            studentAccounts.Add(new Student { maHS = "HS6", maLop = "10A2", hoVaTen = "Nguyễn Quốc Thiên", gioiTinh = 1, tenDangNhapHS = "thiennguyen", matKhauHS = "thiennguyen" });
            studentAccounts.Add(new Student { maHS = "HS7", maLop = "11A1", hoVaTen = "Trần Văn Bình", gioiTinh = 1, tenDangNhapHS = "binhtran", matKhauHS = "binhtran" });
            studentAccounts.Add(new Student { maHS = "HS8", maLop = "11A1", hoVaTen = "Nguyễn Thị Hạnh", gioiTinh = 0, tenDangNhapHS = "hanhnguyen", matKhauHS = "hanhnguyen" });
            studentAccounts.Add(new Student { maHS = "HS9", maLop = "11A1", hoVaTen = "Lê Quang Huy", gioiTinh = 1, tenDangNhapHS = "huyle", matKhauHS = "huyle" });
            studentAccounts.Add(new Student { maHS = "HS10", maLop = "11A2", hoVaTen = "Trần Minh Hoàng", gioiTinh = 1, tenDangNhapHS = "hoangtran", matKhauHS = "hoangtran" });
            studentAccounts.Add(new Student { maHS = "HS11", maLop = "11A2", hoVaTen = "Lê Thị Thu Hà", gioiTinh = 0, tenDangNhapHS = "hale", matKhauHS = "hale" });
            studentAccounts.Add(new Student { maHS = "HS12", maLop = "11A2", hoVaTen = "Ngô Quang Vinh", gioiTinh = 1, tenDangNhapHS = "vinhngo", matKhauHS = "vinhngo" });
            studentAccounts.Add(new Student { maHS = "HS13", maLop = "12A2", hoVaTen = "Lê Thị Minh Anh", gioiTinh = 0, tenDangNhapHS = "anhle", matKhauHS = "anhle" });
            studentAccounts.Add(new Student { maHS = "HS14", maLop = "12A1", hoVaTen = "Nguyễn Văn Hùng", gioiTinh = 1, tenDangNhapHS = "hungnguyen", matKhauHS = "hungnguyen" });
            studentAccounts.Add(new Student { maHS = "HS15", maLop = "12A1", hoVaTen = "Phạm Thị Quỳnh Như", gioiTinh = 0, tenDangNhapHS = "quynhpham", matKhauHS = "quynhpham" });
            studentAccounts.Add(new Student { maHS = "HS16", maLop = "12A1", hoVaTen = "Trần Minh Tuấn", gioiTinh = 1, tenDangNhapHS = "tuantran", matKhauHS = "tuantran" });
            studentAccounts.Add(new Student { maHS = "HS17", maLop = "12A2", hoVaTen = "Lê Thị Hồng", gioiTinh = 0, tenDangNhapHS = "hongle", matKhauHS = "hongle" });
            studentAccounts.Add(new Student { maHS = "HS18", maLop = "12A2", hoVaTen = "Phạm Quang Anh", gioiTinh = 1, tenDangNhapHS = "anhpham", matKhauHS = "anhpham" });

            // Populate comboBox1 (Năm học)
            comboBox1.Items.AddRange(new string[] { "2023-2024" });

            // Populate comboBox2 (Lớp học) - Lấy danh sách lớp unique từ dữ liệu
            List<string> uniqueClasses = studentAccounts.Select(s => s.maLop).Distinct().ToList();
            comboBox2.Items.AddRange(uniqueClasses.ToArray());
        }

        private void btnExitScore_Click(object sender, EventArgs e)
        {
            InfoTeacher f = new InfoTeacher();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            InitializeTab2Data(); // Khởi tạo dữ liệu cho tab 2

            // Đăng ký sự kiện click cho button1
            button1.Click += button1_Click;
        }
        private void btnSearchScore_Click(object sender, EventArgs e)
        {
            // Get selected class and school year from ComboBoxes
            string selectedClass = comboBox2.SelectedItem?.ToString();
            string selectedYear = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedYear) || string.IsNullOrEmpty(selectedClass))
            {
                MessageBox.Show("Vui lòng chọn năm học và lớp học!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DisplayStudentScores(selectedClass);
        }

        public void DisplayStudentScores(string className)
        {
            try
            {
                // Lọc học sinh theo lớp
                List<Student> studentsInClass = new List<Student>();

                foreach (Student s in studentAccounts)
                {
                    if (s.maLop == className)
                    {
                        studentsInClass.Add(s);
                    }
                }

                lvSBTeacher.Items.Clear();
                int stt = 1;

                foreach (Student student in studentsInClass)
                {
                    switch (stt)
                    {
                        case 1:
                            student.MathScore = 8.5;
                            student.LiteratureScore = 9;
                            student.ForeignLanguageScore = 9;
                            student.PhysicsScore = 9;
                            student.ChemistryScore = 8.5;
                            student.BiologyScore = 7.5f;
                            student.HistoryScore = 8.6f;
                            student.GeographyScore = 9.5f;
                            student.CivicsScore = 10;
                            student.ITScore = 9;
                            student.TechnologyScore = 8.7f;
                            break;
                        case 2:
                            student.MathScore = 8;
                            student.LiteratureScore = 9;
                            student.ForeignLanguageScore = 8;
                            student.PhysicsScore = 9;
                            student.ChemistryScore = 8;
                            student.BiologyScore = 9.5f;
                            student.HistoryScore = 8;
                            student.GeographyScore = 7.5f;
                            student.CivicsScore = 8;
                            student.ITScore = 9.2f;
                            student.TechnologyScore = 7.9f;
                            break;
                        case 3:
                            
                            student.MathScore = 9.5f;
                            student.LiteratureScore = 8;
                            student.ForeignLanguageScore = 9;
                            student.PhysicsScore = 8.5f;
                            student.ChemistryScore = 9;
                            student.BiologyScore = 8.5f;
                            student.HistoryScore = 9;
                            student.GeographyScore = 8.8f;
                            student.CivicsScore = 8.9f;
                            student.ITScore = 7;
                            student.TechnologyScore = 9.4f;
                            break;
                        default:
                            student.MathScore = 6;
                            student.LiteratureScore = 7;
                            student.ForeignLanguageScore = 6.5f;
                            student.PhysicsScore = 7.5f;
                            student.ChemistryScore = 6.8f;
                            student.BiologyScore = 7.2f;
                            student.HistoryScore = 8;
                            student.GeographyScore = 7.6f;
                            student.CivicsScore = 8.1f;
                            student.ITScore = 7.4f;
                            student.TechnologyScore = 6.9f;
                            break;
                    }

                    ListViewItem item = new ListViewItem(stt.ToString());
                    item.SubItems.Add(student.maHS);
                    item.SubItems.Add(student.hoVaTen);
                    item.SubItems.Add(student.MathScore.ToString("F2"));
                    item.SubItems.Add(student.LiteratureScore.ToString("F2"));
                    item.SubItems.Add(student.ForeignLanguageScore.ToString("F2"));
                    item.SubItems.Add(student.PhysicsScore.ToString("F2"));
                    item.SubItems.Add(student.ChemistryScore.ToString("F2"));
                    item.SubItems.Add(student.BiologyScore.ToString("F2"));
                    item.SubItems.Add(student.HistoryScore.ToString("F2"));
                    item.SubItems.Add(student.GeographyScore.ToString("F2"));
                    item.SubItems.Add(student.CivicsScore.ToString("F2"));
                    item.SubItems.Add(student.ITScore.ToString("F2"));
                    item.SubItems.Add(student.TechnologyScore.ToString("F2"));

                    lvSBTeacher.Items.Add(item);
                    stt++;
                }

                if (studentsInClass.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy học sinh nào trong lớp này!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // BẢNG ĐIỂM THEO MÔN
        private Dictionary<string, List<SubjectScore>> studentScores;
        public List<SubjectScore> subjectScores = new List<SubjectScore>();

        private void InitializeTab2Data()
        {
            // Khởi tạo dữ liệu năm học
            comboBox4.Items.AddRange(new string[] { "2023-2024" });

            // Khởi tạo dữ liệu lớp học
            List<string> uniqueClasses = new List<string>();
            foreach (var student in studentAccounts)
            {
                if (!uniqueClasses.Contains(student.maLop))
                {
                    uniqueClasses.Add(student.maLop);
                }
            }
            comboBox3.Items.AddRange(uniqueClasses.ToArray());

            // Khởi tạo dictionary lưu điểm của học sinh
            studentScores = new Dictionary<string, List<SubjectScore>>();

            // Tạo dữ liệu mẫu cho mỗi học sinh
            int studentIndex = 0;

            foreach (Student student in studentAccounts)
            {
                if (studentIndex % 3 == 0)
                {
                    subjectScores = new List<SubjectScore>
                    {
                        new SubjectScore { MaMon = "TOAN", TenMon = "Toán Học", DiemMieng = 10, Diem15Phut = 8.5, DiemGiuaKi = 9, DiemCuoiKi = 9.5 },
                        new SubjectScore { MaMon = "VAN", TenMon = "Ngữ Văn", DiemMieng = 8, Diem15Phut = 8, DiemGiuaKi = 8, DiemCuoiKi = 8 },
                        new SubjectScore { MaMon = "ANH", TenMon = "Ngoại Ngữ", DiemMieng = 9, Diem15Phut = 9.5f, DiemGiuaKi = 8.5, DiemCuoiKi = 9 },
                        new SubjectScore { MaMon = "LY", TenMon = "Vật Lý", DiemMieng = 7.5, Diem15Phut = 8, DiemGiuaKi = 9, DiemCuoiKi = 8.5 },
                        new SubjectScore { MaMon = "HOA", TenMon = "Hóa Học", DiemMieng = 8.5, Diem15Phut = 9, DiemGiuaKi = 9, DiemCuoiKi = 9 },
                        new SubjectScore { MaMon = "SINH", TenMon = "Sinh Học", DiemMieng = 8, Diem15Phut = 8.5f, DiemGiuaKi = 9, DiemCuoiKi = 8.5 },
                    };
                }
                else if (studentIndex % 3 == 1)
                {
                    subjectScores = new List<SubjectScore>
                    {
                        new SubjectScore { MaMon = "TOAN", TenMon = "Toán Học", DiemMieng = 7, Diem15Phut = 7.5, DiemGiuaKi = 8, DiemCuoiKi = 8 },
                        new SubjectScore { MaMon = "VAN", TenMon = "Ngữ Văn", DiemMieng = 9, Diem15Phut = 8.5, DiemGiuaKi = 8.5, DiemCuoiKi = 9 },
                        new SubjectScore { MaMon = "ANH", TenMon = "Ngoại Ngữ", DiemMieng = 8.5, Diem15Phut = 8, DiemGiuaKi = 7.5, DiemCuoiKi = 8 },
                        new SubjectScore { MaMon = "LY", TenMon = "Vật Lý", DiemMieng = 8, Diem15Phut = 9, DiemGiuaKi = 8.5, DiemCuoiKi = 9 },
                        new SubjectScore { MaMon = "HOA", TenMon = "Hóa Học", DiemMieng = 9, Diem15Phut = 8, DiemGiuaKi = 8.5, DiemCuoiKi = 8 },
                        new SubjectScore { MaMon = "SINH", TenMon = "Sinh Học", DiemMieng = 7.5, Diem15Phut = 8, DiemGiuaKi = 8, DiemCuoiKi = 8.5 },
                    };
                }
                else
                {
                    subjectScores = new List<SubjectScore>
                    {
                        new SubjectScore { MaMon = "TOAN", TenMon = "Toán Học", DiemMieng = 8.5, Diem15Phut = 9, DiemGiuaKi = 9.5, DiemCuoiKi = 8.5 },
                        new SubjectScore { MaMon = "VAN", TenMon = "Ngữ Văn", DiemMieng = 8.5, Diem15Phut = 9, DiemGiuaKi = 9, DiemCuoiKi = 9 },
                        new SubjectScore { MaMon = "ANH", TenMon = "Ngoại Ngữ", DiemMieng = 9, Diem15Phut = 8, DiemGiuaKi = 8, DiemCuoiKi = 9 },
                        new SubjectScore { MaMon = "LY", TenMon = "Vật Lý", DiemMieng = 8, Diem15Phut = 8.5, DiemGiuaKi = 9, DiemCuoiKi = 9 },
                        new SubjectScore { MaMon = "HOA", TenMon = "Hóa Học", DiemMieng = 7.5, Diem15Phut = 8, DiemGiuaKi = 8.5, DiemCuoiKi = 8 },
                        new SubjectScore { MaMon = "SINH", TenMon = "Sinh Học", DiemMieng = 8.5, Diem15Phut = 8, DiemGiuaKi = 9, DiemCuoiKi = 8.5 },
                    };
                }
                studentScores[student.maHS] = subjectScores;
                studentIndex++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = textBox1.Text.Trim();
            string selectedClass = comboBox3.SelectedItem?.ToString();
            string selectedYear = comboBox4.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedYear) || string.IsNullOrEmpty(selectedClass))
            {
                MessageBox.Show("Vui lòng chọn năm học và lớp học!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DisplayStudentSubjectScores(studentName, selectedClass);
        }
        private void DisplayStudentSubjectScores(string studentName, string className)
        {
            try
            {
                Student student = null;

                foreach (Student s in studentAccounts)
                {
                    if (s.hoVaTen.Contains(studentName, StringComparison.OrdinalIgnoreCase) && s.maLop == className)
                    {
                        student = s;
                        break;
                    }
                }

                if (student == null)
                {
                    MessageBox.Show("Không tìm thấy học sinh!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                listView1.Items.Clear();
                int stt = 1;

                List<SubjectScore> scores = studentScores[student.maHS];
                foreach (SubjectScore score in scores)
                {
                    ListViewItem item = new ListViewItem(stt.ToString());
                    item.SubItems.Add(score.MaMon);
                    item.SubItems.Add(score.TenMon);
                    item.SubItems.Add(score.DiemMieng.ToString("F2"));
                    item.SubItems.Add(score.Diem15Phut.ToString("F2"));
                    item.SubItems.Add(score.DiemGiuaKi.ToString("F2"));
                    item.SubItems.Add(score.DiemCuoiKi.ToString("F2"));
                    item.SubItems.Add(score.DiemTBM.ToString("F2"));

                    listView1.Items.Add(item);
                    stt++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class SubjectScore
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public double DiemMieng { get; set; }
        public double Diem15Phut { get; set; }
        public double DiemGiuaKi { get; set; }
        public double DiemCuoiKi { get; set; }
        public double DiemTBM
        {
            get
            {
                return (DiemMieng + Diem15Phut + DiemGiuaKi * 2 + DiemCuoiKi * 3) / 7;
            }
        }
    }
}
