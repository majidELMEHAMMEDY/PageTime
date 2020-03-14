using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DbContextDatabase:DbContext
    {
        public virtual DbSet<Brevet> brevets { get; set; }
        public virtual DbSet<Inventeur> inventeurs { get; set; }
        public virtual DbSet<Entreprise> entreprises { get; set; }
        public virtual DbSet<Invention> inventions { get; set; }
        public virtual DbSet<Domaine> domaines { get; set; }
    }
}