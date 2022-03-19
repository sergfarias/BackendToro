using Equinox.Application.Interfaces;
using Equinox.Application.Services;
using Equinox.Domain.CommandHandlers;
using Equinox.Domain.Commands.Cliente;
using Equinox.Domain.Commands.Veterinario;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Events;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Interfaces;
using Equinox.Infra.CrossCutting.Bus;
using Equinox.Infra.Data.Context;
using Equinox.Infra.Data.EventSourcing;
using Equinox.Infra.Data.Repository;
using Equinox.Infra.Data.Repository.EventSourcing;
using Equinox.Infra.Data.UoW;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using Equinox.Domain.Commands.Agendamento;
using Equinox.Domain.Commands.Atendimento;

namespace Equinox.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //ASP .NET Authorization polices
            //services.AddSingleton<IAuthorizationHandler,ClaimsRequirementHandler>();

            // Application
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IVeterinarioAppService, VeterinarioAppService>();
            services.AddScoped<IAgendamentoAppService, AgendamentoAppService>();
            services.AddScoped<IAtendimentoAppService, AtendimentoAppService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
           
            // Domain - Commands
            services.AddScoped<IRequestHandler<RegisterNewClienteCommand, bool>, ClienteCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateClienteCommand, bool>, ClienteCommandHandler>();
            services.AddScoped<IRequestHandler<RegisterNewVeterinarioCommand, bool>, VeterinarioCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateVeterinarioCommand, bool>, VeterinarioCommandHandler>();
            services.AddScoped<IRequestHandler<RegisterNewAgendamentoCommand, bool>, AgendamentoCommandHandler>();
            services.AddScoped<IRequestHandler<RegisterNewAtendimentoCommand, bool>, AtendimentoCommandHandler>();

            // Infra - Data
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IVeterinarioRepository, VeterinarioRepository>();
            services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();
            services.AddScoped<IAtendimentoRepository, AtendimentoRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<EquinoxContext>();

            // Infra - Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            services.AddScoped<EventStoreSqlContext>();
        
        }
    }
}