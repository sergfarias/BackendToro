using System;
using System.Collections.Generic;
using Equinox.Domain.Core.Models;

namespace Equinox.Domain.Models
{
    public class ClienteAnimal : Entity<ClienteAnimal> 
    {
    
        public int ClienteId { get; private set; }
        public int Idade { get; private set; }
        public string Nome { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public int TipoAnimalId { get; private set; }
        public TipoAnimal TipoAnimal
        {
            get => TipoAnimal.ObterPorId(TipoAnimalId);
            set => TipoAnimalId = value.Id;
        }
        public virtual Cliente Cliente { get; private set; }
        public virtual ICollection<Agendamento> Agendandamento { get; private set; }

        public ClienteAnimal(int id, int clienteId, Cliente cliente, int tipoAnimalId, TipoAnimal tipoAnimal, string nome, 
                                 int idade, DateTime? dataCadastro)
        {
            Id = id;
            ClienteId = clienteId;
            Cliente = cliente;
            if (tipoAnimal != null)
            {
                TipoAnimalId = TipoAnimal.Id;
                TipoAnimal = tipoAnimal;
            }
            Nome = nome;
            Idade = idade;
            DataCadastro = dataCadastro;
        }

        // Empty constructor for EF
        protected ClienteAnimal() { }

        public override bool IsValid()
        {
            return true;
        }

    }
}