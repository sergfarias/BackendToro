using AutoMapper;
using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands.UsuarioAtivo;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Interfaces;
using System;
namespace Equinox.Application.Services
{
    public class UsuarioAtivoAppService : IUsuarioAtivoAppService
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioAtivoRepository _usuarioAtivoRepository;
        private readonly IAtivoRepository _ativoRepository;
        private readonly IMediatorHandler _mediator;

        public UsuarioAtivoAppService(IMapper mapper,
                                  IUsuarioAtivoRepository usuarioAtivoRepository,
                                  IAtivoRepository ativoRepository,
                                  IMediatorHandler mediator
            )
        {
            _mapper = mapper;
            _usuarioAtivoRepository = usuarioAtivoRepository;
            _ativoRepository = ativoRepository;
            _mediator = mediator;
        }
        public void Register(UsuarioAtivoViewModel usuarioAtivoViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewUsuarioAtivoCommand>(usuarioAtivoViewModel);
            _mediator.SendCommand(registerCommand);
        }

        public AtivoViewModel GetByAtivo(string sigla)
        {
            var x = _ativoRepository.GetByAtivo(sigla);
            return _mapper.Map<AtivoViewModel>(x);
        }

        public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
}
