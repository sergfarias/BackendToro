using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class ClienteAnimalMap : IEntityTypeConfiguration<ClienteAnimal>
    {
        public void Configure(EntityTypeBuilder<ClienteAnimal> builder)
        {

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.ClienteId)
                .HasColumnName("ClienteId");

            builder.HasOne(cc => cc.Cliente)
                .WithMany(f => f.ClienteAnimal)
                .HasForeignKey(cc => cc.ClienteId);

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(250)")
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(c => c.Idade)
                .HasColumnType("int");

            builder.Property(c => c.DataCadastro)
                .HasColumnType("timestamp")
                .IsRequired(false);

            builder.Property(c => c.TipoAnimalId)
            .IsRequired();

            builder.Ignore(c => c.TipoAnimal);

            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
