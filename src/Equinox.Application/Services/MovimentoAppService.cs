using AutoMapper;
using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands.Movimento;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Interfaces;
using System;

namespace Equinox.Application.Services
{
    public class MovimentoAppService : IMovimentoAppService
    {
        private readonly IMapper _mapper;
        private readonly IMovimentoRepository _movimentoRepository;
        private readonly IMediatorHandler _mediator;

        public MovimentoAppService(IMapper mapper,
                                  IMovimentoRepository movimentoRepository,
                                  IMediatorHandler mediator
            )
        {
            _mapper = mapper;
            _movimentoRepository = movimentoRepository;
            _mediator = mediator;
        }
        public void Register(MovimentoViewModel movimentoViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewMovimentoCommand>(movimentoViewModel);
            _mediator.SendCommand(registerCommand);
        }

        public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
}
