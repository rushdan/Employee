using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.ApiClient.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Username ID is required")]
        [Display(Name ="Username ID")]
        public int UsernameID { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Phone number is invalid")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Skill set")]
        [Required(ErrorMessage = "Skill set is required")]
        public string Skillsets { get; set; }

        [Display(Name = "Hobby")]
        [Required(ErrorMessage = "Hobby is required")]
        public string Hobby { get; set; }

       
    }
}
