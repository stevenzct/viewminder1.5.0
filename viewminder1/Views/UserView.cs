using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewminder1.Views
{/*
    public partial class UserView : Form, IUserView
    {
        //fields
      
        private bool isSuccessful;
        private bool isEdit;
        private string message;

        //constructor
        public UserView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            guna2TextBox1.KeyDown += (s, e) =>
              {
                  if (e.KeyCode == Keys.Enter)
                      SearchEvent?.Invoke(this, EventArgs.Empty);

  
              };
            //Others
        }


        //properties
        public string username
        {
            get { return guna2TextBox2.Text; }
            set { guna2TextBox2.Text = value;}
        }

        public string password
        {
            get { return guna2TextBox4.Text; }
            set { guna2TextBox4.Text = value; }
        }

        public string id
        {
            get { return guna2TextBox6.Text; }
            set { guna2TextBox6.Text = value; }
        }

        public string fullName
        {
            get { return guna2TextBox8.Text;  }
            set { guna2TextBox8.Text = value; }
        }

        public string email
        {
            get { return guna2TextBox3.Text; }
            set { guna2TextBox3.Text = value; }
        }

        public string phoneNumber
        {
            get { return guna2TextBox5.Text; }
            set { guna2TextBox5.Text = value; }
        }

        public string pin
        {
            get { return guna2TextBox7.Text; }
            set { guna2TextBox7.Text = value; }
        }

        public string SearchValue
        {
            get { return guna2TextBox1.Text; }
            set { guna2TextBox1.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }

          
        }



        //events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;


        //methods
        public void SetUserListBindingSource(BindingSource userList)
        {
            dataGridView1.DataSource = userList;
        }
    }
    */
}
