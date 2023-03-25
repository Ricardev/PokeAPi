using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokemon.Entities;

namespace Pokemon.Mappings;

public class PokemonMapping : IEntityTypeConfiguration<PokemonEntity>
{
    public void Configure(EntityTypeBuilder<PokemonEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Height);
        builder.Property(x => x.Name);
        builder.Property(x => x.Weight);
        builder.Property(x => x.FrontDefault);

        builder
            .HasMany(x => x.Abilities)
            .WithMany(x => x.PokemonsEntity);

        builder.HasMany(x => x.Types)
            .WithMany(x => x.PokemonEntities);
        
        builder.ToTable("PokemonTable");
    }
}