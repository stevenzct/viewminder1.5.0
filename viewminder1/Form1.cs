using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
                



namespace viewminder1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           // tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
           // tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);



        }


            public class User
            {
                //validations * need to add follow up code to functions correctly
                // Define properties with validations
                [DisplayName("Username")]
                [Required(ErrorMessage = "Username is Required")]
                [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters long.")]
                public string Username { get; set; }

                [DisplayName("Password")]
                [Required(ErrorMessage = "Password is Required")]
                [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 50 characters long.")]
                [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
                public string Password { get; set; }

                [DisplayName("Account ID")]
                public int Id { get; set; }

                [DisplayName("Full Name")]
                [Required(ErrorMessage = "Full Name is Required")]
                [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 characters long.")]
                public string FullName { get; set; }

                [DisplayName("Email Address")]
                [Required(ErrorMessage = "Email is Required")]
                [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
                public string Email { get; set; }

               // [DisplayName("Phone Number")]
              //  [Required(ErrorMessage = "Mobile Phone Number is Required")]
              //  [RegularExpression(@"^09\d{9}$", ErrorMessage = "Please enter a valid 11-digit Philippine mobile phone number.")]
              //  public string PhoneNumber { get; set; }

                [DisplayName("PIN")]
                [Required(ErrorMessage = "PIN is Required")]
                [RegularExpression(@"^\d{4}$", ErrorMessage = "Please enter a valid 4-digit PIN.")]
                public int Pin { get; set; }
            }


        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
          //  e.DrawBackground();
           // e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, tabControl1.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
        }


        private void Button_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            string hexColor = "#0A0C29";

            Color myColor = System.Drawing.ColorTranslator.FromHtml(hexColor);

            btnPanel.BackColor = myColor;
        }

        private void Guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void Guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void Guna2ControlBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void Guna2ControlBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
           


            string hexColor = "#2C81FF";

            Color myColor = System.Drawing.ColorTranslator.FromHtml(hexColor);

           

            

        }

        private void Guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }


        private List<Guna2Button> allButtons = new List<Guna2Button>();

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //Sms s = new Sms();
            // s.TopLevel = false;
            // pnlContent.Controls.Add(s);
            // s.BringToFront();
            // s.Show();

            tabControl1.SelectedTab = tabPage2;



        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // new form show 
            // Notification n = new Notification();
            // n.TopLevel = false;
            // pnlContent.Controls.Add(n);
            // n.BringToFront();
            //  n.Show();

            tabControl1.SelectedTab = tabPage4;
        }

        private void Guna2ControlBox3_Click_2(object sender, EventArgs e)
        {

        }

        private void BtnWatching_Click(object sender, EventArgs e)
        {
            // new form show 
            // Watching w = new Watching();
            // w.TopLevel = false;
            // pnlContent.Controls.Add(w);
            // w.BringToFront();
            // w.Show();


            tabControl1.SelectedTab = tabPage1;



        }

        private void Guna2Button1_Click_1(object sender, EventArgs e)
        {
            // new form show 
            //  Archive a = new Archive();
            // a.TopLevel = false;
            // pnlContent.Controls.Add(a);
            //  a.BringToFront();
            //  a.Show();

            tabControl1.SelectedTab = tabPage3;



        }

        private void Guna2Button7_Click(object sender, EventArgs e)
        {
            // new form show 
            //  Profile p = new Profile();
            //  p.TopLevel = false;
            //  pnlContent.Controls.Add(p);
            //  p.BringToFront();
            //  p.Show();

            tabControl1.SelectedTab = tabPage5;
        }

        private void Guna2Button1_Click_2(object sender, EventArgs e)
        {
          
        }

        private void PnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Guna2PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void Guna2PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void Guna2PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Guna2PictureBox14_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage7;
        }

        private void Guna2PictureBox15_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage6;
        }

        private void Guna2PictureBox13_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage8;
        }

        private void Guna2PictureBox12_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage9;
        }

        private void TabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Guna2PictureBox6_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage6;
        }

        private void Guna2PictureBox11_Click_1(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage6;
        }

        private void Guna2PictureBox19_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage6;
        }

        private void Guna2PictureBox5_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage7;
        }

        private void Guna2PictureBox10_Click_1(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage7;
        }

        private void Guna2PictureBox18_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage7;
        }

        private void Guna2PictureBox3_Click_1(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage8;
        }

        private void Guna2PictureBox9_Click_1(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage8;
        }

        private void Guna2PictureBox17_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage8;
        }

        private void Guna2PictureBox2_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage9;
        }

        private void Guna2PictureBox8_Click_1(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage9;
        }

        private void Guna2PictureBox16_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage9;
        }

        private void Guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
          
        }

        private void Guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {
            viewVideo vd = new viewVideo();
            vd.Show();
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click_3(object sender, EventArgs e)
        {

        }

        private void Guna2Separator7_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Separator6_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Separator3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button4_Click(object sender, EventArgs e)
        {
            //edit btn profile
            // Select tabPage10 in tabControl1
            // tabControl1.SelectTab("tabPage10");


            // Switch to TabPage10 for editing
            tabControl1.SelectTab("tabPage10"); // Use the actual name of your TabPage

            // Populate the Guna2TextBox controls on TabPage10 with the current user data
            guna2TextBox1.Text = label39.Text; // Full Name
            guna2TextBox2.Text = label40.Text; // Username
            guna2TextBox3.Text = label42.Text; // Email
            guna2TextBox4.Text = label50.Text; // Password
          
            guna2TextBox6.Text = label46.Text; // ID
            guna2TextBox7.Text = label48.Text; // Pin

        }

        private void TabPage7_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2HtmlLabel23_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2HtmlLabel24_Click(object sender, EventArgs e)
        {

        }

        private void Guna2PictureBox7_Click(object sender, EventArgs e)
        {
            // Check the current visibility state of FlowLayoutPanel2
            if (guna2Panel25.Visible)
            {
                // If it's visible, hide it
                guna2Panel25.Visible = false;
            }
            else
            {
                // If it's not visible, show it
                guna2Panel25.Visible = true;
            }
        }

        private void Guna2Button17_Click(object sender, EventArgs e)
        {
            btnSms.PerformClick();
           
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            guna2Panel25.Visible = false;
        }

        private void Guna2Button18_Click(object sender, EventArgs e)
        {

            guna2Button7.PerformClick();
            guna2Panel25.Visible = false;
        }

        private void Guna2Button17_Click_1(object sender, EventArgs e)
        {

        }

        private void Guna2Button20_Click(object sender, EventArgs e)
        {
            btnSms.PerformClick();
            guna2Panel25.Visible = false;
        }

        private void Guna2Button19_Click(object sender, EventArgs e)
        {

            btnWatching.PerformClick();
            guna2Panel25.Visible = false;
        }

        private void Guna2Button21_Click(object sender, EventArgs e)
        {
  
            btnArchive.PerformClick();
            guna2Panel25.Visible = false;
        }

        private void Guna2Button22_Click(object sender, EventArgs e)
        {

            guna2Button8.PerformClick();
            guna2Panel25.Visible = false;
        }

        private void Guna2Button15_Click(object sender, EventArgs e)
        {
            //cancel edit profile btn
            // Select tabPage5 in tabControl1
            tabControl1.SelectTab("tabPage5");
        }

        private void Label39_Click(object sender, EventArgs e)
        {
          
        }


        //labels account profile
        public void SetLabel39Text(string text)
        {
            label39.Text = text;
        }

        public void SetLabel40Text(string text)
        {
            label40.Text = text;
        }

        public void SetLabel42Text(string text)
        {
            label42.Text = text;
        }

        public void SetLabel44Text(string text)
        {
         
        }

        public void SetLabel46Text(string text)
        {
            label46.Text = text;
        }

        public void SetLabel48Text(string text)
        {
            label48.Text = text;
        }

        public void SetLabel50Text(string text)
        {
            label50.Text = text;
        }


        // confirm button in editing profile
        private void Guna2Button16_Click(object sender, EventArgs e)
        {
            // Create an instance of the User class
            User user = new User();

            // Populate the user object with user input
            user.FullName = guna2TextBox1.Text;
            user.Username = guna2TextBox2.Text;
            user.Email = guna2TextBox3.Text;
            user.Password = guna2TextBox4.Text;
            user.Id = int.Parse(guna2TextBox6.Text); // Convert to int
            user.Pin = int.Parse(guna2TextBox7.Text); // Convert to int

            // Validate the user object
            List<ValidationResult> validationResults = new List<ValidationResult>();
            if (Validator.TryValidateObject(user, new ValidationContext(user), validationResults, true))
            {
                // Input is valid, proceed with saving the data to the database
                // Your database update code here
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\Admin.mdf;Integrated Security=True;Connect Timeout=30");
                string updateQuery = "UPDATE login1 SET fullName = @fullName, username = @username, email = @email, password = @password, pin = @pin WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@fullName", user.FullName);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@pin", user.Pin);
                    cmd.Parameters.AddWithValue("@id", user.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                // Update the labels on TabPage5 to reflect the changes
                label39.Text = user.FullName;
                label40.Text = user.Username;
                label42.Text = user.Email;
                label50.Text = user.Password;
                label46.Text = user.Id.ToString(); // Convert to string
                label48.Text = user.Pin.ToString(); // Convert to string

                // Show the panel
                guna2Panel28.Visible = true;

                // Start the timer
                visibilityTimer.Start();
            }
            else
            {
                // Handle validation errors
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                }
            }
        }
        private void Label54_Click(object sender, EventArgs e)
        {

        }

        private void VisibilityTimer_Tick(object sender, EventArgs e)
        {
            // Hide guna2Panel28 after the timer interval (5 seconds)
            guna2Panel28.Visible = false;

            // Stop the timer to prevent it from firing again
            visibilityTimer.Stop();

            // Navigate to TabPage5 in TabControl1
            tabControl1.SelectTab("tabPage5");
        }

        private void MonthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar2.Size = new Size(800, 800);
        }

        private void Guna2Button17_Click_2(object sender, EventArgs e)
        {
            // new form show 
            // Logout l = new Logout();
            //l.TopLevel = false;
            //pnlContent.Controls.Add(l);
            // l.BringToFront();
            // l.Show();
            this.Close();
            confirmLogout cl = new confirmLogout();
            cl.Show();
        }

        private void Guna2HtmlLabel18_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button5_Click_1(object sender, EventArgs e)
        {
           // Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
           // int customRightBorderRadius = 20;
        }

        private void Guna2Button27_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button6_Click(object sender, EventArgs e)
        {
            // Check the current visibility state of FlowLayoutPanel2
            if (guna2Panel11.Visible)
            {
                // If it's visible, hide it
                guna2Panel11.Visible = false;
            }
            else
            {
                // If it's not visible, show it
                guna2Panel11.Visible = true;
            }
        }

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {
            guna2Panel11.Visible = false;
        }

        private void Guna2HtmlLabel33_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button29_Click(object sender, EventArgs e)
        {
            guna2Button17.PerformClick();
            guna2Panel25.Visible = false;
        }
    }
}
