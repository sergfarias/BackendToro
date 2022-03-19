//using Equinox.Domain.Commands.Customer;

namespace Equinox.Domain.Commands.Veterinario.Validations
{
    public class RegisterNewVeterinarioCommandValidation : VeterinarioValidation<RegisterNewVeterinarioCommand>
    {
        public RegisterNewVeterinarioCommandValidation()
        {
            ValidateName();
            //ValidateBirthDate();
            //ValidateEmail();
        }
    }
}