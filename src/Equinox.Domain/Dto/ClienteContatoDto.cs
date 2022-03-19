using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Domain.Dto
{
    public class ClienteContatoDto
    {
        [Key]
        public int id_cliente { get; set; }
        public int id_contato { get; set; }
        public int id_tipo_contato  { get; set; }
        public string ds_contato { get; set; }
    }
}
