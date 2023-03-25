using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Trainer.Entities;
using Trainer.Mappings;

namespace Trainer;

public class TrainerContext : DbContext
{
    public TrainerContext(){}
    
    public TrainerContext(DbContextOptions<TrainerContext> options) : base(options)
    {
        
    }

    public DbSet<TrainerEntity> Trainer { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TrainerMapping());
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