using System;
using System.Collections.Generic;
using Equinox.Domain.Models;

namespace Equinox.Domain.Commands.Cliente
{
    public class UpdateClienteCommand : ClienteCommand
    {
        public UpdateClienteCommand(int id,
        string nome,
        DateTime? dataCadastro,
        string cpf,
        string observacao,
        ICollection<ClienteContato> contatos,
        ICollection<ClienteAnimal> animais
)
        {
            Id = id;
            Nome = nome;
            DataCadastro = dataCadastro;
            Cpf = cpf;
            Observacao = observacao;
            Contatos = contatos;
            Animais = animais;
        }

        public override bool IsValid()
        {
            //ValidationResult = new UpdateCustomerCommandValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}