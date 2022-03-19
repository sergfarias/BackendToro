using System;

namespace Equinox.Domain.Commands.Agendamento
{
    public class RegisterNewAgendamentoCommand : AgendamentoCommand
    {
        public RegisterNewAgendamentoCommand(
         int id,
        int clienteId,
        int animalId,
        int veterinarioId,
        string horario,
        string dataConsulta,
        DateTime? dataCadastro
        )
        {
            Id = id;
            ClienteId = clienteId;
            AnimalId = animalId;
            VeterinarioId = veterinarioId;
            Horario = horario;
            DataConsulta = dataConsulta;
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