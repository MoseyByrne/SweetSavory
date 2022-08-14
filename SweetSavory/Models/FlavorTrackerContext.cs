using Microsoft.EntityFrameworkCore;

namespace SweetSavory.Models
{
  public class SweetSavoryContext : DbContext
  {
    public DbSet<Treat> Treats { get; set; }

    public DbSet<Flavor> Flavors { get; set; }

    public DbSet<TreatFlavor> TreatFlavor { get; set; }

    public SweetSavoryContext(DbContextOptions options) :
        base(options)
    {
    }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder
    )
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
