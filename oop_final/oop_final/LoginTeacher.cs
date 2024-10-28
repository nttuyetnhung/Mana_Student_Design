using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace oop_final
{
    public partial class LoginTeacher : Form
    {
        public LoginTeacher()
        {
            InitializeComponent();
        }
        private void txbTeacherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTeacherPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbTeacherName.Text;
            string password = txbTeacherPass.Text;

            Teacher teacher = AccountTeacher.Instance.GetTeacherByUsername(username);
            if (teacher != null && teacher.matKhauGV == password)
            {
                InfoTeacher infoTeacher = new InfoTeacher(teacher);
                this.Hide();
                infoTeacher.ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông báo");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void LoginTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
