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
    
    public partial class tb_dapan_danhdau
    {
        public int id_dapan { get; set; }
        public Nullable<int> vitri_dung { get; set; }
    
        public virtual tb_dapan tb_dapan { get; set; }
    }
}
