using System;
using Equinox.Application.ViewModels;
namespace Equinox.Application.Interfaces
{
    public interface IMovimentoAppService : IDisposable
    {
        void Register(MovimentoViewModel movimentoViewModel);
    }
}
