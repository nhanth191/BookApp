//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_chuyende
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_chuyende()
        {
            this.tb_bai = new HashSet<tb_bai>();
        }
    
        public int id_chuyende { get; set; }
        public int id_thuvien { get; set; }
        public string ten_chuyende { get; set; }
        public System.DateTime ngay_tao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_bai> tb_bai { get; set; }
        public virtual tb_thuvien tb_thuvien { get; set; }
    }
}
