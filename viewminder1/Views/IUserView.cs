using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewminder1.Views
{
    public interface IUserView
    {
        // properties - fields
        string username { get; set; }
        string password { get; set; }
        int id { get; set; }
        string fullName { get; set; }
        string email { get; set; }
        string phoneNumber { get; set; }
        int pin { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }

        string Message { get; set; }



        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetUserListBindingSource(BindingSource userList);
        void Show();//optional
        void SetTabPage1BindingSource(BindingSource usersBindingSource);
    }
}
