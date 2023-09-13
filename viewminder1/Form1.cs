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




namespace viewminder1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Guna2Panel1_Paint(object sender, PaintEventArgs e)
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
            Sms s = new Sms();
            s.TopLevel = false;
            pnlContent.Controls.Add(s);
            s.BringToFront();
            s.Show();

            
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            // new form show 
            Logout l = new Logout();
            l.TopLevel = false;
            pnlContent.Controls.Add(l);
            l.BringToFront();
            l.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // new form show 
            Notification n = new Notification();
            n.TopLevel = false;
            pnlContent.Controls.Add(n);
            n.BringToFront();
            n.Show();
        }

        private void Guna2ControlBox3_Click_2(object sender, EventArgs e)
        {

        }

        private void BtnWatching_Click(object sender, EventArgs e)
        {
            // new form show 
            Watching w = new Watching();
            w.TopLevel = false;
            pnlContent.Controls.Add(w);
            w.BringToFront();
            w.Show();



           
        }

        private void Guna2Button1_Click_1(object sender, EventArgs e)
        {
            // new form show 
            Archive a = new Archive();
            a.TopLevel = false;
            pnlContent.Controls.Add(a);
            a.BringToFront();
            a.Show();


            
        }

        private void Guna2Button7_Click(object sender, EventArgs e)
        {
            // new form show 
            Profile p = new Profile();
            p.TopLevel = false;
            pnlContent.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void Guna2Button1_Click_2(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }

        private void PnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
