using Equinox.Domain.Models;
namespace Equinox.Domain.Interfaces
{
    public interface IUsuarioAtivoRepository : IRepository<UsuarioAtivo>
    {
        UsuarioAtivo GetByUsuarioAtivo(int id);
    }
}