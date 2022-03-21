using Equinox.Domain.Core.Commands;
using System;
namespace Equinox.Domain.Commands.Usuario
{
    public abstract class UsuarioCommand : Command
    {
        public int Id { get; protected set; }
        public long CodConta { get; protected set; }
        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public string Senha { get; protected set; }
        public string Cpf { get; protected set; }
        public decimal Saldo { get; protected set; }
        public DateTime? DataCadastro { get; protected set; }
    }
}