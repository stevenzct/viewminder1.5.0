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

namespace viewminder1
{
    public partial class newAdmin : Form
    {
        public newAdmin()
        {
            InitializeComponent();
        }

        private void NewAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Guna2Button4_Click(object sender, EventArgs e)
        {
            //database connection string
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\Admin.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            //inserting into database table from textbox
            SqlCommand cmd = new SqlCommand("INSERT INTO login1(fullName, username, email, password, phoneNumber, id, pin) VALUES (@fullName, @username, @email, @password, @phoneNumber, @id, @pin)", con);
            cmd.Parameters.AddWithValue("@fullName", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@username", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@email", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@password", guna2TextBox4.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", guna2TextBox5.Text);
            cmd.Parameters.AddWithValue("@id", int.Parse(guna2TextBox6.Text));
            cmd.Parameters.AddWithValue("@pin", int.Parse(guna2TextBox7.Text));
            cmd.ExecuteNonQuery();
            con.Close();


            //after submitting textbox will be cleared
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
            guna2TextBox5.Text = "";
            guna2TextBox6.Text = "";
            guna2TextBox7.Text = "";

            //MessageBox.Show("succesfully added to the database");
            this.Close();
            adminAddedSuccess ads = new adminAddedSuccess();
            ads.Show();


        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            superAdmin sa = new superAdmin();
            sa.Show();
        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
