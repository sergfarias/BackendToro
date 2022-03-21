using Equinox.Domain.Core.Commands;
using System;
namespace Equinox.Domain.Commands.Movimento
{
    public abstract class MovimentoCommand : Command
    {
        public int Id { get; protected set; }
        public int UsuarioId { get; protected set; }
        public string Evento { get; protected set; }
        public string BancoDestino { get; protected set; }
        public string AgenciaDestino { get; protected set; }
        public string ContaDestino { get; protected set; }
        public string BancoOrigem { get; protected set; }
        public string AgenciaOrigem { get; protected set; }
        public string CpfOrigem { get; protected set; }
        public decimal Valor { get; protected set; }
        public DateTime? DataCadastro { get; protected set; }
        public virtual Models.Usuario Usuario { get; protected set; }
    }
}