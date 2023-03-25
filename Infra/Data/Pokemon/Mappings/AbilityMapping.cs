using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokemon.Entities;

namespace Pokemon.Mappings;

public class AbilityMapping : IEntityTypeConfiguration<AbilityEntity>
{
    public void Configure(EntityTypeBuilder<AbilityEntity> builder)
    {
        builder.HasKey(x => x.AbilityId);
        builder.Property(x => x.AbilityId).ValueGeneratedOnAdd();

        builder.Property(x => x.Name);

        builder
            .HasMany(x => x.PokemonsEntity)
            .WithMany(x => x.Abilities);

        builder.ToTable("AbilityTable");
    }
}