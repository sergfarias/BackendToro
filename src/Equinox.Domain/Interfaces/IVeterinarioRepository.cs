using Equinox.Domain.Dto;
using Equinox.Domain.Models;
using System.Collections.Generic;

namespace Equinox.Domain.Interfaces
{
    public interface IVeterinarioRepository : IRepository<Veterinario>
    {
        Veterinario GetByIdVeterinario(int id);
        Veterinario GetByCPFVeterinario(string termo);
        ICollection<Veterinario> GetByNomeVeterinario(string nome);
        ICollection<HorariosDto> CarregarHorarios(string dia, string veterinarioId);
        int QtdAgendamento(string data, string horario);
    }
}