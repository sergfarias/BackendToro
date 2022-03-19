using Equinox.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Equinox.Application.Interfaces
{
    public interface IAtendimentoAppService : IDisposable
    {
        void Register(AtendimentoViewModel atendimentoViewModel);
        ICollection<AgendamentoGridViewModel> CarregarAgendamentos(string data);
        ICollection<AtendimentoGridViewModel> CarregarAtendimentos(string data);
    }
}
