using Microsoft.EntityFrameworkCore;
using StokTakip.WebApp1.Models;
namespace StokTakip.WebApp1.Repository;

public class RepositoryBaglantisi : DbContext
{
    public RepositoryBaglantisi(DbContextOptions opt) : base(opt)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=Stok_Takip_uygulama_db;Trusted_Connection= true");
    }
    public DbSet<Product> Products { get; set; }
}
