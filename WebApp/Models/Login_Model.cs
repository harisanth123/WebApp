using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Login_Model
    {
        [Required(ErrorMessage = "UserName is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }

    public class User_DetailsModel
    {
        public string name { get; set; }
        public DateTime dob { get; set; }
        public string Job { get; set; }
        public string place { get; set; }
    }

}