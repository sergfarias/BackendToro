using System;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Application.ViewModels
{
    public class AgendamentoViewModel
    {
        [Key]
        public int id { get; set; }
        public int clienteid { get; set; }
        public int animalid { get; set; }
        public int veterinarioid { get; set; }
        public string horario { get;  set; }
        public string dataConsulta { get; set; }
        public DateTime? dataCadastro { get; set; }
    }
}
