using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class student
    {
        [Required (ErrorMessage ="please enter your roll")]
        public int rollno { get; set; }
        [Required(ErrorMessage = "please enter your name")]
        public string name { get; set; }
        [Required(ErrorMessage = "please enter your password")]
        [DataType(DataType.Password)]   
        public string password { get; set; }
        [Compare("password" ,ErrorMessage = "Password and Re-Password not matching")]
        [DataType (DataType.Password)]  
        public string repassword { get; set;}
        [Required(ErrorMessage = "please enter your age")]
        public int age { get; set; }
        [Required(ErrorMessage = "please enter your address")]
        public string address { get; set; }
        [Required(ErrorMessage = "please enter your phone")]
        [MaxLength(10)]
        public long phone { get; set; }

    }
}