using Equinox.Domain.Commands.Movimento;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Equinox.Domain.CommandHandlers
{
    public class MovimentoCommandHandler: CommandHandler,
        IRequestHandler<RegisterNewMovimentoCommand, bool>
    {

        private readonly IMovimentoRepository _movimentoRepository;
        private readonly IMediatorHandler Bus;
    
        public MovimentoCommandHandler(IMovimentoRepository movimentoRepository, IUnitOfWork uow, IMediatorHandler bus,
                                     INotificationHandler<DomainNotification> notifications): base(uow, bus, notifications)
        {
             _movimentoRepository = movimentoRepository;
             Bus = bus;
        }
    
        public Task<bool> Handle(RegisterNewMovimentoCommand  message, CancellationToken cancellationToken)
        {
              if (!message.IsValid())
              {
                    NotifyValidationErrors(message);
                    return Task.FromResult(false);
              }
              var usuario =  new Movimento(message.Id, message.UsuarioId, message.Evento,
                                           message.BancoDestino, message.AgenciaDestino, message.ContaDestino,
                                           message.BancoOrigem, message.AgenciaOrigem,message.CpfOrigem,message.Valor,
                                           System.DateTime.Now, null);
              _movimentoRepository.Add(usuario);
              Commit();
              return Task.FromResult(true);
         }
      
        public void Dispose()
        {
                _movimentoRepository.Dispose();
        }

    }
}
