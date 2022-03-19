using AutoMapper;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands.Agendamento;
using Equinox.Domain.Commands.Atendimento;
using Equinox.Domain.Commands.Cliente;
using Equinox.Domain.Commands.Veterinario;
using Equinox.Domain.Models;
using System.Collections.Generic;

namespace Equinox.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
          
            #region Cliente
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ClienteContatoViewModel, ClienteContato>()
                .ConstructUsing(c => new ClienteContato(c.id_contato,c.ds_contato, c.id_tipo_contato, c.id_cliente, null));
            CreateMap<ClienteAnimalViewModel, ClienteAnimal>();
            CreateMap<ClienteViewModel, RegisterNewClienteCommand>();
            CreateMap<ClienteViewModel, UpdateClienteCommand>();
            #endregion

            #region Veterinario
            CreateMap<VeterinarioViewModel, Veterinario>();
            CreateMap<VeterinarioViewModel, RegisterNewVeterinarioCommand>();
            CreateMap<VeterinarioViewModel, UpdateVeterinarioCommand>();
            #endregion

            #region Agendamento
            CreateMap<AgendamentoViewModel, RegisterNewAgendamentoCommand>();
            #endregion

            #region Atendimento
            CreateMap<AtendimentoViewModel, RegisterNewAtendimentoCommand>();
            #endregion

        }
    }
}
