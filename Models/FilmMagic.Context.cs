﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmMagic.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FilmMagicEntities1 : DbContext
    {
        public FilmMagicEntities1()
            : base("name=FilmMagicEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alquiler> Alquilers { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Devolucion> Devolucions { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}
