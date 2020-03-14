using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Inventeur
    {
        [Key]
        [Required]
        public int Num_inventeur { get; set; }
        [Required]
        public string nom { get; set; }
        [Required]
        public string prenom { get; set; }
        [Required]
        public string adressI  { get; set; }
        [Required]
        public DateTime date_naiss { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public virtual Entreprise N { get; set; }
    }
}