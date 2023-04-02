using Microsoft.EntityFrameworkCore;
using ShoppingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoopingApp.DataAccess.Concrete.EFCore
{
    public class ShoppingContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ShoppingDB;integrated security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategoryRelation>() //fluentAPI yazılması gerekiyor.
                .HasKey(c => new { c.CategoryId, c.ProductId }); // tablonun birincil anahtarı 2 anahtar yapılmış olur.
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        
        
           
    }
}
