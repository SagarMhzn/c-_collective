using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cookies.Models
{
    public class form
    {
        [Required(ErrorMessage ="username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}











