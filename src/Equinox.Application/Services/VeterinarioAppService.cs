using AutoMapper;
using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands.Veterinario;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using System;
using System.Collections.Generic;

namespace Equinox.Application.Services
{
    public class VeterinarioAppService : IVeterinarioAppService
    {
        private readonly IMapper _mapper;
        private readonly IVeterinarioRepository _veterinarioRepository;
        private readonly IMediatorHandler _mediator;

        public VeterinarioAppService(IMapper mapper,
                                  IVeterinarioRepository veterinarioRepository,
                                  IMediatorHandler mediator
            )
        {
            _mapper = mapper;
            _veterinarioRepository = veterinarioRepository;
            _mediator = mediator;
        }

        public VeterinarioViewModel GetByIdVeterinario(int id)
        {
            return _mapper.Map<VeterinarioViewModel>(_veterinarioRepository.GetByIdVeterinario(id));
        }

        public VeterinarioViewModel GetByCPFVeterinario(string termo)
        {
            return _mapper.Map<VeterinarioViewModel>(_veterinarioRepository.GetByCPFVeterinario(termo));
        }

        public int QtdAgendamento(string data, string horario)
        {
            return _veterinarioRepository.QtdAgendamento(data, horario);
        }

        public void Register(VeterinarioViewModel veterinarioViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewVeterinarioCommand>(veterinarioViewModel);
            _mediator.SendCommand(registerCommand);
        }

        public void Updated(VeterinarioViewModel veterinarioViewModel)
        {
            var updateCommand = _mapper.Map<UpdateVeterinarioCommand>(veterinarioViewModel);
            _mediator.SendCommand(updateCommand);
        }

        public ICollection<VeterinarioViewModel> GetByNomeVeterinario(string nome)
        {
            return _mapper.Map<ICollection<VeterinarioViewModel>>(_veterinarioRepository.GetByNomeVeterinario(nome));
        }

        public ICollection<HorariosViewModel> CarregarHorarios(string dia, string veterinarioId)
        {
            return _mapper.Map<ICollection<HorariosViewModel>>(_veterinarioRepository.CarregarHorarios(dia, veterinarioId));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
