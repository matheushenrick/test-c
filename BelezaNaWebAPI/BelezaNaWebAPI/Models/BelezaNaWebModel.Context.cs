﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BelezaNaWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BelezaNaWebEntities : DbContext
    {
        public BelezaNaWebEntities()
            : base("name=BelezaNaWebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<inventory> inventory { get; set; }
        public virtual DbSet<produto> produto { get; set; }
        public virtual DbSet<warehouses> warehouses { get; set; }
    }
}
