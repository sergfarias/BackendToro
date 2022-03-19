using System;
using System.Collections.Generic;
using Equinox.Domain.Commands.Veterinario.Validations;
using Equinox.Domain.Models;

namespace Equinox.Domain.Commands.Veterinario
{
    public class UpdateVeterinarioCommand : VeterinarioCommand
    {
        public UpdateVeterinarioCommand(int id,
        string nome,
        DateTime? dataContratacao,
        string cpf,
        bool geriatra,
        DateTime? dataCadastro
        )
        {
            Id = id;
            Nome = nome;
            DataContratacao = dataContratacao;
            Cpf = cpf;
            Geriatra = geriatra;
            DataCadastro = dataCadastro;
        }

        public override bool IsValid()
        {
            //ValidationResult = new UpdateCustomerCommandValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}