using MediatR;
using Equinox.Domain.Commands.Atendimento;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Equinox.Domain.CommandHandlers
{
    public class AtendimentoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewAtendimentoCommand, bool>
    {
        private readonly IAtendimentoRepository _atendimentoRepository;
        private readonly IMediatorHandler Bus;
    
    public AtendimentoCommandHandler(IAtendimentoRepository atendimentoRepository, 
                                     IUnitOfWork uow, IMediatorHandler bus,
                                     INotificationHandler<DomainNotification> notifications): base(uow, bus, notifications)
    {
         _atendimentoRepository = atendimentoRepository;
         Bus = bus;
    }
    
    public Task<bool> Handle(RegisterNewAtendimentoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }
            
            var atendimento =  new Atendimento(message.Id, message.AgendamentoId, message.Diagnostico,
                                               message.DataAtendimento,
                                               message.DataCadastro);
            _atendimentoRepository.Add(atendimento);
            Commit();
            return Task.FromResult(true);
        }

        public void Dispose()
        {
            _atendimentoRepository.Dispose();
        }

    }
}
