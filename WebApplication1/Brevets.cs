//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Brevets
    {
        public int num_brevet { get; set; }
        public string description { get; set; }
        public System.DateTime date_depot { get; set; }
        public System.DateTime date_validation { get; set; }
        public Nullable<int> N_Num_inventeur { get; set; }
        public Nullable<int> Ne_Num_invention { get; set; }
    
        public virtual Inventeurs Inventeurs { get; set; }
        public virtual Inventions Inventions { get; set; }
    }
}