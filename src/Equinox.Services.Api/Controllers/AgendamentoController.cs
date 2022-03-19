using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Equinox.Services.Api.Controllers
{
    //[Authorize]
    [Route("api/")]
    public class AgendamentoController : ApiController
    {
        private readonly IAgendamentoAppService _agendamentoAppService;
        private readonly IVeterinarioAppService _veterinarioAppService;
        private readonly IClienteAppService _clienteAppService;

        public AgendamentoController(
            IAgendamentoAppService agendamentoAppService,
            IVeterinarioAppService veterinarioAppService,
            IClienteAppService clienteAppService,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator): base(notifications, mediator)
        {
            _agendamentoAppService = agendamentoAppService;
            _veterinarioAppService = veterinarioAppService;
            _clienteAppService = clienteAppService;
        }

        [HttpPost]
        [Route("cadastro/agendamento")]
        public IActionResult Post([FromBody] AgendamentoViewModel agendamento)
        {
            //A cl�nica veterin�ria, tem a capacidade de atender at� 3 animais simult�neos
            var conta = _veterinarioAppService.QtdAgendamento(agendamento.dataConsulta, agendamento.horario);
            if (conta >= 3)
            {
                NotifyError("Agendamento", "Hor�rio indsponivel, pois  j� existem 3 atendimentos para est� data e hor�rio.");
                return Response(this.Notifications);
            }

            //Um animal idoso s� pode ser atendido por um veterin�rio com a especialidade em geriatria animal
            bool animalIdoso = false;
            var clienteAnimal = _clienteAppService.GetByAnimalAsNoTracking(agendamento.clienteid, agendamento.animalid);
            if ((clienteAnimal.tipoAnimalId == TipoAnimal.Gato.Id)|| (clienteAnimal.tipoAnimalId == TipoAnimal.Cao.Id))
            {
                if (clienteAnimal.idade > IdadeAnimalIdoso.CaoGato.Id) 
                { 
                     animalIdoso = true; 
                }
            } 
            else if (clienteAnimal.tipoAnimalId == TipoAnimal.Hamsters.Id)
            {
                if (clienteAnimal.idade > 3) { animalIdoso = true; }
            }

            var veterinario = _veterinarioAppService.GetByIdVeterinario(agendamento.veterinarioid);
            if (animalIdoso && !veterinario.Geriatra)
            {
                NotifyError("Agendamento", "Animal idoso, s� pode ser atendido por veterin�rio geriatrico.");
                return Response(this.Notifications);
            }

            agendamento.dataCadastro = System.DateTime.Now;
            _agendamentoAppService.Register(agendamento);
            return Response(this.Notifications);
        }

    }
}
