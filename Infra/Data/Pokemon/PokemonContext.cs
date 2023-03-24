using Microsoft.EntityFrameworkCore;
using Pokemon.Entities;
namespace Pokemon;

public class PokemonContext : DbContext
{
    public PokemonContext() { }
    public PokemonContext(DbContextOptions<PokemonContext> options) : base(options)
    {
    }
    public DbSet<PokemonEntity> Pokemon { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<PokemonEntity>()
            .HasKey(m => m.Id);
        base.OnModelCreating(builder);
    }

}