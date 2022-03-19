using System;
using Equinox.Domain.Core.Models;
using System.Collections.Generic;

namespace Equinox.Domain.Models
{
    public class VeterinarioGrade : Entity<VeterinarioGrade> 
    {
        public int  VeterinarioId { get; private set; }
        public int DiaSemana { get; private set; }
        public DateTime HorIni { get; private set; }
        public DateTime HorFim { get; private set; }
        public int Intervalo { get; private set; }

        // Empty constructor for EF
        protected VeterinarioGrade() { }

        public override bool IsValid()
        {
            return true;
        }

    }
}