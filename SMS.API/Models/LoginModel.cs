using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS.API.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }
}