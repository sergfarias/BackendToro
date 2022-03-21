using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.Property(c => c.Id)
            .HasColumnName("Id");

            builder.Property(c => c.CodConta)
            .HasColumnType("varchar(6)");

            builder.Property(c => c.Nome)
            .HasColumnType("varchar(150)")
            .HasMaxLength(150)
            .IsRequired();

            builder.Property(c => c.Email)
            .HasColumnType("varchar(150)")
            .HasMaxLength(150)
            .IsRequired(false);

            builder.Property(c => c.DataCadastro)
            .HasColumnType("datetime")
            .IsRequired(false);

            builder.Property(c => c.Cpf)
            .HasColumnType("varchar(20)")
            .HasMaxLength(20)
            .IsRequired();

            builder.Property(c => c.Senha)
           .HasColumnType("varchar(25)")
           .HasMaxLength(25)
           .IsRequired();

            builder.Property(c => c.Saldo)
           .HasColumnType("decimal(18,5)");
           
            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
