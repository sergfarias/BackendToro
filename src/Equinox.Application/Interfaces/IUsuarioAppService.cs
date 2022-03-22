using System;
using Equinox.Application.ViewModels;
namespace Equinox.Application.Interfaces
{
    public interface IUsuarioAppService : IDisposable
    {
        void Register(UsuarioViewModel usuarioViewModel);
        void Update(UsuarioViewModel usuarioViewModel);
        bool ValidaCPF(string cpf);
        UsuarioViewModel GetByUsuario(string cpf, string senha);
        UsuarioViewModel GetByUsuario(string cpf);
        UsuarioViewModel GetByUsuario(int usuarioId);
        UsuarioPosicaoViewModel GetByUsuarioPosicao(string cpf);
    }
}
