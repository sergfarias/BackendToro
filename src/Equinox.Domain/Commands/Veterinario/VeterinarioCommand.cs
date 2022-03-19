using System;
using System.Collections.Generic;
using Equinox.Domain.Core.Commands;
using Equinox.Domain.Models;

namespace Equinox.Domain.Commands.Veterinario
{
    public abstract class VeterinarioCommand : Command
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public DateTime? DataContratacao { get; protected set; }
        public string Cpf { get; protected set; }
        public bool Geriatra { get; protected set; }
        public DateTime? DataCadastro { get; protected set; }
    }
}