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
    public partial class ListMember : Form
    {
        public ListMember()
        {
            InitializeComponent();
        }

        private void btnExitListSt_Click(object sender, EventArgs e)
        {
            InfoAdmin f = new InfoAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnExitListTea_Click(object sender, EventArgs e)
        {
            InfoAdmin f = new InfoAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       
    }
}
