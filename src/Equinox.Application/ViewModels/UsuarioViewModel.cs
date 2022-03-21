using System;
using System.ComponentModel.DataAnnotations;
namespace Equinox.Application.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int id { get; set; }
        public long codConta { get; set; }
        public string cpf { get; set; }
        public string nome { get;  set; }
        public string email { get; set; }
        public string senha { get; set; }
        public decimal saldo { get; set; }
        public DateTime? dataCadastro { get; set; }
    }
}
