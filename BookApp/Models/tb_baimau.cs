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
    
    public partial class tb_baimau
    {
        public int id_baimau { get; set; }
        public int id_bai { get; set; }
        public int id_account { get; set; }
        public string ten_baimau { get; set; }
    
        public virtual tb_account tb_account { get; set; }
        public virtual tb_bai tb_bai { get; set; }
    }
}
