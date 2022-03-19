using Equinox.Domain.Core.Models;
using System;

namespace Equinox.Domain.Models
{
    public class Agendamento : Entity<Agendamento> 
    {
       
        public int ClienteId { get; private set; }
        public int AnimalId { get; private set; }
        public int VeterinarioId { get; private set; }
        public string Horario { get; private set; }
        public string DataConsulta { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public virtual Cliente Cliente { get; private set; }
        public virtual ClienteAnimal ClienteAnimal { get; private set; }
        public virtual Veterinario Veterinario { get; private set; }
        
        public Agendamento(int id, int clienteId, int animalId, int veterinarioId,  string horario,
                          string dataConsulta, DateTime? dataCadastro)
        {
            Id = id;
            ClienteId = clienteId;
            AnimalId = animalId;
            VeterinarioId = veterinarioId;
            Horario = horario;
            DataConsulta = dataConsulta;
            DataCadastro = dataCadastro;
        }

        // Empty constructor for EF
        protected Agendamento() { }

        public override bool IsValid()
        {
            return true;
        }

    }
}