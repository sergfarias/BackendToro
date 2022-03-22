using Equinox.Application.Interfaces;
using Equinox.Application.Services;
using Equinox.Domain.CommandHandlers;
using Equinox.Domain.Commands.Movimento;
using Equinox.Domain.Commands.Usuario;
using Equinox.Domain.Commands.UsuarioAtivo;
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
            services.AddScoped<IMovimentoAppService, MovimentoAppService>();
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();
            services.AddScoped<IUsuarioAtivoAppService, UsuarioAtivoAppService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
           
            // Domain - Commands
            services.AddScoped<IRequestHandler<RegisterNewMovimentoCommand, bool>, MovimentoCommandHandler>();
            services.AddScoped<IRequestHandler<RegisterNewUsuarioCommand, bool>, UsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateUsuarioCommand, bool>, UsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<RegisterNewUsuarioAtivoCommand, bool>, UsuarioAtivoCommandHandler>();
            // Infra - Data
            services.AddScoped<IMovimentoRepository, MovimentoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioAtivoRepository, UsuarioAtivoRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<EquinoxContext>();

            // Infra - Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            services.AddScoped<EventStoreSqlContext>();
        
        }
    }
}