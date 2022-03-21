using System;
using Equinox.Domain.Core.Models;
using System.Collections.Generic;

namespace Equinox.Domain.Models
{
    public class Usuario : Entity<Usuario> 
    {

        public long CodConta { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public decimal Saldo { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public virtual ICollection<UsuarioAtivo> UsuarioAtivo { get; private set; }
        public virtual ICollection<Movimento> Movimento { get; private set; }

        public Usuario(int id, long codConta, string nome, string cpf, string email, 
                       string senha, decimal saldo, DateTime? dataCadastro,
                       ICollection<UsuarioAtivo> usuarioAtivo)
        {
            Id = id;
            CodConta = codConta;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Saldo = saldo;
            DataCadastro = dataCadastro;
            UsuarioAtivo = usuarioAtivo;
        }

        // Empty constructor for EF
        protected Usuario() { }

        public override bool IsValid()
        {
            return true;
        }

    }
}