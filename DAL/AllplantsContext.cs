using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AllplantsSelector.Models;

namespace AllplantsSelector.DAL
{
    public class AllplantsContext : DbContext
    {
        public AllplantsContext() :base("AllPlantsContext")
        {

        }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
