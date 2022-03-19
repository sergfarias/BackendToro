using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Equinox.Domain.Models;

namespace Equinox.Infra.Data.Mappings
{    
    public class VeterinarioGradeMap : IEntityTypeConfiguration<VeterinarioGrade>
    {
        public void Configure(EntityTypeBuilder<VeterinarioGrade> builder)
        {

            builder.Property(c => c.Id)
            .HasColumnName("Id");

            builder.Property(c => c.VeterinarioId)
               .IsRequired();

            builder.Property(c => c.DiaSemana)
               .IsRequired();

            builder.Property(c => c.HorIni)
            .HasColumnType("timestamp")
            .IsRequired();

            builder.Property(c => c.HorFim)
            .HasColumnType("timestamp")
            .IsRequired();

            builder.Property(c => c.Intervalo)
               .IsRequired();

            builder.Ignore(c => c.CascadeMode);
            builder.Ignore(c => c.ValidationResult);
        }
    }
}
