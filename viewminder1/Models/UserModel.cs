using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace viewminder1.Models
{
    class UserModel
    {
        private string username;
        private string password;
        private int id;
        private string fullName;
        private string email;
        private string phoneNumber;
        private int pin;


        //properties - validations

        [DisplayName("Username")]      
        [Required(ErrorMessage = "Username is Required")]
        [StringLength(50,MinimumLength = 3, ErrorMessage ="Username must be between 3 and 50 characters long ")]
        public string Username { get => username; set => username = value; }


        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is Required")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 50 characters long")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string Password { get => password; set => password = value; }

        [DisplayName("Account ID")]
        public int Id { get => id; set => id = value; }


        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 characters long ")]
        public string FullName { get => fullName; set => fullName = value; }

        [DisplayName("Email Adress")]
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get => email; set => email = value; }



        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Mobile Phone Number is Required")]
        [RegularExpression(@"^0[2-9]\d{2}-\d{4}-\d{4}$", ErrorMessage = "Please enter a valid Philippine mobile phone number")]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }


        [DisplayName("Pin")]
        [Required(ErrorMessage = "PIN is Required")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Please enter a valid 4-digit PIN")]
        public int Pin { get => pin; set => pin = value; }
    }
}
