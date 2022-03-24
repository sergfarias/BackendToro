using Equinox.Domain.Models;
namespace Equinox.Domain.Interfaces
{
    public interface IAtivoRepository : IRepository<Ativo>
    {
        Ativo GetByAtivo(int id);
        Ativo GetByAtivo(string sigle);
    }
}