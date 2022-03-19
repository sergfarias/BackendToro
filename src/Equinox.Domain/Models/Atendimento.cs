using Equinox.Domain.Core.Models;
using System;

namespace Equinox.Domain.Models
{
    public class Atendimento : Entity<Atendimento> 
    {
       
        public int AgendamentoId { get; private set; }
        public string Diagnostico { get; private set; }
        public DateTime DataAtendimento { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public virtual Agendamento Agendamento { get; private set; }
       
        public Atendimento(int id, int agendamentoId,  string diagnostico,
                           DateTime dataAtendimento, DateTime? dataCadastro)
        {
            Id = id;
            AgendamentoId = agendamentoId;
            Diagnostico = diagnostico;
            DataAtendimento = dataAtendimento;
            DataCadastro = dataCadastro;
        }

        // Empty constructor for EF
        protected Atendimento() { }

        public override bool IsValid()
        {
            return true;
        }

    }
}