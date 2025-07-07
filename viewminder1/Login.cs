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
using Guna.UI2.WinForms;

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
            conn.Open();
            string query = "SELECT * FROM login1 WHERE id = @id AND username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", guna2TextBox6.Text);
            cmd.Parameters.AddWithValue("@username", guna2TextBox5.Text);
            cmd.Parameters.AddWithValue("@password", guna2TextBox4.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // Fetch the user data
                string fullName = reader["fullName"].ToString();
                string username = reader["username"].ToString();
                string email = reader["email"].ToString();
                string id = reader["id"].ToString();
                string pin = reader["pin"].ToString();
                string password = reader["password"].ToString();

                // Access Form1 and set the label values
                Form1 main = new Form1();
                main.Show();

                // Call the public methods to update the labels on Form1
                main.SetLabel39Text(fullName);
                main.SetLabel40Text(username);
                main.SetLabel42Text(email);
                main.SetLabel46Text(id);
                main.SetLabel48Text(pin);
                main.SetLabel50Text(password);

                this.Hide();
            }
            else
            {
                wrong_credentials w = new wrong_credentials();
                w.Show();
            }

            conn.Close();
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

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass fg = new ForgotPass();
            this.Hide();
            fg.Show();
        }

        private void Guna2Button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
            superAdmin sa = new superAdmin();
            sa.Show();
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            newAdmin na = new newAdmin();
            na.Show();
        }

        private void Guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void Guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
            superAdmn su = new superAdmn();
            su.Show();
        }

        private void Guna2PictureBox3_Click(object sender, EventArgs e)
        {
            

        }

        private void Guna2PictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                guna2TextBox4.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox4.UseSystemPasswordChar = true;
            }
        }
    }
}
