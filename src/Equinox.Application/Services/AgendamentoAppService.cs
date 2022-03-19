using AutoMapper;
using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands.Agendamento;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using System;
using System.Collections.Generic;

namespace Equinox.Application.Services
{
    public class AgendamentoAppService : IAgendamentoAppService
    {
        private readonly IMapper _mapper;
        private readonly IAgendamentoRepository _agendamentoRepository;
        private readonly IMediatorHandler _mediator;

        public AgendamentoAppService(IMapper mapper,
                                  IAgendamentoRepository agendamentoRepository,
                                  IMediatorHandler mediator
            )
        {
            _mapper = mapper;
            _agendamentoRepository = agendamentoRepository;
            _mediator = mediator;
        }

        public void Register(AgendamentoViewModel agendamentoViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewAgendamentoCommand>(agendamentoViewModel);
            _mediator.SendCommand(registerCommand);
        }

    public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
