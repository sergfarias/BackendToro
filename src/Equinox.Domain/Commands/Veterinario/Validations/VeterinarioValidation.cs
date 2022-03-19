using System;
using Equinox.Domain.Commands.Veterinario;
using FluentValidation;

namespace Equinox.Domain.Commands.Veterinario.Validations
{
    public abstract class VeterinarioValidation<T> : AbstractValidator<T> where T : VeterinarioCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }

        //protected void ValidateBirthDate()
        //{
        //    RuleFor(c => c.DataContracao)
        //        .NotEmpty()
        //        .Must(HaveMinimumAge)
        //        .WithMessage("The customer must have 18 years or more");
        //}

        //protected void ValidateEmail()
        //{
        //    RuleFor(c => c)
        //        .NotEmpty()
        //        .EmailAddress();
        //}

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(0);
        }

        protected static bool HaveMinimumAge(DateTime? birthDate)
        {
            return birthDate <= DateTime.Now.AddYears(-18);
        }
    }
}