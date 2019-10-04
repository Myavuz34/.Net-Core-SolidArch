using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Yvz.Northwind.DataAccess.Concrete.EntityFrameworkMapping;
using Yvz.Northwind.Entities.Concrete;


namespace Yvz.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        //public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        //{
        //}



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MUSTAFA;Initial Catalog=Northwind; Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new DepartmentMap(modelBuilder.Entity<Department>());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
