using System;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Application.ViewModels
{
    public class AtendimentoViewModel
    {
        [Key]
        public int id { get; set; }
        public int agendamentoid { get; set; }
        public string diagnostico { get;  set; }
        public string dataAtendimento { get; set; }
        public DateTime? dataCadastro { get; set; }


    }
}
