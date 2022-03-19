using System;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Application.ViewModels
{
    public class ClienteAnimalViewModel
    {
        [Key]
        public int id { get; set; }
        public int clienteId { get; set; }
        public int tipoAnimalId  { get; set; }
        public string tipoAnimalNome { get; set; }
        public int idade { get; set; }
        public string nome { get; set; }
        public DateTime? dataCadastro { get; set; }
        public virtual ClienteViewModel cliente { get;  set; }
    }
}
