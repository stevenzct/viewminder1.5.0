using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace viewminder1
{
    public partial class adminProfileUpdatedSuccess : Form
    {
       

        public adminProfileUpdatedSuccess()
        {
            InitializeComponent();
        }

        private void Guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            // Close the success form
            this.Close();

            // Navigate back to TabPage5 of TabControl1 in Form1
          //  Form1 mainForm = Application.OpenForms["Form1"] as Form1;
          //  mainForm.tabControl1.SelectTab(4); // 0-based index, so 4 corresponds to TabPage5

        }
    }
}
