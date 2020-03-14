using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Brevet
    {
        [Key]
        public int num_brevet { get; set; }
        public string description { get; set; }
        public DateTime date_depot { get; set; }
        public DateTime date_validation { get; set; }
        public virtual Inventeur N { get; set; }
        public virtual Invention Ne { get; set; }

    }
}