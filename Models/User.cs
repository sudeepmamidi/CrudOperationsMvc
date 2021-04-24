using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrudOperationsMvc.Models
{
    public class User
    {

        [Required(ErrorMessage = "FirstName Required")]
        [Display(Name="First Name")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string first_name { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "LastName Required")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string last_name { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "gender is required")]
        public string gender { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile number is required")]
        public int mobile { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        public string email { get; set; }

        [Display(Name = "UserId")]
        [Key]
        [Required(ErrorMessage = "UserID Required")]
        public string userID { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password Requrired")]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "Invalid password format")]
        public string pswd { get; set; }

        [Display(Name = "User Category")]
        [Required(ErrorMessage = "Select User Category")]
        public string category { get; set; }
    }
}