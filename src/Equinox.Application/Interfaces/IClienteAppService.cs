using Equinox.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Equinox.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ClienteViewModel GetByIdCliente(int id);
        ClienteViewModel GetByCPFCliente(string Termo);
        IEnumerable<ClienteAnimalViewModel> GetByClienteAnimal(string termo);
        IEnumerable<ClienteContatoViewModel> GetByClienteContato(string Termo);
        dynamic RecuperarDropDownTipoContato();
        dynamic RecuperarDropDownTipoAnimal();
        void Register(ClienteViewModel clienteViewModel);
        void Updated(ClienteViewModel clienteViewModel);
        ICollection<ClienteViewModel> GetByCodigoCliente(string codigo);
        ICollection<ClienteViewModel> GetByTermoCliente(string termo, string campo);
        bool ValidaCPF(string vrCPF);
        ClienteViewModel GetByCPFClienteAsNoTracking(string termo);
        ClienteAnimalViewModel GetByAnimalAsNoTracking(int clienteId, int animalId);
    }
}
