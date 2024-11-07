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
        private readonly AccountStudent accountStudent;
        private List<Student> Students;
        private Dictionary<string, AccountStudent> studentAccounts = new Dictionary<string, AccountStudent>();
        public ScoreBoard()
        {
            InitializeComponent();
            accountStudent = AccountStudent.Instance;
            Students = accountStudent.GetStudents();
            InitializeData();
        }
        
        private void InitializeData()
        {
            if (accountStudent.Students == null || !accountStudent.Students.Any())
            {
                accountStudent.InitializeDefaultData();
            }
            Students = accountStudent.Students;

            comboBox1.Items.AddRange(new string[] { "2023-2024" });

            var classes = Students.Select(s => s.maLop).Distinct().ToArray();
            comboBox2.Items.AddRange(classes);
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
            InitializeTab2Data(); 

            // Đăng ký sự kiện click cho button1
            button1.Click += button1_Click;
        }
        private void btnSearchScore_Click(object sender, EventArgs e)
        {
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
                List<Student> studentsInClass = GetStudentsByClass(className);
                Student students = new Student();
                lvSBTeacher.Items.Clear();
                int stt = 1;

                foreach (Student student in studentsInClass)
                {
                    ListViewItem item = new ListViewItem(stt.ToString());
                    item.SubItems.Add(student.maHS);
                    item.SubItems.Add(student.hoVaTen);

                    item.SubItems.Add(student.Math.DiemTBM.ToString("F2"));
                    item.SubItems.Add(student.Literature.DiemTBM.ToString("F2"));
                    item.SubItems.Add(student.ForeignLanguage.DiemTBM.ToString("F2"));
                    item.SubItems.Add(student.Physics.DiemTBM.ToString("F2"));
                    item.SubItems.Add(student.Chemistry.DiemTBM.ToString("F2"));
                    item.SubItems.Add(student.Biology.DiemTBM.ToString("F2"));
                    item.SubItems.Add(student.History.DiemTBM.ToString("F2"));
                    item.SubItems.Add(student.Geography.DiemTBM.ToString("F2"));
                    item.SubItems.Add(student.Civics.DiemTBM.ToString("F2"));
                    item.SubItems.Add(student.IT.DiemTBM.ToString("F2"));
                    item.SubItems.Add(student.Technology.DiemTBM.ToString("F2"));

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

        private void InitializeTab2Data()
        {
            // Khởi tạo dữ liệu năm học
            comboBox4.Items.AddRange(new string[] { "2023-2024" });

            // Khởi tạo dữ liệu lớp học
            comboBox3.Items.AddRange(GetUniqueClasses().ToArray());
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
                // Tìm học sinh theo tên và lớp
                Student student = null;

                foreach (Student s in Students)
                {
                    if (s.hoVaTen.IndexOf(studentName, StringComparison.OrdinalIgnoreCase) >= 0 &&
                        s.maLop == className)
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

                // Hiển thị bảng điểm
                listView1.Items.Clear();
                List<SubjectScore> scores = new List<SubjectScore>() { student.Math, student.Literature, student.ForeignLanguage, student.Physics, student.Chemistry, student.Biology, student.History, student.Geography, student.Civics, student.IT, student.Technology };
                int stt = 1;
                foreach (SubjectScore score in scores)
                {
                    ListViewItem item = new ListViewItem(stt.ToString());
                    item.SubItems.Add(score.MaMon);
                    item.SubItems.Add(score.TenMon);
                    item.SubItems.Add(score.DiemMieng.ToString("F1"));
                    item.SubItems.Add(score.Diem15Phut.ToString("F1"));
                    item.SubItems.Add(score.DiemGiuaKi.ToString("F1"));
                    item.SubItems.Add(score.DiemCuoiKi.ToString("F1"));
                    item.SubItems.Add(score.DiemTBM.ToString("F1"));

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

            // Lấy danh sách các lớp không trùng lặp
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
            if (Students == null)
            {
                Students = accountStudent.Students;
            }

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
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
