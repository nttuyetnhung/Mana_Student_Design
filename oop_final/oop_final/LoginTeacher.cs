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
    public partial class LoginTeacher : Form
    {
        public LoginTeacher()
        {
            InitializeComponent();
        }

      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            InfoTeacher f = new InfoTeacher();
            this.Hide();
            f.ShowDialog();
            this.Show();

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
