using MediatR;
using Equinox.Domain.Commands.Agendamento;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Equinox.Domain.CommandHandlers
{
    public class AgendamentoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewAgendamentoCommand, bool>
    {
        private readonly IAgendamentoRepository _agendamentoRepository;
        private readonly IMediatorHandler Bus;
    
    public AgendamentoCommandHandler(IAgendamentoRepository agendamentoRepository, IUnitOfWork uow, IMediatorHandler bus,
                                 INotificationHandler<DomainNotification> notifications): base(uow, bus, notifications)
    {
         _agendamentoRepository = agendamentoRepository;
         Bus = bus;
    }
    
    public Task<bool> Handle(RegisterNewAgendamentoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }
            
            var agendamento =  new Agendamento(message.Id, message.ClienteId, message.AnimalId,
                                               message.VeterinarioId, message.Horario, message.DataConsulta,
                                               message.DataCadastro);
            _agendamentoRepository.Add(agendamento);
            Commit();
            return Task.FromResult(true);
        }

        public void Dispose()
        {
            _agendamentoRepository.Dispose();
        }

    }
}
