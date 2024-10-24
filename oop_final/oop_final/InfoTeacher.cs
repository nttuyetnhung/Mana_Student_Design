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
    public partial class InfoTeacher : Form
    {
        private Teacher currentTeacher;
        public InfoTeacher()
        {
            InitializeComponent();

        }
        public InfoTeacher(Teacher teacher)
        {
            InitializeComponent();
            currentTeacher = teacher;
            DisplayTeacherInfo();
        }

        private void DisplayTeacherInfo()
        {
            if (currentTeacher != null)
            {
                // Hiển thị thông tin
                txbName.Text = currentTeacher.hoVaTen;
                txbMaGV.Text = currentTeacher.maGV;
                txbGioitinh.Text = currentTeacher.gioiTinh == 0 ? "Nữ" : "Nam";
                if (currentTeacher.ngSinh != default(DateTime))
                {
                    txbNgsinh.Text = currentTeacher.ngSinh.ToString("dd/MM/yyyy");
                }
                txbChucvu.Text = currentTeacher.chucVu;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnUpdateSorce_Click(object sender, EventArgs e)
        {
            UpdateScore f = new UpdateScore();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSeeSorce_Click(object sender, EventArgs e)
        {

            ScoreBoard f = new ScoreBoard();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       
        private void InfoTeacher_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
