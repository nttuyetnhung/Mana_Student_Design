using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            comboBox1.Items.AddRange(new string[] { "2021-2022", "2022-2023", "2023-2024" });

            // Populate comboBox2 (Lớp học) - Lấy danh sách lớp unique từ dữ liệu
            var uniqueClasses = studentAccounts.Select(s => s.maLop).Distinct().ToList();
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
            //InitializeData();
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
                var studentsInClass = studentAccounts.Where(s => s.maLop == className).ToList();

                lvSBTeacher.Items.Clear();
                int stt = 1;

                foreach (var student in studentsInClass)
                {
                    student.MathScore = 10;
                    student.LiteratureScore = 8;
                    student.ForeignLanguageScore = 10;
                    student.PhysicsScore = 6;
                    student.ChemistryScore = 8;
                    student.BiologyScore = 9;
                    student.HistoryScore = 9.6f;
                    student.GeographyScore = 8.5f;
                    student.CivicsScore = 9;
                    student.ITScore = 10;
                    student.TechnologyScore = 8.9f;

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
                    //*F2 là thể hiện 2 số thập phân

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

        private void InitializeTab2Data()
        {
            // Khởi tạo dữ liệu năm học
            comboBox4.Items.AddRange(new string[] { "2023-2024" });

            // Khởi tạo dữ liệu lớp học
            var uniqueClasses = studentAccounts.Select(s => s.maLop).Distinct().ToList();
            comboBox3.Items.AddRange(uniqueClasses.ToArray());

            // Khởi tạo dictionary lưu điểm của học sinh
            studentScores = new Dictionary<string, List<SubjectScore>>();

            // Tạo dữ liệu mẫu cho mỗi học sinh
            foreach (var student in studentAccounts)
            {
                //cho random điểm để demo
                var subjectScores = new List<SubjectScore>
                {
                new SubjectScore { MaMon = "TOAN", TenMon = "Toán Học", DiemMieng = 10, Diem15Phut = 7.5f, DiemGiuaKi = 8, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "VAN", TenMon = "Ngữ Văn", DiemMieng = 10, Diem15Phut = 8, DiemGiuaKi = 8, DiemCuoiKi = 8 },
                new SubjectScore { MaMon = "ANH", TenMon = "Ngoại Ngữ", DiemMieng = 9, Diem15Phut = 8.5f, DiemGiuaKi = 9, DiemCuoiKi = 8.5f },
                new SubjectScore { MaMon = "LY", TenMon = "Vật Lý", DiemMieng = 8, Diem15Phut = 7.5f, DiemGiuaKi = 8.5f, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "HOA", TenMon = "Hóa Học", DiemMieng = 9.5f, Diem15Phut = 8, DiemGiuaKi = 8, DiemCuoiKi = 8 },
                new SubjectScore { MaMon = "SINH", TenMon = "Sinh Học", DiemMieng = 9, Diem15Phut = 8.5f, DiemGiuaKi = 9, DiemCuoiKi = 8.5f },
                new SubjectScore { MaMon = "SU", TenMon = "Lịch Sử", DiemMieng = 8, Diem15Phut = 7.5f, DiemGiuaKi = 8.5f, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "DIA", TenMon = "Địa Lý", DiemMieng = 9.5f, Diem15Phut = 8, DiemGiuaKi = 7.5f, DiemCuoiKi = 8 },
                new SubjectScore { MaMon = "GDCD", TenMon = "GDCD", DiemMieng = 9, Diem15Phut = 8.5f, DiemGiuaKi = 9, DiemCuoiKi = 8.5f },
                new SubjectScore { MaMon = "TIN", TenMon = "Tin Học", DiemMieng = 8, Diem15Phut = 7.5f, DiemGiuaKi = 8.5f, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "CN", TenMon = "Công nghệ", DiemMieng = 8.5f, Diem15Phut = 8, DiemGiuaKi = 7.5f, DiemCuoiKi = 8 },
                };
                studentScores[student.maHS] = subjectScores;
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
                var student = studentAccounts.FirstOrDefault(s =>
                    s.hoVaTen.Contains(studentName, StringComparison.OrdinalIgnoreCase) &&
                    s.maLop == className);

                if (student == null)
                {
                    MessageBox.Show("Không tìm thấy học sinh!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                listView1.Items.Clear();
                int stt = 1;

                var scores = studentScores[student.maHS];
                foreach (var score in scores)
                {
                    ListViewItem item = new ListViewItem(stt.ToString());
                    item.SubItems.Add(score.MaMon);
                    item.SubItems.Add(score.TenMon);
                    item.SubItems.Add(score.DiemMieng.ToString("F1"));
                    item.SubItems.Add(score.Diem15Phut.ToString("F1"));
                    item.SubItems.Add(score.DiemGiuaKi.ToString("F1"));
                    item.SubItems.Add(score.DiemCuoiKi.ToString("F1"));
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
        public float DiemMieng { get; set; }
        public float Diem15Phut { get; set; }
        public float DiemGiuaKi { get; set; }
        public float DiemCuoiKi { get; set; }
        public float DiemTBM
        {
            get
            {
                return (DiemMieng + Diem15Phut + DiemGiuaKi * 2 + DiemCuoiKi * 3) / 7;
            }
        }
    }
}
