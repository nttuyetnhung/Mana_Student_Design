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
        public InfoTeacher()
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
    }
}
