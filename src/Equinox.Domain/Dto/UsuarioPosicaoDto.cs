using System.Collections.Generic;
namespace Equinox.Domain.Dto
{
    public class UsuarioPosicaoDto
    {
        public IEnumerable<PosicaoDto> positions { get; set; }
        public decimal checkingAccountAmount { get; set; }
        public decimal consolidated { get; set; }
    }
}
