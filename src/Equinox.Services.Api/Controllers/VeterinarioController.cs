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
    public class VeterinarioController : ApiController
    {
        private readonly IVeterinarioAppService _veterinarioAppService;

        public VeterinarioController(
            IVeterinarioAppService veterinarioAppService,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator): base(notifications, mediator)
        {
            _veterinarioAppService = veterinarioAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Veterinario/VeterinarioId")]
        public VeterinarioViewModel GetByIdVeterinario(int idVeterinario)
        {
            return _veterinarioAppService.GetByIdVeterinario(idVeterinario);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("pesquisa/Veterinario")]
        public VeterinarioViewModel GetByCPFVeterinario(string Termo)
        {
            return _veterinarioAppService.GetByCPFVeterinario(Termo);
        }

        [HttpPost]
        [Route("cadastro/Veterinario")]
        public IActionResult Post([FromBody] VeterinarioViewModel Veterinario)
        {
            if (Veterinario.Id > 0)
                _veterinarioAppService.Updated(Veterinario);
            else
            {
                Veterinario.DataCadastro = System.DateTime.Now;
                _veterinarioAppService.Register(Veterinario);
            }
            return Response(this.Notifications);
        }

        [HttpPut]
        [Route("atualiza/Veterinario")]
        public IActionResult Put([FromBody] VeterinarioViewModel Veterinario)
        {
            _veterinarioAppService.Updated(Veterinario);
            return Response(this.Notifications); 
        }

        [HttpGet]
        [Route("pesquisa/veterinarionome")]
        public ICollection<VeterinarioViewModel> GetByNome([FromQuery] string nome)
        {
            return _veterinarioAppService.GetByNomeVeterinario(nome);
        }

        [HttpGet]
        [Route("pesquisa/carregarhorarios")]
        public ICollection<HorariosViewModel> CarregarHorarios([FromQuery] string dia, string veterinarioId)
        {
            return _veterinarioAppService.CarregarHorarios(dia, veterinarioId);
        }
    }
}
