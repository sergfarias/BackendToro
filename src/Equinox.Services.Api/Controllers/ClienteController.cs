using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Equinox.Services.Api.Controllers
{
    //[Authorize]
    [Route("api/")]
    public class ClienteController : ApiController
    {
        private readonly IClienteAppService _clienteAppService;

        public ClienteController(
            IClienteAppService clienteAppService,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator): base(notifications, mediator)
        {
            _clienteAppService = clienteAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Cliente/ClienteId")]
        public ClienteViewModel GetByIdCliente(int idCliente)
        {
            return _clienteAppService.GetByIdCliente(idCliente);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("pesquisa/cliente")]
        public ClienteViewModel GetByCPFCliente(string Termo)
        {
            return _clienteAppService.GetByCPFCliente(Termo);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("pesquisa/tipocontato")]
        public dynamic RecuperarDropDownTipoContato()
        {
            return _clienteAppService.RecuperarDropDownTipoContato();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("pesquisa/tipoanimal")]
        public dynamic RecuperarDropDownTipoAnimal()
        {
            return _clienteAppService.RecuperarDropDownTipoAnimal();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("pesquisa/clienteanimalgrid")]
        public IEnumerable<ClienteAnimalViewModel> GetByClienteAnimal(string Termo)
        {
            return _clienteAppService.GetByClienteAnimal(Termo);
        }

        [HttpGet]
        [Route("pesquisa/clientecontato")]
        public IEnumerable<ClienteContatoViewModel> GetByClienteContato(string Termo)
        {
            return _clienteAppService.GetByClienteContato(Termo);
        }

        [HttpPost]
        [Route("cadastro/cliente")]
        public IActionResult Post([FromBody] ClienteViewModel cliente)
        {
            var cli = _clienteAppService.GetByCPFClienteAsNoTracking(cliente.cpf);
            if (cli != null) cliente.id = cli.id;

            if (!_clienteAppService.ValidaCPF(cliente.cpf))
            {
                NotifyError("Cliente", "Rollback executado, pois o CPF é inválido.");
                return Response(this.Notifications);
            }

            if (cliente.id > 0)
            {
                var animalCadastrado = _clienteAppService.GetByClienteAnimal(cliente.cpf);
                foreach (var x in cliente.animais)
                {
                    bool cadastrado = false;
                    foreach (var y in animalCadastrado)
                    {
                        if (x.id == y.id)
                        {
                            cadastrado = true;
                        }
                    }
                    if (cadastrado) { x.id = 0; }
                }

                _clienteAppService.Updated(cliente);
            }
            else
            {
                cliente.dataCadastro = System.DateTime.Now;
                foreach (var x in cliente.animais)
                {
                    x.dataCadastro = System.DateTime.Now;
                    x.id = 0;
                }
                _clienteAppService.Register(cliente);
            }
            return Response(this.Notifications);
        }

        [HttpGet]
        [Route("pesquisa/codigocliente")]
        public ICollection<ClienteViewModel> GetByCodigo([FromQuery] string codigo)
        {
            return _clienteAppService.GetByCodigoCliente(codigo);
        }

        [HttpGet]
        [Route("pesquisa/termocliente")]
        public ICollection<ClienteViewModel> GetByTermo([FromQuery] string termo, string campo)
        {
            return _clienteAppService.GetByTermoCliente(termo, campo);
        }

    }
}
