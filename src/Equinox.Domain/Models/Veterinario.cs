using System;
using Equinox.Domain.Core.Models;
using System.Collections.Generic;

namespace Equinox.Domain.Models
{
    public class Veterinario : Entity<Veterinario> 
    {
        public string Nome { get; private set; }
        public DateTime? DataContratacao { get; private set; }
        public string Cpf { get; private set; }
        public bool Geriatra { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public virtual ICollection<Agendamento> Agendamento { get; private set; }

        public Veterinario(int id,  string nome, DateTime? dataContratacao,
                       string cpf,  bool geriatra, DateTime? dataCadastro)
        {
            Id = id;
            Nome = nome;
            DataContratacao = dataContratacao;
            Cpf = cpf;
            Geriatra = geriatra;
            DataCadastro = dataCadastro;
        }

        // Empty constructor for EF
        protected Veterinario() { }

        public override bool IsValid()
        {
            return true;
        }


    }
}