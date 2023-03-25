using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokemon.Entities;

namespace Pokemon.Mappings;

public class TypeMapping : IEntityTypeConfiguration<TypeEntity>
{
    public void Configure(EntityTypeBuilder<TypeEntity> builder)
    {
        builder
            .HasKey(x => x.Id);
        
        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        builder
            .Property(x => x.Name);
        
        builder
            .HasMany(x => x.PokemonEntities)
            .WithMany(x => x.Types);

        builder.ToTable("TypeTable");
    }
}