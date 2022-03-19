using AutoMapper;
using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands.Cliente;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using System;
using System.Collections.Generic;

namespace Equinox.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMediatorHandler _mediator;

        public ClienteAppService(IMapper mapper,
                                  IClienteRepository clienteRepository,
                                  IMediatorHandler mediator//,
            )
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
            _mediator = mediator;
        }

        public ClienteViewModel GetByIdCliente(int id)
        {
            return _mapper.Map<ClienteViewModel>(_clienteRepository.GetByIdCliente(id));
        }


        public ClienteAnimalViewModel GetByAnimalAsNoTracking(int clienteId, int animalId)
        {
            return _mapper.Map<ClienteAnimalViewModel>(_clienteRepository.GetByAnimalAsNoTracking(clienteId, animalId));
        }

        

        public ClienteViewModel GetByCPFCliente(string termo)
        {
            return _mapper.Map<ClienteViewModel>(_clienteRepository.GetByCPFCliente(termo));
        }

        public ClienteViewModel GetByCPFClienteAsNoTracking(string termo)
        {
            return _mapper.Map<ClienteViewModel>(_clienteRepository.GetByCPFClienteAsNoTracking(termo));
        }

        public dynamic RecuperarDropDownTipoContato()
        {
            return _clienteRepository.RecuperarDropDownTipoContato(); 
        }

        public dynamic RecuperarDropDownTipoAnimal()
        {
            return TipoAnimal.ObterTodos(); 
        }

        public IEnumerable<ClienteAnimalViewModel> GetByClienteAnimal(string termo)
        {
            var testee = _clienteRepository.GetByClienteAnimal(termo);
            var teste = _mapper.Map<IEnumerable<ClienteAnimalViewModel>>(testee);
            return teste;
        }

        public IEnumerable<ClienteContatoViewModel> GetByClienteContato(string termo)
        {
            var testee = _clienteRepository.GetByClienteContato(termo);
            var teste = _mapper.Map<IEnumerable<ClienteContatoViewModel>>(testee);
            return teste;
        }

        public void Register(ClienteViewModel clienteViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewClienteCommand>(clienteViewModel);
            _mediator.SendCommand(registerCommand);
        }

        public void Updated(ClienteViewModel clienteViewModel)
        {
            var updateCommand = _mapper.Map<UpdateClienteCommand>(clienteViewModel);
            _mediator.SendCommand(updateCommand);
        }

        public ICollection<ClienteViewModel> GetByCodigoCliente(string codigo)
        {
            return _mapper.Map<ICollection<ClienteViewModel>>(_clienteRepository.GetByCodigoCliente(codigo));
        }

        public ICollection<ClienteViewModel> GetByTermoCliente(string termo, string campo)
        {
            return _mapper.Map<ICollection<ClienteViewModel>>(_clienteRepository.GetByTermoCliente(termo, campo));
        }


        public bool ValidaCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;

            return true;
        }

    public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
