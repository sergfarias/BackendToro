using Equinox.Domain.Dto;
using Equinox.Domain.Models;
using System.Collections.Generic;

namespace Equinox.Domain.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente GetByIdCliente(int id);
        Cliente GetByCPFCliente(string termo);
        IEnumerable<ClienteAnimalDto> GetByClienteAnimal(string Termo);
        IEnumerable<ClienteContatoDto> GetByClienteContato(string Termo);
        dynamic RecuperarDropDownTipoContato();
        dynamic RecuperarDropDownTipoAnimal();
        ICollection<Cliente> GetByTermoCliente(string termo, string campo = null);
        ICollection<Cliente> GetByCodigoCliente(string codigo);
        Cliente GetByCPFClienteAsNoTracking(string termo);
        ClienteAnimal GetByAnimalAsNoTracking(int clienteId, int animalId);
    }
}