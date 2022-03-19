using System;
using Equinox.Domain.Core.Models;
using System.Collections.Generic;

namespace Equinox.Domain.Models
{
    public class Cliente : Entity<Cliente> 
    {
       
        public string Nome { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public string Cpf { get; private set; }
        public string Observacao { get; private set; }
        public virtual ICollection<ClienteContato> ClienteContato { get; private set; }
        public virtual ICollection<ClienteAnimal> ClienteAnimal { get; private set; }
        public virtual ICollection<Agendamento> Agendamento { get; private set; }

        public Cliente(int id,  string nome, DateTime? dataCadastro,
                       string cpf, string observacao,  ICollection<ClienteContato> clienteContato,
                       ICollection<ClienteAnimal> clienteAnimal)
        {
            Id = id;
            Nome = nome;
            DataCadastro = dataCadastro;
            Cpf = cpf;
            Observacao = observacao;
            ClienteContato = clienteContato;
            ClienteAnimal = clienteAnimal;
        }

        // Empty constructor for EF
        protected Cliente() { }

        public override bool IsValid()
        {
            return true;
        }


    }
}