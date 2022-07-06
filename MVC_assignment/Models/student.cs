using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_assignment.Models
{
    public class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
           
        public int Age { get; set; }

        public string Address { get; set; }

        public Boolean isPass { get; set; }  
    }
}