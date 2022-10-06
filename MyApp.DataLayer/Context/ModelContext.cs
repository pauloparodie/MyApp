using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyApp.DomainModel.Entities;


namespace MyApp.DataLayer.Context
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=MyAppDataLayerCS")
        {

        }

        public virtual DbSet<Pessoa> Pessoas { get; set; }

        public virtual DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
