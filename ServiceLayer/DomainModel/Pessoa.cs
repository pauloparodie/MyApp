//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceLayer.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoa()
        {
            int a =0;
            this.animals = new HashSet<animal>();
        }
    
        public int cod { get; set; }
        public string name { get; set; }
        public string pais { get; set; }
        public Nullable<int> age { get; set; }
        public string photo_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<animal> animals { get; set; }
    }
}//erter
