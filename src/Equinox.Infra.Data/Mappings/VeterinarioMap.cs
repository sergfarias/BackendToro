using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class VeterinarioMap : IEntityTypeConfiguration<Veterinario>
    {
        public void Configure(EntityTypeBuilder<Veterinario> builder)
        {

            builder.Property(c => c.Id)
            .HasColumnName("Id");

            builder.Property(c => c.Nome)
            .HasColumnType("varchar(150)")
            .HasMaxLength(150)
            .IsRequired(false);

            builder.Property(c => c.DataContratacao)
            .HasColumnType("timestamp")
            .IsRequired(false);

            builder.Property(c => c.Cpf)
            .HasColumnType("varchar(20)")
            .HasMaxLength(20)
            .IsRequired();

            builder.Property(c => c.DataCadastro)
            .HasColumnType("timestamp")
            .IsRequired(false);

            builder.Property(c => c.Geriatra)
            .HasColumnType("boolean");
           
            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
