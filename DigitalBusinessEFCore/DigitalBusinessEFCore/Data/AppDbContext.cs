using Microsoft.EntityFrameworkCore;
using DigitalBusinessEFCore.Models;

namespace DigitalBusinessEFCore.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=DigitalBusinessDB;Username=postgres;Password=Tenda@2023");
        }
    }
}
