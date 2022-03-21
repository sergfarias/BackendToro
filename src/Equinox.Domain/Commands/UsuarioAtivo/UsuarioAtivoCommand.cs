using Equinox.Domain.Core.Commands;
using Equinox.Domain.Models;
using System;

namespace Equinox.Domain.Commands.UsuarioAtivo
{
    public abstract class UsuarioAtivoCommand : Command
    {
        public int Id { get; protected set; }
        public int UsuarioId { get; protected set; }
        public int AtivoId { get; protected set; }
        public int Quantidade { get; protected set; }
        public DateTime? DataCadastro { get; protected set; }
        public virtual Models.Usuario Usuario { get; protected set; }
        public virtual Ativo Ativo { get; protected set; }

    }
}