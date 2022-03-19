using Equinox.Domain.Core.Commands;
using System;

namespace Equinox.Domain.Commands.Atendimento
{
    public abstract class AtendimentoCommand : Command
    {
        public int Id { get; protected set; }
        public int AgendamentoId { get; protected set; }
        public string Diagnostico { get; protected set; }
        public DateTime DataAtendimento { get; protected set; }
        public DateTime? DataCadastro { get; protected set; }
    }
}