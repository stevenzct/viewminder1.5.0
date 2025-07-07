using System;
using System.Windows.Forms;

namespace viewminder1
{
    public partial class wrong_credentials : Form
    {
        public wrong_credentials()
        {
            InitializeComponent();
        }

        private void Guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Wrong_credentials_Load(object sender, EventArgs e)
        {
            
            

          
        }

        private void Guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }
    }
}
