namespace Equinox.Domain.Commands.Veterinario.Validations
{
    public class UpdateVeterinarioCommandValidation : VeterinarioValidation<UpdateVeterinarioCommand>
    {
        public UpdateVeterinarioCommandValidation()
        {
            ValidateId();
            ValidateName();
            //ValidateBirthDate();
            //ValidateEmail();
        }
    }
}