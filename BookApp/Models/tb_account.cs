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
    
    public partial class tb_account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_account()
        {
            this.tb_baimau = new HashSet<tb_baimau>();
            this.tb_comment = new HashSet<tb_comment>();
        }
    
        public int id_account { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int id_user { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public System.DateTime ngay_tao { get; set; }
    
        public virtual tb_user tb_user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_baimau> tb_baimau { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_comment> tb_comment { get; set; }
    }
}
