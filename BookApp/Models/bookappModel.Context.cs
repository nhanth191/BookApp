﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_account> tb_account { get; set; }
        public virtual DbSet<tb_bai> tb_bai { get; set; }
        public virtual DbSet<tb_baimau> tb_baimau { get; set; }
        public virtual DbSet<tb_cauhoi> tb_cauhoi { get; set; }
        public virtual DbSet<tb_chuyende> tb_chuyende { get; set; }
        public virtual DbSet<tb_comment> tb_comment { get; set; }
        public virtual DbSet<tb_dapan> tb_dapan { get; set; }
        public virtual DbSet<tb_dapan_danhdau> tb_dapan_danhdau { get; set; }
        public virtual DbSet<tb_dapan_dientext> tb_dapan_dientext { get; set; }
        public virtual DbSet<tb_dapan_singlechoice> tb_dapan_singlechoice { get; set; }
        public virtual DbSet<tb_templatenoidung> tb_templatenoidung { get; set; }
        public virtual DbSet<tb_templatenoidung_bainghe> tb_templatenoidung_bainghe { get; set; }
        public virtual DbSet<tb_templatenoidung_hinhanh> tb_templatenoidung_hinhanh { get; set; }
        public virtual DbSet<tb_templatenoidung_text> tb_templatenoidung_text { get; set; }
        public virtual DbSet<tb_templatenoidunghinhanh_format> tb_templatenoidunghinhanh_format { get; set; }
        public virtual DbSet<tb_templatenoidungtext_format> tb_templatenoidungtext_format { get; set; }
        public virtual DbSet<tb_thuvien> tb_thuvien { get; set; }
        public virtual DbSet<tb_user> tb_user { get; set; }
    }
}
