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
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }

        

        private void btnExitScore_Click(object sender, EventArgs e)
        {
            InfoTeacher f = new InfoTeacher();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       
    }
}
