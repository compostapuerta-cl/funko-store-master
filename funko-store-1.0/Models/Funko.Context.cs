﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace funko_store_1._0.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FUNKOBDEntities1 : DbContext
    {
        public FUNKOBDEntities1()
            : base("name=FUNKOBDEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_categorias> tb_categorias { get; set; }
        public virtual DbSet<tb_productos> tb_productos { get; set; }
        public virtual DbSet<tb_usuarios> tb_usuarios { get; set; }
        public virtual DbSet<tb_pedido> tb_pedido { get; set; }
        public virtual DbSet<tb_detapedido> tb_detapedido { get; set; }
    
        public virtual ObjectResult<Nullable<int>> Autogenera()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Autogenera");
        }
    }
}
