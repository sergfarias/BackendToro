using System;
using Equinox.Application.ViewModels;
namespace Equinox.Application.Interfaces
{
    public interface IUsuarioAtivoAppService : IDisposable
    {
        void Register(UsuarioAtivoViewModel usuarioAtivoViewModel);
        AtivoViewModel GetByAtivo(string sigla);
    }
}
