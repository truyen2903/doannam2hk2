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
    
    public partial class Access
    {
        public int IDStaffType { get; set; }
        public int IDJob { get; set; }
        public string describe { get; set; }
    
        public virtual Job Job { get; set; }
        public virtual STAFFTYPE STAFFTYPE { get; set; }
    }
}
