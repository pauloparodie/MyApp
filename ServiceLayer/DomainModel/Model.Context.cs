﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceLayer.DomainModel
{
int a = 0;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ModelEntities : DbContext
    {
        public ModelEntities()
            : base("name=ModelEntities")
        {
        }
    //dtetr
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<animal> animals { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
    
        public virtual int proc1(Nullable<int> arg1)
        {
            var arg1Parameter = arg1.HasValue ?
                new ObjectParameter("arg1", arg1) :
                new ObjectParameter("arg1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc1", arg1Parameter);
        }
    }
}
