using lesson65.Services;
using Microsoft.EntityFrameworkCore;

namespace lesson65.Models;

public class CountryDb : DbContext
{
    public DbSet<Country> Countries { get; set; }
    
    public CountryDb(DbContextOptions<CountryDb> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new DbInitializer(modelBuilder).Seed();
    }
}