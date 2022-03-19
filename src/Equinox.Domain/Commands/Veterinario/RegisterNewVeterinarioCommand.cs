using System;
using System.Collections.Generic;
using Equinox.Domain.Commands.Veterinario.Validations;
using Equinox.Domain.Models;

namespace Equinox.Domain.Commands.Veterinario
{
    public class RegisterNewVeterinarioCommand : VeterinarioCommand
    {
        public RegisterNewVeterinarioCommand(
        int id,
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
            //ValidationResult = new RegisterNewClienteCommandValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}