//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChuongTrinhQLKS
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.BOOKROOMs = new HashSet<BOOKROOM>();
        }
    
        public int ID { get; set; }
        public string IDCard { get; set; }
        public int IDCustomerType { get; set; }
        public string Name { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOKROOM> BOOKROOMs { get; set; }
        public virtual CUSTOMERTYPE CUSTOMERTYPE { get; set; }
    }
}
