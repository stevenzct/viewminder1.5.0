using System;
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
    public partial class adminDeletedSuccess : Form
    {
        public adminDeletedSuccess()
        {
            InitializeComponent();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            // superAdmin sa = new superAdmin();
            // sa.Show();
            superAdmn sua = new superAdmn();
            sua.Show();
        }
    }
}
