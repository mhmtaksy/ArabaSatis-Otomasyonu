﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class rentacarEntities : DbContext
    {
        public rentacarEntities()
            : base("name=rentacarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Customerr> Customerrs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
