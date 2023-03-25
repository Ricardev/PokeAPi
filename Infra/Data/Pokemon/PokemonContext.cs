using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pokemon.Entities;
using Pokemon.Mappings;

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
        builder.ApplyConfiguration(new PokemonMapping());
        builder.ApplyConfiguration(new PokemonAbilityMapping());
        builder.ApplyConfiguration(new PokemonTypeMapping());
        builder.ApplyConfiguration(new TypeMapping());
        builder.ApplyConfiguration(new AbilityMapping());
        base.OnModelCreating(builder);
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            ConfigureOptionsBuilder(optionsBuilder);
        base.OnConfiguring(optionsBuilder);
    }

    private void ConfigureOptionsBuilder(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, false)
            .Build();
        optionsBuilder.UseSqlite(configuration.GetSection("DatabaseConnection")["SQLiteConnection"]!);
    }

}