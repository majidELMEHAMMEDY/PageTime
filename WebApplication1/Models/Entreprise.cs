using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Entreprise
    {
        [Key]
        public int Num_entreprise { get; set; }
        public string Nom_entrepris { get; set; }
        public string activite { get; set; }
        public int CA { get; set; }
        public string adresseE { get; set; }
    }
}