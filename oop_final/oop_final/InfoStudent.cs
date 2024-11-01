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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oop_final
{
    public partial class InfoStudent : Form
    {
        private Student _student;
        private Dictionary<string, List<SubjectScore>> studentScores;

        public InfoStudent(Student student, Dictionary<string, List<SubjectScore>> scoreboard)
        {
            InitializeComponent();
            _student = student;
            studentScores = scoreboard;
            DisplayStudentInfo(_student);
            InitializeData();
        }
        private void DisplayStudentInfo(Student student)
        {
            txbName.Text = _student.hoVaTen;
            txbID.Text = _student.maHS;
            txbClass.Text = _student.maLop;
            checkBox1.Checked = _student.gioiTinh == 0;
            checkBox2.Checked = _student.gioiTinh == 1;
            textBox1.Text = student.ngSinh.ToString("dd/MM/yyyy");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }
        public List<Student> studentAccounts;

        public List<SubjectScore> subjectScores = new List<SubjectScore>();
        private void InitializeData()
        {

            studentAccounts = new List<Student>();

            studentAccounts.Add(new Student { maHS = "HS1", maLop = "10A1", hoVaTen = "Trần Ngọc Mỹ", gioiTinh = 0, tenDangNhapHS = "mytran", matKhauHS = "mytran" });
            studentAccounts.Add(new Student { maHS = "HS2", maLop = "10A1", hoVaTen = "Nguyễn Thiên Ân", gioiTinh = 0, tenDangNhapHS = "annguyen", matKhauHS = "annguyen" });
            studentAccounts.Add(new Student { maHS = "HS3", maLop = "10A1", hoVaTen = "Lê An", gioiTinh = 1, tenDangNhapHS = "anle", matKhauHS = "anle" });

            studentScores = new Dictionary<string, List<SubjectScore>>();

            studentScores["HS1"] = new List<SubjectScore>
            {
                new SubjectScore { MaMon = "TOAN", TenMon = "Toán Học", DiemMieng = 10, Diem15Phut = 8.5, DiemGiuaKi = 9, DiemCuoiKi = 9.5 },
                new SubjectScore { MaMon = "VAN", TenMon = "Ngữ Văn", DiemMieng = 8, Diem15Phut = 8, DiemGiuaKi = 8, DiemCuoiKi = 8 },
                new SubjectScore { MaMon = "ANH", TenMon = "Ngoại Ngữ", DiemMieng = 9, Diem15Phut = 9.5f, DiemGiuaKi = 8.5, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "LY", TenMon = "Vật Lý", DiemMieng = 7.5, Diem15Phut = 8, DiemGiuaKi = 9, DiemCuoiKi = 8.5 },
                new SubjectScore { MaMon = "HOA", TenMon = "Hóa Học", DiemMieng = 8.5, Diem15Phut = 9, DiemGiuaKi = 9, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "SINH", TenMon = "Sinh Học", DiemMieng = 8, Diem15Phut = 8.5f, DiemGiuaKi = 9, DiemCuoiKi = 8.5 },
            };

            studentScores["HS2"] = new List<SubjectScore>
            {
                new SubjectScore { MaMon = "TOAN", TenMon = "Toán Học", DiemMieng = 7, Diem15Phut = 7.5, DiemGiuaKi = 8, DiemCuoiKi = 8 },
                new SubjectScore { MaMon = "VAN", TenMon = "Ngữ Văn", DiemMieng = 9, Diem15Phut = 8.5, DiemGiuaKi = 8.5, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "ANH", TenMon = "Ngoại Ngữ", DiemMieng = 8.5, Diem15Phut = 8, DiemGiuaKi = 7.5, DiemCuoiKi = 8 },
                new SubjectScore { MaMon = "LY", TenMon = "Vật Lý", DiemMieng = 8, Diem15Phut = 9, DiemGiuaKi = 8.5, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "HOA", TenMon = "Hóa Học", DiemMieng = 9, Diem15Phut = 8, DiemGiuaKi = 8.5, DiemCuoiKi = 8 },
                new SubjectScore { MaMon = "SINH", TenMon = "Sinh Học", DiemMieng = 7.5, Diem15Phut = 8, DiemGiuaKi = 8, DiemCuoiKi = 8.5 },
            };
            studentScores["HS3"] = new List<SubjectScore>
            {
                new SubjectScore { MaMon = "TOAN", TenMon = "Toán Học", DiemMieng = 8.5, Diem15Phut = 9, DiemGiuaKi = 9.5, DiemCuoiKi = 8.5 },
                new SubjectScore { MaMon = "VAN", TenMon = "Ngữ Văn", DiemMieng = 8.5, Diem15Phut = 9, DiemGiuaKi = 9, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "ANH", TenMon = "Ngoại Ngữ", DiemMieng = 9, Diem15Phut = 8, DiemGiuaKi = 8, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "LY", TenMon = "Vật Lý", DiemMieng = 8, Diem15Phut = 8.5, DiemGiuaKi = 9, DiemCuoiKi = 9 },
                new SubjectScore { MaMon = "HOA", TenMon = "Hóa Học", DiemMieng = 7.5, Diem15Phut = 8, DiemGiuaKi = 8.5, DiemCuoiKi = 8 },
                new SubjectScore { MaMon = "SINH", TenMon = "Sinh Học", DiemMieng = 8.5, Diem15Phut = 8, DiemGiuaKi = 9, DiemCuoiKi = 8.5 },
            };

        }
        public void LoadScoreData()
        {
            lvList.Items.Clear(); 

            // Check if there are scores for the current student
            if (studentScores.ContainsKey(_student.maHS))
            {
                List<SubjectScore> scores = studentScores[_student.maHS];

                foreach (var score in scores)
                {
                    ListViewItem item = new ListViewItem(score.MaMon);
                    item.SubItems.Add(score.TenMon);
                    item.SubItems.Add(score.DiemMieng.ToString());
                    item.SubItems.Add(score.Diem15Phut.ToString());
                    item.SubItems.Add(score.DiemGiuaKi.ToString());
                    item.SubItems.Add(score.DiemCuoiKi.ToString());
                    item.SubItems.Add(score.DiemTBM.ToString("F1"));
                    lvList.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Hiện tại không có điểm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadSchoolYears()
        {
            comboBox1.Items.AddRange(new string[] { "2023-2024" });
        }
        private void InfoStudent_Load(object sender, EventArgs e)
        {
            InitializeData();
            LoadSchoolYears();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSchoolYears();
        }

        private void btnSearchUdSor_Click_1(object sender, EventArgs e)
        {
            string selectedYear = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedYear))
            {
                MessageBox.Show("Vui lòng chọn năm học!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadScoreData();
        }
    }
}

