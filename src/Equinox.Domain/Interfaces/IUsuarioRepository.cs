using Equinox.Domain.Dto;
using Equinox.Domain.Models;
using System.Collections.Generic;

namespace Equinox.Domain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario GetByUsuario(string cpf, string senha);
        Usuario GetByUsuario(string cpf);
        UsuarioPosicaoDto GetByUsuarioPosicao(string cpf);
    }
}