using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trainer.Entities;

namespace Trainer.Mappings;

public class TrainerMapping : IEntityTypeConfiguration<TrainerEntity>
{
    public void Configure(EntityTypeBuilder<TrainerEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Cpf);
        builder.Property(x => x.Idade);
        builder.Property(x => x.Name);
        
        builder.ToTable("TrainerTable");
        
    }
}