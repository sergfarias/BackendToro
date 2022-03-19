using Equinox.Domain.Core.Commands;
using System;

namespace Equinox.Domain.Commands.Agendamento
{
    public abstract class AgendamentoCommand : Command
    {
        public int Id { get; protected set; }
        public int ClienteId { get; protected set; }
        public int AnimalId { get; protected set; }
        public int VeterinarioId { get; protected set; }
        public string Horario { get; protected set; }
        public string DataConsulta { get; protected set; }
        public DateTime? DataCadastro { get; protected set; }
    }
}