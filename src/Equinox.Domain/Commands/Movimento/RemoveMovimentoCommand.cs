namespace Equinox.Domain.Commands.Movimento
{
    public class RemoveMovimentoCommand : MovimentoCommand
    {
        public RemoveMovimentoCommand(int id)
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