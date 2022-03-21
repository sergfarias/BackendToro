using AutoMapper;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands.Movimento;
using Equinox.Domain.Commands.Usuario;
using Equinox.Domain.Commands.UsuarioAtivo;
using Equinox.Domain.Models;
using System;
using System.Collections.Generic;

namespace Equinox.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {

            #region Movimento
            CreateMap<MovimentoViewModel, RegisterNewMovimentoCommand>()
                .ConstructUsing(c => new RegisterNewMovimentoCommand(0, c.usuarioId, c.evento, 
                                                                     c.target.bank, c.target.branch, c.target.account, 
                                                                     c.origin.bank, c.origin.branch, c.origin.cpf,c.amount, null, null));
            #endregion

            #region Usuario
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<UsuarioViewModel, RegisterNewUsuarioCommand>();
            CreateMap<UsuarioAtivoViewModel, RegisterNewUsuarioAtivoCommand>();
            CreateMap<AtivoViewModel, Ativo>();
            #endregion

        }
    }
}
