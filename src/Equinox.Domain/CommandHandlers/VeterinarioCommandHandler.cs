using MediatR;
using Equinox.Domain.Commands.Veterinario;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Equinox.Domain.CommandHandlers
{
    public class VeterinarioCommandHandler: CommandHandler,
        IRequestHandler<RegisterNewVeterinarioCommand, bool>,
        IRequestHandler<UpdateVeterinarioCommand, bool>
    {

        private readonly IVeterinarioRepository _veterinarioRepository;
        private readonly IMediatorHandler Bus;
    
    
    public VeterinarioCommandHandler(IVeterinarioRepository veterinarioRepository, 
                                     IUnitOfWork uow, IMediatorHandler bus,
                                     INotificationHandler<DomainNotification> notifications): base(uow, bus, notifications)
    {
         _veterinarioRepository = veterinarioRepository;
         Bus = bus;
    }
    
    public Task<bool> Handle(RegisterNewVeterinarioCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            var veterinario =  new Veterinario(message.Id, message.Nome, 
                                       message.DataContratacao, message.Cpf, message.Geriatra, message.DataCadastro);
            _veterinarioRepository.Add(veterinario);
            Commit();

            return Task.FromResult(true);
        }

        public Task<bool> Handle(UpdateVeterinarioCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            var veterinario = new Veterinario(message.Id, message.Nome,
                                       message.DataContratacao, message.Cpf, message.Geriatra, message.DataCadastro);
            _veterinarioRepository.Update(veterinario);
            Commit();

            return Task.FromResult(true);

        }

        public void Dispose()
        {
            _veterinarioRepository.Dispose();
        }

    }
}
