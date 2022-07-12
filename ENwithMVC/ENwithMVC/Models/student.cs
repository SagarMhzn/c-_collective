using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ENwithMVC.Models
{
    public class student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "gender is required")]
        public string gender { get; set; }
        [Required(ErrorMessage = "faculty is required")]
        public string faculty { get; set; }
        [Required(ErrorMessage = "grade is required")]
        public string Grade { get; set; }
        
    }
}