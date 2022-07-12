using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ENwithMVC.Models
{
    public class studentContext:DbContext
    {
        public DbSet<student> students { get; set; }
    }
}