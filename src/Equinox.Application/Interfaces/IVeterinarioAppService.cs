using Equinox.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Equinox.Application.Interfaces
{
    public interface IVeterinarioAppService : IDisposable
    {
        VeterinarioViewModel GetByIdVeterinario(int id);
        VeterinarioViewModel GetByCPFVeterinario(string Termo);
        void Register(VeterinarioViewModel veterinarioViewModel);
        void Updated(VeterinarioViewModel veterinarioViewModel);
        ICollection<VeterinarioViewModel> GetByNomeVeterinario(string nome);
        ICollection<HorariosViewModel> CarregarHorarios(string dia, string veterinarioId);
        int QtdAgendamento(string data, string horario);
    }
}
