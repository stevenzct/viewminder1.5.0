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

namespace viewminder1
{
    public partial class verifyCode : Form
    {
        string randomCode;
        public static string to;
        public verifyCode()
        {
            InitializeComponent();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
           // string form, pass, messageBody;
           // Random rand = new Random();
           // randomCode = (rand.Next(999999)).ToString();
           // MailMessage message = new MailMessage();
           // to = (txtEmail.Text)ToString();
           // from
        }
    }
}
