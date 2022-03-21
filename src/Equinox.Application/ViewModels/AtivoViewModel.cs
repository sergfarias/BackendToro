using System;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Application.ViewModels
{
    public class AtivoViewModel
    {
        [Key]
        public int id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}
