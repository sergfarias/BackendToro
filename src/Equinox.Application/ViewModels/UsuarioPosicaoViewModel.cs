using System.Collections.Generic;
namespace Equinox.Application.ViewModels
{
    public class UsuarioPosicaoViewModel
    {
        public IEnumerable<PosicaoViewModel> positions { get; set; }
        public decimal checkingAccountAmount { get; set; }
        public decimal consolidated { get; set; }
    }
}
