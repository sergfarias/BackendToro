using System;
namespace Equinox.Domain.Commands.Usuario
{
    public class UpdateUsuarioCommand : UsuarioCommand
    {
        public UpdateUsuarioCommand(
        int id,
        string codConta,
        string cpf,
        string nome,
        string email,
        decimal saldo,
        DateTime? dataCadastro
        )
        {
            Id = id;
            CodConta = codConta;
            Cpf = cpf;
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
            Saldo = saldo;
         }

        public override bool IsValid()
        {
            //ValidationResult = new RegisterNewClienteCommandValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}