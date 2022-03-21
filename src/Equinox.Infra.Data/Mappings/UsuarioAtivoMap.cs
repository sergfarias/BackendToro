using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class UsuarioAtivoMap : IEntityTypeConfiguration<UsuarioAtivo>
    {
        public void Configure(EntityTypeBuilder<UsuarioAtivo> builder)
        {

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.UsuarioId)
                .HasColumnName("UsuarioId");

            builder.Property(c => c.AtivoId)
                .HasColumnName("AtivoId");

            builder.HasOne(cc => cc.Usuario)
                .WithMany(f => f.UsuarioAtivo)
                .HasForeignKey(cc => cc.UsuarioId);

            builder.HasOne(cc => cc.Ativo)
               .WithMany(f => f.UsuarioAtivo)
               .HasForeignKey(cc => cc.AtivoId);

            builder.Property(c => c.Quantidade)
                .HasColumnType("int");

            builder.Property(c => c.DataCadastro)
                .HasColumnType("datetime")
                .IsRequired(false);

            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
