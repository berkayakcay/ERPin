﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERPin.Functions
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERPinEntities : DbContext
    {
        public ERPinEntities()
            : base("name=ERPinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryGroup> InventoryGroup { get; set; }
        public virtual DbSet<CurrAccGroup> CurrAccGroup { get; set; }
        public virtual DbSet<CurrAcc> CurrAcc { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}