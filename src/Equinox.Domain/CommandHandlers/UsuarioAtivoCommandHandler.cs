using Equinox.Domain.Commands.UsuarioAtivo;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Equinox.Domain.CommandHandlers
{
    public class UsuarioAtivoCommandHandler: CommandHandler,
        IRequestHandler<RegisterNewUsuarioAtivoCommand, bool>
    {

        private readonly IUsuarioAtivoRepository _usuarioAtivoRepository;
        private readonly IMediatorHandler Bus;
    
        public UsuarioAtivoCommandHandler(IUsuarioAtivoRepository usuarioAtivoRepository, IUnitOfWork uow, IMediatorHandler bus,
                                     INotificationHandler<DomainNotification> notifications): base(uow, bus, notifications)
        {
             _usuarioAtivoRepository = usuarioAtivoRepository;
             Bus = bus;
        }
    
        public Task<bool> Handle(RegisterNewUsuarioAtivoCommand  message, CancellationToken cancellationToken)
        {
              if (!message.IsValid())
              {
                    NotifyValidationErrors(message);
                    return Task.FromResult(false);
              }

              var usuario =  new UsuarioAtivo(message.Id, message.AtivoId, message.UsuarioId, message.Quantidade,
                                              null, null, DateTime.Now);
              _usuarioAtivoRepository.Add(usuario);
              Commit();
              return Task.FromResult(true);
         }
      
        public void Dispose()
        {
                _usuarioAtivoRepository.Dispose();
        }

    }
}
