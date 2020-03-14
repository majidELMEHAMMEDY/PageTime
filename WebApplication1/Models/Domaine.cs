using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Domaine
    {
        [Key]
        public int Num_domaine { get; set; }
        [Required]
        public string Nom_domaine { get; set; }
        [Required]
        public string motdepasse { get; set; }

        public string Time { get; set; }
      
    }

}