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
    
    public partial class Inventeurs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventeurs()
        {
            this.Brevets = new HashSet<Brevets>();
        }
    
        public int Num_inventeur { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adressI { get; set; }
        public System.DateTime date_naiss { get; set; }
        public int age { get; set; }
        public Nullable<int> N_Num_entreprise { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Brevets> Brevets { get; set; }
        public virtual Entreprises Entreprises { get; set; }
    }
}
