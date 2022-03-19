using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Equinox.Services.Api.Controllers
{
    //[Authorize]
    [Route("api/")]
    public class AtendimentoController : ApiController
    {
        private readonly IAtendimentoAppService _atendimentoAppService;
      
        public AtendimentoController(
            IAtendimentoAppService atendimentoAppService,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator): base(notifications, mediator)
        {
            _atendimentoAppService = atendimentoAppService;
        }

        
        [HttpGet]
        [Route("pesquisa/carregaragendamentos")]
        public ICollection<AgendamentoGridViewModel> CarregarAgendamentos([FromQuery] string data)
        {
            return _atendimentoAppService.CarregarAgendamentos(data);
        }

        [HttpGet]
        [Route("pesquisa/carregaratendimentos")]
        public ICollection<AtendimentoGridViewModel> CarregarAtendimentos([FromQuery] string data)
        {
            return _atendimentoAppService.CarregarAtendimentos(data);
        }

        [HttpPost]
        [Route("cadastro/atendimento")]
        public IActionResult Post([FromBody] AtendimentoViewModel atendimento)
        {
            atendimento.dataCadastro = System.DateTime.Now;
            _atendimentoAppService.Register(atendimento);
            return Response(this.Notifications);
        }


    }
}
