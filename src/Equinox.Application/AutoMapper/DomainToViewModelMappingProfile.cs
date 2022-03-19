using AutoMapper;
using Equinox.Application.ViewModels;
using Equinox.Domain.Dto;
using Equinox.Domain.Models;
using System.Collections.Generic;

namespace Equinox.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<ClienteAnimalDto, ClienteAnimalViewModel>();
            CreateMap<ClienteAnimal, ClienteAnimalViewModel>();
            CreateMap<ClienteContatoDto, ClienteContatoViewModel>();
            CreateMap<HorariosDto, HorariosViewModel>();
            CreateMap<Veterinario, VeterinarioViewModel>();
            CreateMap<VeterinarioGrade, HorariosViewModel>();
            CreateMap<AgendamentoGridDto, AgendamentoGridViewModel>();
            CreateMap<AtendimentoGridDto, AtendimentoGridViewModel>();
        }
    }
}
