using System;
using System.Collections.Generic;
using Equinox.Domain.Core.Commands;
using Equinox.Domain.Models;

namespace Equinox.Domain.Commands.Cliente
{
    public abstract class ClienteCommand : Command
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public DateTime? DataCadastro { get; protected set; }
        public string Cpf { get; protected set; }
        public string Observacao { get; protected set; }
        public virtual ICollection<ClienteContato> Contatos { get; set; }
        public virtual ICollection<ClienteAnimal> Animais { get; set; }
    }
}