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
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher()
        {
            InitializeComponent();
        }

        private void btnExitUpTea_Click(object sender, EventArgs e)
        {
            InfoAdmin f = new InfoAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
