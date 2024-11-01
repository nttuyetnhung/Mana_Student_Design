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
        public void LoadScoreData()
        {
            lvList.Items.Clear();

            if (studentScores.TryGetValue(_student.maHS, out List<SubjectScore> scores))
            {
                foreach (SubjectScore score in scores)
                {
                    ListViewItem item = new ListViewItem(score.MaMon);
                    item.SubItems.Add(score.TenMon);
                    item.SubItems.Add(score.DiemMieng.ToString("F2"));
                    item.SubItems.Add(score.Diem15Phut.ToString("F2"));
                    item.SubItems.Add(score.DiemGiuaKi.ToString("F2"));
                    item.SubItems.Add(score.DiemCuoiKi.ToString("F2"));
                    item.SubItems.Add(score.DiemTBM.ToString("F2"));
                    lvList.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No scores available for this student.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadSchoolYears()
        {
            comboBox1.Items.AddRange(new string[] { "2023-2024" });
        }
        private void InfoStudent_Load(object sender, EventArgs e)
        {
            LoadScoreData();
            LoadSchoolYears();
        }
        private void btnSearchUdSor_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadScoreData();
            LoadScoreData();
        }
    }
}

