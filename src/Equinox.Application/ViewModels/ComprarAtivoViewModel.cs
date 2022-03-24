using System.ComponentModel.DataAnnotations;
namespace Equinox.Application.ViewModels
{
    public class ComprarAtivoViewModel
    {
        public string Sigla { get; set; }
        public string Valor { get; set; }
        public int UsuarioId { get; set; }
        public int Quantidade { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }
        public virtual AtivoViewModel Ativo { get; set; }
    }
}
