using AutoMapper;
using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands.Atendimento;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Equinox.Application.Services
{
    public class AtendimentoAppService : IAtendimentoAppService
    {
        private readonly IMapper _mapper;
        private readonly IAtendimentoRepository _atendimentoRepository;
        private readonly IMediatorHandler _mediator;

        public AtendimentoAppService(IMapper mapper,
                                  IAtendimentoRepository atendimentoRepository,
                                  IMediatorHandler mediator
            )
        {
            _mapper = mapper;
            _atendimentoRepository = atendimentoRepository;
            _mediator = mediator;
        }

        public void Register(AtendimentoViewModel atendimentoViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewAtendimentoCommand>(atendimentoViewModel);
            _mediator.SendCommand(registerCommand);
        }

        public ICollection<AgendamentoGridViewModel> CarregarAgendamentos(string data)
        {
            return _mapper.Map<ICollection<AgendamentoGridViewModel>>(_atendimentoRepository.CarregarAgendamentos(data));
        }

        public ICollection<AtendimentoGridViewModel> CarregarAtendimentos(string data)
        {
            return _mapper.Map<ICollection<AtendimentoGridViewModel>>(_atendimentoRepository.CarregarAtendimentos(data));
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
