using Compartirometro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compartirometro.Infrastructure.Persistence.Configurations;

public class CompartidoConfiguration : IEntityTypeConfiguration<Compartido>
{
    public void Configure(EntityTypeBuilder<Compartido> builder)
    {
        builder.Property(c => c.Titulo)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(c => c.Descripcion)
            .HasMaxLength(1000);

        builder.Property(c => c.CreatedAt)
            .IsRequired();
    }
}
