using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokemon.Entities;

namespace Pokemon.Mappings;

public class PokemonTypeMapping : IEntityTypeConfiguration<PokemonType>
{
    public void Configure(EntityTypeBuilder<PokemonType> builder)
    {
        builder.HasKey(x => x.PokemonTypeId);
        
        builder
            .Property(x => x.PokemonTypeId)
            .ValueGeneratedOnAdd();
        
        builder
            .HasOne(x => x.Pokemon)
            .WithMany(x => x.PokemonTypes)
            .HasForeignKey(x => x.PokemonId);

        builder
            .HasOne(x => x.Type)
            .WithMany(x => x.PokemonsTypes)
            .HasForeignKey(x => x.TypeId);

        builder.ToTable("PokemonTypeTable");
    }
}