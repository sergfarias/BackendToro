using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class AtendimentoMap : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {

            builder.Property(c => c.Id)
            .HasColumnName("Id");

            builder.Property(c => c.AgendamentoId);
            
            builder.Property(c => c.Diagnostico)
            .HasColumnType("varchar(250)")
            .IsRequired(false);

            builder.Property(c => c.DataAtendimento)
            .HasColumnType("timestamp");

            builder.Property(c => c.DataCadastro)
            .HasColumnType("timestamp")
            .IsRequired(false);

            builder.Ignore(c => c.Agendamento);

            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
