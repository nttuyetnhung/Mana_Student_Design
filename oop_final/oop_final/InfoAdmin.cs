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
    public partial class InfoAdmin : Form
    {
        public InfoAdmin()
        {
            InitializeComponent();
        }

        private void btnExitAdmin_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnUpdateSt_Click(object sender, EventArgs e)
        {
            AddStudent f = new AddStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnUpdateTea_Click(object sender, EventArgs e)
        {
            UpdateTeacher f = new UpdateTeacher();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ListMember f = new ListMember();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void InfoAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
