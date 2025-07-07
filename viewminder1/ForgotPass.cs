using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace viewminder1
{
    public partial class ForgotPass : Form
    {
        string randomCode;
        public static string to;

        public ForgotPass()
        {
            InitializeComponent();
           
        }

        private void Guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }

       
        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            //button confirm email , then code will be sent and validate if its correct
            //or not then if correct msgbox will show then click ok  redirected to
            //CONFIRM /VERIFY CODE FORM THEN validating to new password form .



            string from, pass, messageBody;



            // Validate email input
            string email = txtEmail.Text.Trim();
            string username = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                this.Hide();
                incorrectEmail ic = new incorrectEmail();
                ic.Show();
                return;
            }

            // Check if the email exists in the database
            bool usernameExistsInDatabase = CheckUsernameInDatabase(username);


            if (usernameExistsInDatabase)
            {
                // Email exists in the database, proceed to send the reset code
                Random rand = new Random();
                string randomCode = (rand.Next(999999)).ToString();

                MailMessage message = new MailMessage();
                string to = email;
                from = "viewminder123@gmail.com";
                pass = "npbwfeycejjzktkn";

                messageBody = " Your password reset code is " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Password resetting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    //MessageBox.Show("Code sent successfully");

                    this.Hide(); // Hide the current ForgotPass form
                    codeSent cs = new codeSent(this); // Pass the reference to the current ForgotPass form
                    cs.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // Email doesn't exist in the database, show the incorrectEmail form
                this.Hide();
                incorrectEmail ic = new incorrectEmail();
                ic.Show();
            }
        }

        // Function to check if the email exists in the database
        private bool CheckUsernameInDatabase(string username)
        {
            // Replace this with your actual database query logic to check if the email exists in your SQL database
            // Return true if the email exists, false otherwise
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\Admin.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Login1 WHERE username= @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }


        }

        private void Guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void Guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Continu_Click(object sender, EventArgs e)
        {
            string enteredCode = txtVerCode.Text.Trim();


            if (int.TryParse(enteredCode, out int enteredCodeInt) && enteredCodeInt >= 100000 && enteredCodeInt <= 999999)

            {
                to = txtEmail.Text;
                NewPassword rp = new NewPassword();
                this.Hide();
                rp.Show();
            }


            else
            {
                // MessageBox.Show("wrong code");

                // wrongCode wc = new wrongCode();
                //this.Hide();
                // wc.Show();

                ShowWrongCodeForm();
            }
        }

        private void ShowWrongCodeForm()
        {
            // Create an instance of the wrongCode form and display it.
            wrongCode wc = new wrongCode();
            wc.ShowDialog(); // Use ShowDialog to make it a modal dialog.
        }


        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
           
        }
    }
}
