using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using DBCodeFirst.Migrations;

/*teste*/
//reter
//sdfsdf
namespace DBCodeFirst
{
    public class ModelCFEntities : DbContext
    {
        public ModelCFEntities() : base("name=ModelCFEntities")
        {
        //dfgdf
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModelCFEntities, Configuration>());
            /*sfsdfsd*/
        }

        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
//sdfsdf
            //modelBuilder.Entity<Author>().Property(p => p.Age).HasDefaultValue(12);
            //modelBuilder.Entity<Author>().Property(p => p.Age).IsRequired();
            modelBuilder.Entity<Author>().Property(p => p.Age).IsOptional();
        }

    }
}
