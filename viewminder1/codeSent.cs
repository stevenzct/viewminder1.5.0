using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewminder1
{
    public partial class codeSent : Form
    {
        public codeSent(ForgotPass forgotPass)
        {
            InitializeComponent();
        }

        private void CodeSent_Load(object sender, EventArgs e)
        {

        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPass fg = new ForgotPass();
            fg.Show();
        }
    }
}
