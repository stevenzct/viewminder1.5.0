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
    public partial class NewPassword : Form
    {
        string username = ForgotPass.to;
    

        public NewPassword()
        {
            InitializeComponent();
        }

        private void Guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetPassVer.Text )
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\Admin.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[login1] SET [password] = '" + txtResetPassVer.Text + "' WHERE username= '" + username + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //MessageBox.Show("reset success");
                this.Hide();
                resetSuccess rs = new resetSuccess();
                rs.Show();


            }
            else
            {
                //MessageBox.Show("password do not match , please enter same password");
                this.Hide();
                passwordNotMatch pwn = new passwordNotMatch();
                pwn.Show();
            }
        }

        private void Guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPassword_Load(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtResetPass.UseSystemPasswordChar = false;
                txtResetPassVer.UseSystemPasswordChar = false;
            }
            else
            {
                txtResetPass.UseSystemPasswordChar = true;
                txtResetPassVer.UseSystemPasswordChar = true;
            }
        }
    }
}
