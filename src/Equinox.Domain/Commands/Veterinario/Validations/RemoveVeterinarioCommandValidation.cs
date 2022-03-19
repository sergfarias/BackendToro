namespace Equinox.Domain.Commands.Veterinario.Validations
{
    public class RemoveVeterinarioCommandValidation : VeterinarioValidation<RemoveVeterinarioCommand>
    {
        public RemoveVeterinarioCommandValidation()
        {
            ValidateId();
        }
    }
}