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

        List<Teacher> teacherAccount = AccountTeacher.Instance.teacherAccounts;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkLogin(txbTeacherName.Text, txbTeacherPass.Text))
            {
                InfoTeacher f = new InfoTeacher();
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông báo");
            }

        }
        public bool checkLogin(string username, string password)
        {
            for (int i = 0; i < teacherAccount.Count; i++)
            {
                if (username == teacherAccount[i].tenDangNhapGV && password == teacherAccount[i].matKhauGV)
                {
                    return true;
                }
            }
            return false;
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
