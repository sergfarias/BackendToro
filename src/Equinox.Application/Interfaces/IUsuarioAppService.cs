using System;
using Equinox.Application.ViewModels;
namespace Equinox.Application.Interfaces
{
    public interface IUsuarioAppService : IDisposable
    {
        void Register(UsuarioViewModel usuarioViewModel);
        bool ValidaCPF(string cpf);
        
        UsuarioViewModel GetByUsuario(string cpf, string senha);
        UsuarioViewModel GetByUsuario(string cpf);
        UsuarioPosicaoViewModel GetByUsuarioPosicao(string cpf);
    }
}
