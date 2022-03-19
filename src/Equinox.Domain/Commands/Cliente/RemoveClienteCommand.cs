using System;

namespace Equinox.Domain.Commands.Cliente
{
    public class RemoveClienteCommand : ClienteCommand
    {
        public RemoveClienteCommand(int id)
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            //ValidationResult = new RemoveClienteCommandValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}