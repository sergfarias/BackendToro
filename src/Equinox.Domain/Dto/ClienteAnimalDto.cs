using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Domain.Dto
{
    public class ClienteAnimalDto
    {
        [Key]
        public int clienteid { get; set; }
        public int id  { get; set; }
        public int tipoanimalid  { get; set; }
        public string tipoanimalnome { get; set; }
        public int idade { get; set; }
        public string nome { get; set; }
        public DateTime? dataCadastro { get; set; }
        // public virtual ClienteViewModel cliente { get; set; }

    }
}
