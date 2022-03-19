using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Application.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int id { get; set; }
        public string nome { get;  set; }
        public DateTime? dataCadastro { get; set; }
        public string cpf { get;  set; }
        public string observacao { get; set; }
        public virtual ICollection<ClienteContatoViewModel> contatos { get;  set; }
        public virtual ICollection<ClienteAnimalViewModel> animais { get;  set; }
    }
}
