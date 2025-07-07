using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using viewminder1.Models;
using viewminder1.Views;

namespace viewminder1.Presenters
{ /*
    public class UserPresenter
    {
        //fields
        private IUserView view;
        private IUserRepository repository;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private IEnumerable<UserModel> tabPage2;
        private IEnumerable<UserModel> tabPage1;


        //constructor
        public UserPresenter(IUserView view, IUserRepository repository)
        {
            this.usersBindingSource = new System.Windows.Forms.BindingSource();
            this.view = view;
            this.repository = repository;

            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchUser;
            this.view.EditEvent += LoadSelectedUserToEdit;
            this.view.DeleteEvent += DeleteSelectedUser;
            this.view.SaveEvent += SaveUser;
            this.view.CancelEvent += CancelAction;
            // Set users binding source
            this.view.SetTabPage1BindingSource(usersBindingSource);
            // load user list view
            LoadAllTabPage1();
            // show view
            this.view.Show();
        }

        private void LoadAllTabPage1()
        {
            tabPage1 = repository.GetAll();
            usersBindingSource.DataSource = tabPage1; // Set data source. 
        }

        private void SearchUser(object sender, EventArgs e)
        {
          bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                tabPage1 = repository.ByValue;
            else tabPage1 = repository.GetAll();
            usersBindingSource.DataSource = tabPage1;
          
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveUser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedUser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedUserToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       
    } */

}
