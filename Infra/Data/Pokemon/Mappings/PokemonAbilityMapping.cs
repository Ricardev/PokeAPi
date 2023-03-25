using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokemon.Entities;

namespace Pokemon.Mappings;

public class PokemonAbilityMapping : IEntityTypeConfiguration<PokemonAbility>
{
    public void Configure(EntityTypeBuilder<PokemonAbility> builder)
    {
        
        builder
            .HasKey(x => x.PokemonAbilityId);
        
        builder
            .Property(x => x.PokemonAbilityId)
            .ValueGeneratedOnAdd();
        
        builder
            .HasOne(x => x.Pokemon)
            .WithMany(x => x.PokemonAbilities)
            .HasForeignKey(x => x.PokemonId);

        builder.HasOne(x => x.Ability)
            .WithMany(x => x.PokemonsAbility)
            .HasForeignKey(x => x.AbilityId);

        builder.ToTable("PokemonAbilityTable");
    }
}