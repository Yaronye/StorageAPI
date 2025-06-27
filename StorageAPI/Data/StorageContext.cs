using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StorageAPI.Models;

    public class StorageContext : DbContext
    {
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(
            new Product { Category = "Sauces", Count = 1, Description = "Såser och sånt", Id = 1, Name = "Tacosauce", Price = 25, Shelf = "5" },
            new Product { Category = "Pets", Count = 5, Description = "Dog shampoo", Id = 2, Name = "Doggy clean", Price = 50, Shelf = "11" });
    }

    public DbSet<StorageAPI.Models.Product> Product { get; set; } = default!;
    }
