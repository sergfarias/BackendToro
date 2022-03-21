using Equinox.Domain.Models;
namespace Equinox.Domain.Commands.UsuarioAtivo
{
    public class RegisterNewUsuarioAtivoCommand : UsuarioAtivoCommand
    {
        public RegisterNewUsuarioAtivoCommand(
        int id,
        int usuarioId,
        int ativoId,
        int quantidade,
        Models.Usuario usuario, 
        Ativo ativo
        )
        {
            Id = id;
            UsuarioId = usuarioId;
            AtivoId = ativoId;
            Quantidade = quantidade;
            Usuario = usuario;
            Ativo = ativo;
         }

        public override bool IsValid()
        {
            //ValidationResult = new RegisterNewClienteCommandValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}