﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SalesDBEntities : DbContext
    {
        public SalesDBEntities()
            : base("name=SalesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SalesPerson> SalesPersons { get; set; }
        public virtual DbSet<SalesPersonCategory> SalesPersonCategories { get; set; }
        public virtual DbSet<SalesProduct> SalesProducts { get; set; }
    
        public virtual ObjectResult<SP_GetAllSalesPersonDetails_Result> SP_GetAllSalesPersonDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllSalesPersonDetails_Result>("SP_GetAllSalesPersonDetails");
        }
    }
}
