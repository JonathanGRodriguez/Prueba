﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TorneoJRodriguezEntities : DbContext
    {
        public TorneoJRodriguezEntities()
            : base("name=TorneoJRodriguezEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
    
        public virtual ObjectResult<string> NombreClienteGet()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("NombreClienteGet");
        }
    }
}
