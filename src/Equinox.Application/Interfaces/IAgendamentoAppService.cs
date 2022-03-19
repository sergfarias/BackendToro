using Equinox.Application.ViewModels;
using System;

namespace Equinox.Application.Interfaces
{
    public interface IAgendamentoAppService : IDisposable
    {
        void Register(AgendamentoViewModel agendamentoViewModel);
       
    }
}
