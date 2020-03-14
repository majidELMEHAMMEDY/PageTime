using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Invention
    {
        [Key]
        public int Num_invention { get; set; }
        public string description { get; set; }
        public string resume { get; set; }
        public Domaine N { get; set; }
    }
}