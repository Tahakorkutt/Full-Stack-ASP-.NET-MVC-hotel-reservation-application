﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelMvcProje.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbOtelYeniEntities1 : DbContext
    {
        public DbOtelYeniEntities1()
            : base("name=DbOtelYeniEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblHakkimda> TblHakkimdas { get; set; }
        public virtual DbSet<Tblİletişim> Tblİletişim { get; set; }
        public virtual DbSet<TblMesaj2> TblMesaj2 { get; set; }
        public virtual DbSet<TblMisafir> TblMisafirs { get; set; }
        public virtual DbSet<TblReservation> TblReservations { get; set; }
        public virtual DbSet<TblYeniKayit> TblYeniKayits { get; set; }
        public virtual DbSet<TblMesaj> TblMesajs { get; set; }
        public virtual DbSet<TblOda> TblOdas { get; set; }
    }
}
