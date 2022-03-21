using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class MovimentoMap : IEntityTypeConfiguration<Movimento>
    {
        public void Configure(EntityTypeBuilder<Movimento> builder)
        {

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.UsuarioId)
                    .HasColumnName("UsuarioId");

            builder.HasOne(cc => cc.Usuario)
                .WithMany(f => f.Movimento)
                .HasForeignKey(cc => cc.UsuarioId);

            builder.Property(c => c.Evento)
               .HasColumnType("varchar(25)")
               .HasMaxLength(25)
               .IsRequired(false);

            builder.Property(c => c.BancoDestino)
               .HasColumnType("varchar(10)")
               .HasMaxLength(10)
               .IsRequired(false);

            builder.Property(c => c.AgenciaDestino)
              .HasColumnType("varchar(10)")
              .HasMaxLength(10)
              .IsRequired(false);

            builder.Property(c => c.ContaDestino)
              .HasColumnType("varchar(10)")
              .HasMaxLength(10)
              .IsRequired(false);

            builder.Property(c => c.BancoOrigem)
              .HasColumnType("varchar(10)")
              .HasMaxLength(10)
              .IsRequired(false);

            builder.Property(c => c.AgenciaOrigem)
              .HasColumnType("varchar(10)")
              .HasMaxLength(10)
              .IsRequired(false);

            builder.Property(c => c.CpfOrigem)
              .HasColumnType("varchar(15)")
              .HasMaxLength(15)
              .IsRequired(false);

            builder.Property(c => c.Valor)
              .HasColumnType("decimal(18,5)");

            builder.Property(c => c.DataCadastro)
                .HasColumnType("datetime")
                .IsRequired(false);

            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
