using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewminder1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\Admin.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from login1 where id = '" + guna2TextBox6.Text + "' and username = '" + guna2TextBox5.Text + "' and password = '" + guna2TextBox4.Text + "'" , conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            else
            {
                wrong_credentials w = new wrong_credentials();
                w.Show();
            }
        }

        private void Guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
