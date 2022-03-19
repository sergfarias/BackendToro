﻿using System;

namespace Equinox.Domain.Commands.Veterinario
{
    public class RemoveVeterinarioCommand : VeterinarioCommand
    {
        public RemoveVeterinarioCommand(int id)
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