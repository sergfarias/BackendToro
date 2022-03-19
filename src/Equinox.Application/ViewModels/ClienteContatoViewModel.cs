using System.ComponentModel.DataAnnotations;

namespace Equinox.Application.ViewModels
{
    public class ClienteContatoViewModel
    {
        [Key]
        public int id_cliente  { get; set; }
        public int id_tipo_contato  { get; set; }
        public int id_contato  { get; set; }
        public string ds_contato { get; set; }
        public virtual ClienteViewModel Cliente { get; private set; }
    }
}
