﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtomasyonu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Kütüphane_OtomasyonuEntities : DbContext
    {
        public Kütüphane_OtomasyonuEntities()
            : base("name=Kütüphane_OtomasyonuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kullanıcılar> Kullanıcılar { get; set; }
        public virtual DbSet<Okuyucular> Okuyucular { get; set; }
    }
}
