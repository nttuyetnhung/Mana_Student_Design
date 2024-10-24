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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }




        private void btnTeacher_Click(object sender, EventArgs e)
        {
            LoginTeacher f = new LoginTeacher();
            this.Hide();
            f.ShowDialog();
            //this.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            LoginStudent f = new LoginStudent();
            this.Hide();
            f.ShowDialog();
            //this.Show();
        }
     

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
