using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class AtivoMap : IEntityTypeConfiguration<Ativo>
    {
        public void Configure(EntityTypeBuilder<Ativo> builder)
        {

            builder.Property(c => c.Id)
            .HasColumnName("Id");

            builder.Property(c => c.Sigla)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(c => c.Descricao)
            .HasColumnType("varchar(150)")
            .HasMaxLength(150)
            .IsRequired();

            builder.Property(c => c.Valor)
           .HasColumnType("decimal(18,5)");
           
            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
