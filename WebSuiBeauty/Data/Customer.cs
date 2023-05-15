using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebSuiBeauty.Data.Abstract;

namespace WebSuiBeauty.Data
{
    public class Customer : Auditable
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string First_Name { get; set; }
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        public string Address { get; set; }
        [Display(Name = "Avatar")]
        public string Avatar { get; set; }
    }
}