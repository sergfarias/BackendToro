using Equinox.Domain.Dto;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Equinox.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Equinox.Infra.Data.Repository
{
    public class AtendimentoRepository : Repository<Atendimento>, IAtendimentoRepository
    {
        protected new readonly EquinoxContext Db;

        public AtendimentoRepository(EquinoxContext context):base(context)
        {
            Db = context;
        }

        public ICollection<AgendamentoGridDto> CarregarAgendamentos(string data)
        {
            var agendamentos = (from agendamento in Db.Agendamento
                                from cliente in Db.Cliente.Where(c => c.Id == agendamento.ClienteId)
                                from animal in Db.ClienteAnimal.Where(c => c.Id == agendamento.AnimalId)
                                from tipoAnimal in Db.TipoAnimal.Where(c => c.Id == animal.TipoAnimalId)
                                from veterinario in Db.Veterinario.Where(c => c.Id == agendamento.VeterinarioId)
                                where agendamento.DataConsulta.Equals(data)
                                select new AgendamentoGridDto
                                {
           
                          id = agendamento.Id,
                                    dataConsulta = agendamento.DataConsulta,
                                    horario = agendamento.Horario,
                                    veterinarioId = agendamento.VeterinarioId,
                                    veterinarioNome = veterinario.Nome,
                                    clienteId = agendamento.ClienteId,
                                    clienteNome = cliente.Nome,
                                    animalId = agendamento.AnimalId,
                                    animalNome = animal.Nome,
                                    tipoAnimalId = tipoAnimal.Id,
                                    tipoAnimalNome = tipoAnimal.Nome
                                }

                  ).ToList();
           
            return agendamentos;

        }

        public ICollection<AtendimentoGridDto> CarregarAtendimentos(string data)
        {

            var datai = data + " 00:00:00";
            var dataf = data + " 23:59:00";
            var atendimentos = (from atendimento in Db.Atendimento
                                from agendamento in Db.Agendamento.Where(c => c.Id == atendimento.AgendamentoId)
                                from cliente in Db.Cliente.Where(c => c.Id == agendamento.ClienteId)
                                from animal in Db.ClienteAnimal.Where(c => c.Id == agendamento.AnimalId)
                                from tipoAnimal in Db.TipoAnimal.Where(c => c.Id == animal.TipoAnimalId)
                                from veterinario in Db.Veterinario.Where(c => c.Id == agendamento.VeterinarioId)
                                where  (atendimento.DataAtendimento >= Convert.ToDateTime(datai))
                                && (atendimento.DataAtendimento <= Convert.ToDateTime(dataf) )
                                select new AtendimentoGridDto
                                {
                                    id = atendimento.Id,
                                    dataConsulta = atendimento.DataAtendimento.ToString("dd/MM/yyyy"),
                                    horario = atendimento.DataAtendimento.ToString("HH:mm"),
                                    veterinarioId = agendamento.VeterinarioId,
                                    veterinarioNome = veterinario.Nome,
                                    clienteId = agendamento.ClienteId,
                                    clienteNome = cliente.Nome,
                                    animalId = agendamento.AnimalId,
                                    animalNome = animal.Nome,
                                    tipoAnimalId = tipoAnimal.Id,
                                    tipoAnimalNome = tipoAnimal.Nome
                                }

                  ).ToList();

            return atendimentos;

        }
    }
}
