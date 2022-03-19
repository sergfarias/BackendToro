using MediatR;
using Equinox.Domain.Commands.Cliente;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Equinox.Domain.CommandHandlers
{
    public class ClienteCommandHandler: CommandHandler,
        IRequestHandler<RegisterNewClienteCommand, bool>,
        IRequestHandler<UpdateClienteCommand, bool>
    {

        private readonly IClienteRepository _clienteRepository;
        private readonly IMediatorHandler Bus;
    
    public ClienteCommandHandler(IClienteRepository clienteRepository, IUnitOfWork uow, IMediatorHandler bus,
                                 INotificationHandler<DomainNotification> notifications): base(uow, bus, notifications)
    {
         _clienteRepository = clienteRepository;
         Bus = bus;
    }
    
    public Task<bool> Handle(RegisterNewClienteCommand  message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }
            
            var cliente =  new Cliente(message.Id, message.Nome, 
                                       message.DataCadastro, message.Cpf, message.Observacao, message.Contatos, message.Animais);
            _clienteRepository.Add(cliente);
            Commit();

            return Task.FromResult(true);

        }

        public Task<bool> Handle(UpdateClienteCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }
            
            var cliente = new Cliente(message.Id, message.Nome, 
                                       message.DataCadastro, message.Cpf, message.Observacao, message.Contatos, message.Animais);
            _clienteRepository.Update(cliente);
            Commit();

            return Task.FromResult(true);

        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }

    }
}
