﻿using System;
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
    public partial class InfoStudent : Form
    {
        public InfoStudent()
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InfoStudent_Load(object sender, EventArgs e)
        {

        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
               
        }
    }
}

