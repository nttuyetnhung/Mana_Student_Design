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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            InfoAdmin f = new InfoAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
