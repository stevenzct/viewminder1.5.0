using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace viewminder1
{
    public partial class superAdmin : Form
    {
        public superAdmin()
        {
            InitializeComponent();

            //database connection string
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\Admin.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            //showing database to the datagridview 
            SqlCommand cmd = new SqlCommand("SELECT * FROM login1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void Guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void BtnWatching_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            confirmLogoutSA clsa = new confirmLogoutSA();
            clsa.Show();
        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSms_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            newAdmin na = new newAdmin();
            na.Show();
        }

        private void BtnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
