﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewminder1
{
    public partial class confirmLogout : Form
    {
        public confirmLogout()
        {
            InitializeComponent();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
