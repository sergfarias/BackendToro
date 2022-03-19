using System;

namespace Equinox.Domain.Commands.Atendimento
{
    public class RegisterNewAtendimentoCommand : AtendimentoCommand
    {
        public RegisterNewAtendimentoCommand(
         int id,
        int agendamentoId,
         string diagnostico,
        DateTime dataAtendimento,
        DateTime? dataCadastro
        )
        {
            Id = id;
            AgendamentoId = agendamentoId;
            Diagnostico = diagnostico;
            DataAtendimento = dataAtendimento;
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