using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class AgendamentoMap : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {

            builder.Property(c => c.Id)
            .HasColumnName("Id");

            builder.HasOne(c => c.Cliente)
            .WithMany(f => f.Agendamento)
            .HasForeignKey(c => c.ClienteId);

            builder.Property(c => c.AnimalId);
            builder.Ignore(c => c.ClienteAnimal);

            builder.HasOne(c => c.Veterinario)
            .WithMany(f => f.Agendamento)
            .HasForeignKey(c => c.VeterinarioId);

            builder.Property(c => c.Horario)
            .HasColumnType("varchar(10)")
            .HasMaxLength(10)
            .IsRequired(false);

            builder.Property(c => c.DataConsulta)
            .HasColumnType("varchar(12)")
            .HasMaxLength(12)
            .IsRequired(false);

            builder.Property(c => c.DataCadastro)
            .HasColumnType("timestamp")
            .IsRequired(false);

            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
