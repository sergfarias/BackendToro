using System;
namespace Equinox.Domain.Commands.Movimento
{
    public class RegisterNewMovimentoCommand : MovimentoCommand
    {
        public RegisterNewMovimentoCommand(
        int id,
        int usuarioId,
        string evento,
        string bancoDestino,
        string agenciaDestino,
        string contaDestino,
        string bancoOrigem,
        string agenciaOrigem,
        string cpfOrigem,
        decimal valor,
        DateTime? dataCadastro,
        Models.Usuario usuario)
        {
            Id = id;
            UsuarioId = usuarioId;
            Evento = evento;
            BancoDestino = bancoDestino;
            AgenciaDestino = agenciaDestino;
            ContaDestino = contaDestino;
            BancoOrigem = bancoOrigem;
            AgenciaOrigem = agenciaOrigem;
            CpfOrigem = cpfOrigem;
            Valor = valor;
            DataCadastro = dataCadastro;
            Usuario = usuario;
        }

        public override bool IsValid()
        {
            //ValidationResult = new RegisterNewClienteCommandValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}