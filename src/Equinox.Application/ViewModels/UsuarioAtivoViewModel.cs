using System.ComponentModel.DataAnnotations;
namespace Equinox.Application.ViewModels
{
    public class UsuarioAtivoViewModel
    {
        [Key]
        public int id { get; set; }
        public int AtivoId { get; set; }
        public int UsuarioId { get; set; }
        public int Quantidade { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }
        public virtual AtivoViewModel Ativo { get; set; }
    }
}
