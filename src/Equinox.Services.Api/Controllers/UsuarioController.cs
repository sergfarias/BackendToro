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
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioAppService _usuarioAppService;
        private readonly IUsuarioAtivoAppService _usuarioAtivoAppService;
        private readonly IMovimentoAppService _movimentoAppService;

        public UsuarioController(
            IUsuarioAppService usuarioAppService,
            IUsuarioAtivoAppService usuarioAtivoAppService,
            IMovimentoAppService movimentoAppService,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator): base(notifications, mediator)
        {
            _usuarioAppService = usuarioAppService;
            _usuarioAtivoAppService = usuarioAtivoAppService;
            _movimentoAppService = movimentoAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("pesquisa/usuario")]
        public UsuarioViewModel GetByUsuario(string cpf, string senha)
        {
            return _usuarioAppService.GetByUsuario(cpf, senha);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("pesquisa/usuarioposicao")]
        public UsuarioPosicaoViewModel GetByUsuarioPosicao(string cpf)
        {
            return _usuarioAppService.GetByUsuarioPosicao(cpf);
        }

        [HttpPost]
        [Route("cadastro/usuario")]
        public IActionResult Post([FromBody] UsuarioViewModel usuario)
        {
            var usuarioExiste = _usuarioAppService.GetByUsuario(usuario.cpf);
            if (usuarioExiste != null)
            {
                NotifyError("Usuário", "Rollback executado, pois o CPF já cadastrado.");
                return Response(this.Notifications);
            }

            if (!_usuarioAppService.ValidaCPF(usuario.cpf))
            {
                NotifyError("Usuário", "Rollback executado, pois o CPF é inválido.");
                return Response(this.Notifications);
            }
            
            usuario.dataCadastro = System.DateTime.Now;
            _usuarioAppService.Register(usuario);
            return Response(this.Notifications);
        }

        [HttpPost]
        [Route("cadastro/usuarioativo")]
        public IActionResult Post([FromBody] UsuarioAtivoViewModel usuarioAtivo)
        {
            //var usuarioExiste = _usuarioAppService.GetByUsuario(usuario.cpf);
            //if (usuarioExiste != null)
            //{
            //    NotifyError("Usuário", "Rollback executado, pois o CPF já cadastrado.");
            //    return Response(this.Notifications);
            //}

            //if (!_usuarioAppService.ValidaCPF(usuario.cpf))
            //{
            //    NotifyError("Usuário", "Rollback executado, pois o CPF é inválido.");
            //    return Response(this.Notifications);
            //}

            //usuarioAtivo.dataCadastro = System.DateTime.Now;
            _usuarioAtivoAppService.Register(usuarioAtivo);
            return Response(this.Notifications);
        }


        [HttpPost]
        [Route("cadastro/movimento")]
        public IActionResult Post([FromBody] MovimentoViewModel movimento)
        {
            //var usuarioExiste = _usuarioAppService.GetByUsuario(usuario.cpf);
            //if (usuarioExiste != null)
            //{
            //    NotifyError("Usuário", "Rollback executado, pois o CPF já cadastrado.");
            //    return Response(this.Notifications);
            //}

            //if (!_usuarioAppService.ValidaCPF(usuario.cpf))
            //{
            //    NotifyError("Usuário", "Rollback executado, pois o CPF é inválido.");
            //    return Response(this.Notifications);
            //}

            _movimentoAppService.Register(movimento);
            return Response(this.Notifications);
        }

    }
}
