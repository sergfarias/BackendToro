using MediatR;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using System.Threading;
using System.Threading.Tasks;
using Equinox.Domain.Commands.Usuario;
using System;

namespace Equinox.Domain.CommandHandlers
{
    public class UsuarioCommandHandler: CommandHandler,
        IRequestHandler<RegisterNewUsuarioCommand, bool>
    {

        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMediatorHandler Bus;
    
        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository, IUnitOfWork uow, IMediatorHandler bus,
                                     INotificationHandler<DomainNotification> notifications): base(uow, bus, notifications)
        {
             _usuarioRepository = usuarioRepository;
             Bus = bus;
        }
    
        public Task<bool> Handle(RegisterNewUsuarioCommand  message, CancellationToken cancellationToken)
        {
              if (!message.IsValid())
              {
                    NotifyValidationErrors(message);
                    return Task.FromResult(false);
              }

              string data = message.DataCadastro.Value.ToString("yyyy-MM-dd HH:mm:ss"); 

              var usuario =  new Usuario(message.Id, message.CodConta, message.Nome,
                                           message.Cpf, message.Email, message.Senha, message.Saldo, Convert.ToDateTime(data), null);
              _usuarioRepository.Add(usuario);
              Commit();
              return Task.FromResult(true);
         }
      
        public void Dispose()
        {
                _usuarioRepository.Dispose();
        }

    }
}
