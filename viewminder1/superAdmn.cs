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
using System.ComponentModel.DataAnnotations;
using viewminder1.Models;

namespace viewminder1
{
    public partial class superAdmn : Form
    {
        private object errorProviderUsername;
        private DataTable dataTable; // Declare the DataTable as a class-level field
        public superAdmn()
        {
            InitializeComponent();

            //database connection string
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\Admin.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            // Show the database in the DataGridView
            SqlCommand cmd = new SqlCommand("SELECT * FROM login1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dataTable = new DataTable(); // Initialize the dataTable field
            da.Fill(dataTable);
            guna2DataGridView1.DataSource = dataTable;

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

        

            [DisplayName("PIN")]
            [Required(ErrorMessage = "PIN is Required")]
            [RegularExpression(@"^\d{4}$", ErrorMessage = "Please enter a valid 4-digit PIN.")]
            public int Pin { get; set; }
        }


        private void BtnWatching_Click(object sender, EventArgs e)
        {
            //manage accounts
            tabControl1.SelectedTab = tabPage1;
        }

        private void BtnSms_Click(object sender, EventArgs e)
        {
            //messages
            tabControl1.SelectedTab = tabPage2;
        }

        private void BtnArchive_Click(object sender, EventArgs e)
        {
            //archive
            tabControl1.SelectedTab = tabPage3;
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            //notification
            tabControl1.SelectedTab = tabPage4;
        }

        private void Guna2Button7_Click(object sender, EventArgs e)
        {
            //acount profile
            tabControl1.SelectedTab = tabPage5;
        }

        private void Guna2Button8_Click(object sender, EventArgs e)
        {
            //login history
            tabControl1.SelectedTab = tabPage6;
        }

        private void SuperAdmn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adminDataSet.login1' table. You can move, or remove it, as needed.
            this.login1TableAdapter.Fill(this.adminDataSet.login1);

        }

        private void Guna2Button24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void Guna2Button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }



        //confirm btn for adding new account
        private void Guna2Button19_Click(object sender, EventArgs e)
        {
             User user = new User
            {
                FullName = guna2TextBox15.Text,
                Username = guna2TextBox14.Text,
                Email = guna2TextBox13.Text,
                Password = guna2TextBox12.Text
            };

            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(user.FullName) || string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\Admin.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Generate a unique ID
                int generatedID = GetNextAvailableID(con);
                user.Id = generatedID;

                if (int.TryParse(guna2TextBox9.Text, out int pin))
                {
                    user.Pin = pin;
                }
                else
                {
                    MessageBox.Show("PIN must be a valid integer.");
                    return;
                }

                var validationContext = new ValidationContext(user, null, null);
                var validationResults = new List<ValidationResult>();

                if (Validator.TryValidateObject(user, validationContext, validationResults, true))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO login1(fullName, username, email, password, id, pin) VALUES (@fullName, @username, @email, @password, @id, @pin)", con))
                        {
                            cmd.Parameters.AddWithValue("@fullName", user.FullName);
                            cmd.Parameters.AddWithValue("@username", user.Username);
                            cmd.Parameters.AddWithValue("@email", user.Email);
                            cmd.Parameters.AddWithValue("@password", user.Password);
                            cmd.Parameters.AddWithValue("@id", user.Id);
                            cmd.Parameters.AddWithValue("@pin", user.Pin);

                            cmd.ExecuteNonQuery();
                        }

                        // MessageBox.Show "successfully added to the database";
                        this.Close();
                        adminAddedSuccess ads = new adminAddedSuccess();
                        ads.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    string validationErrors = string.Join("\n", validationResults.Select(r => r.ErrorMessage));
                    MessageBox.Show("Validation Errors:\n" + validationErrors);
                }
            }
        }
        private int GetNextAvailableID(SqlConnection connection)
        {
            string query = "SELECT MAX(id) FROM login1";
            SqlCommand cmd = new SqlCommand(query, connection);

            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                int maxID = Convert.ToInt32(result);
                return maxID + 1;
            }
            else
            {
                return 632000;
            }
        }

        private void Guna2Button25_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                    // Access the data from the selected row using column indexes
                    string username = selectedRow.Cells[0].Value.ToString(); // First column
                    string password = selectedRow.Cells[1].Value.ToString(); // Second column
                    int id = int.Parse(selectedRow.Cells[2].Value.ToString()); // Third column
                    string fullName = selectedRow.Cells[3].Value.ToString(); // Fourth column
                    string email = selectedRow.Cells[4].Value.ToString(); // Fifth column
                    int pin = int.Parse(selectedRow.Cells[5].Value.ToString()); // Six column

                    // Populate the text boxes in tabPage8 with the data
                    guna2TextBox22.Text = fullName;
                    guna2TextBox21.Text = username;
                    guna2TextBox20.Text = email;
                    guna2TextBox19.Text = password;
                    guna2TextBox17.Text = id.ToString();
                    guna2TextBox16.Text = pin.ToString();

                    // Redirect to tabPage8
                    tabControl1.SelectedTab = tabPage8;
                }
                else
                {
                    MessageBox.Show("Please select a row to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel24_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel23_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox14_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void TabPage7_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }


        // save button for editing admin profile details
        private void Guna2Button21_Click(object sender, EventArgs e)
        {
            // Create a User instance
            User user = new User
            {
                FullName = guna2TextBox22.Text,
                Username = guna2TextBox21.Text,
                Email = guna2TextBox20.Text,
                Password = guna2TextBox19.Text,
            };

            if (int.TryParse(guna2TextBox17.Text, out int id) && int.TryParse(guna2TextBox16.Text, out int pin))
            {
                user.Id = id;
                user.Pin = pin;

                // Perform validation
                var validationContext = new ValidationContext(user, null, null);
                var validationResults = new List<ValidationResult>();

                if (Validator.TryValidateObject(user, validationContext, validationResults, true))
                {
                    try
                    {
                        // Database connection string
                        using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\Admin.mdf;Integrated Security=True;Connect Timeout=30"))
                        {
                            con.Open();

                            // Update data in the database
                            using (SqlCommand cmd = new SqlCommand("UPDATE login1 SET fullName = @fullName, username = @username, email = @email, password = @password, pin = @pin WHERE id = @id", con))
                            {
                                cmd.Parameters.AddWithValue("@fullName", guna2TextBox22.Text);
                                cmd.Parameters.AddWithValue("@username", guna2TextBox21.Text);
                                cmd.Parameters.AddWithValue("@email", guna2TextBox20.Text);
                                cmd.Parameters.AddWithValue("@password", guna2TextBox19.Text);
                                cmd.Parameters.AddWithValue("@pin", int.Parse(guna2TextBox16.Text));
                                cmd.Parameters.AddWithValue("@id", int.Parse(guna2TextBox17.Text));

                                cmd.ExecuteNonQuery();
                            }

                            // MessageBox.Show "Successfully updated the record in the database";
                            this.Close();
                            adminEditedSuccess aes = new adminEditedSuccess();
                            aes.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    // Validation failed; show validation error messages
                    string validationErrors = string.Join("\n", validationResults.Select(r => r.ErrorMessage));
                    MessageBox.Show("Validation Errors:\n" + validationErrors);
                }
            }
            else
            {
                MessageBox.Show("ID and PIN must be valid integers.");
            }
        }

        private void Guna2Button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void Guna2Button26_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                // Extract the ID or any unique identifier from the selected row (assuming an "ID" column)
                int id = int.Parse(selectedRow.Cells[2].Value.ToString()); // Third column

                // Prompt the user to confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Perform the deletion operation in the database
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\Admin.mdf;Integrated Security=True;Connect Timeout=30"))
                        {
                            con.Open();

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM login1 WHERE id = @id", con))
                            {
                                cmd.Parameters.AddWithValue("@ID", id);
                                cmd.ExecuteNonQuery();

                                // Remove the row from the DataGridView
                                guna2DataGridView1.Rows.Remove(selectedRow);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            confirmLogoutSA clsa = new confirmLogoutSA();
            clsa.Show();
        }

        private void Guna2TextBox8_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox8.Text;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Create a DataView to filter the DataTable
                DataView dv = new DataView(dataTable); // 'dataTable' is your source DataTable

                // Build a filter string for string columns
                StringBuilder filterExpression = new StringBuilder();
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (column.DataType == typeof(string))
                    {
                        filterExpression.Append($"CONVERT([{column.ColumnName}], 'System.String') LIKE '%{searchText}%' OR ");
                    }
                }

                // Remove the trailing "OR " from the filter expression
                if (filterExpression.Length >= 3)
                {
                    filterExpression.Remove(filterExpression.Length - 3, 3);
                }

                dv.RowFilter = filterExpression.ToString();

                // Bind the filtered DataView to the DataGridView
                guna2DataGridView1.DataSource = dv.ToTable();
            }
            else
            {
                // If the search text is empty, reset the DataGridView to the original data
                guna2DataGridView1.DataSource = dataTable;
            }
        }


        private void Guna2Button16_Click(object sender, EventArgs e)
        {

        }

        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
