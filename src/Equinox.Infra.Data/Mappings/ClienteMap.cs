using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.Property(c => c.Id)
            .HasColumnName("Id");

            builder.Property(c => c.Nome)
            .HasColumnType("varchar(150)")
            .HasMaxLength(150)
            .IsRequired(false);

            builder.Property(c => c.DataCadastro)
            .HasColumnType("timestamp")
            .IsRequired(false);

            builder.Property(c => c.Cpf)
            .HasColumnType("varchar(20)")
            .HasMaxLength(20)
            .IsRequired();

            builder.Property(c => c.Observacao)
           .HasColumnType("varchar(250)")
           .HasMaxLength(250)
           .IsRequired(false);

            
            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
