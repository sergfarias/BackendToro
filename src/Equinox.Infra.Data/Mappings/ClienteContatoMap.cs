using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class ClienteContatoMap : IEntityTypeConfiguration<ClienteContato>
    {
        public void Configure(EntityTypeBuilder<ClienteContato> builder)
        {

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.ClienteId)
                .HasColumnName("ClienteId");

            builder.Property(c => c.TipoContatoId)
                .HasColumnName("TipoContatoId");

            builder.Ignore(c => c.TipoContato);

            builder.Property(c => c.NomeContato)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder.HasOne(cc => cc.Cliente)
           .WithMany(e=> e.ClienteContato)
           .HasForeignKey(cc => cc.ClienteId);

            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
