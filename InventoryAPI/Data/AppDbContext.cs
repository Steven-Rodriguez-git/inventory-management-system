using InventoryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        // Aquí defines tus tablas (DbSets)
        // Ejemplo:
        // public DbSet<Product> Products { get; set; }
    }
}

