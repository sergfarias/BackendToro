using System;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Domain.Dto
{
    public class AgendamentoGridDto
    {
        [Key]
        public int id { get; set; }
        public string dataConsulta { get; set; }
        public string horario { get; set; }
        public int veterinarioId { get; set; }
        public string veterinarioNome { get; set; }
        public int clienteId { get; set; }
        public string clienteNome { get; set; }
        public int animalId { get; set; }
        public string animalNome { get; set; }
        public int tipoAnimalId { get; set; }
        public string tipoAnimalNome { get; set; }
       
    }
}
