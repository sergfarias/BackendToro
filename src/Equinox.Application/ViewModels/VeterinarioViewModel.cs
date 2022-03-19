using System;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Application.ViewModels
{
    public class VeterinarioViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get;  set; }
        public DateTime? DataContratacao { get; set; }
        public string Cpf { get;  set; }
        public bool Geriatra { get; set; }
        public string Termo { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}
