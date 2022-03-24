using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpGet]
        [AllowAnonymous]
        [Route("pesquisa/trends")]
        public IEnumerable<TrendsViewModel> GetByTrends()
        {
            var x = _usuarioAppService.GetByTrends();
            return x;
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
        public IActionResult Post([FromBody] ComprarAtivoViewModel comprarAtivo)
        {
            UsuarioAtivoViewModel usuarioAtivo = new UsuarioAtivoViewModel();
            usuarioAtivo.Quantidade = comprarAtivo.Quantidade;
            usuarioAtivo.UsuarioId = comprarAtivo.UsuarioId;
            string sigla = comprarAtivo.Sigla;
            var ativo = _usuarioAtivoAppService.GetByAtivo(sigla);
            usuarioAtivo.AtivoId = ativo.id;
            _usuarioAtivoAppService.Register(usuarioAtivo);

            var usuario = _usuarioAppService.GetByUsuario(usuarioAtivo.UsuarioId);
            usuario.saldo -= (System.Convert.ToDecimal(ativo.Valor) * comprarAtivo.Quantidade);
            _usuarioAppService.Update(usuario);

            return Response(this.Notifications);
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("cadastro/movimento")]
        public IActionResult Post([FromBody] DepositoViewModel deposito)
        {
            MovimentoViewModel movimento = new();
            var usuario = _usuarioAppService.GetByUsuario(deposito.usuarioId);
            if (usuario == null)
            {
                NotifyError("Usuário", "Rollback executado, pois o usuário não foi encontrado.");
                return Response(this.Notifications);
            }

            movimento.amount = System.Convert.ToDecimal(deposito.valor);
            movimento.evento = "TRANSFER";
            movimento.usuarioId = deposito.usuarioId;
            movimento.origin = new MovimentoOriginViewModel
            {
                bank = deposito.bancoOrigem,
                branch = deposito.agenciaOrigem,
                cpf = usuario.cpf
            };
            movimento.target = new MovimentoTargetViewModel
            {
                bank = "352",
                branch = "0001",
                account = usuario.codConta.ToString()
            };

            _movimentoAppService.Register(movimento);
            usuario.saldo += movimento.amount; 
            _usuarioAppService.Update(usuario);
            return Response(this.Notifications);
        }

    }
}
