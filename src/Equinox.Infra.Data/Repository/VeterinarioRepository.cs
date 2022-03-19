using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Equinox.Infra.Data.Context;
using System.Linq;
using Equinox.Domain.Dto;

namespace Equinox.Infra.Data.Repository
{
    public class VeterinarioRepository : Repository<Veterinario>, IVeterinarioRepository
    {
        protected new readonly EquinoxContext Db;

        public VeterinarioRepository(EquinoxContext context):base(context)
        {
            Db = context;
        }

        public Veterinario GetByIdVeterinario(int id)
        {
            return DbSet.Find(id);
        }

        public Veterinario GetByCPFVeterinario(string termo)
        {
            return DbSet.Where(c=> c.Cpf.Contains(termo)).FirstOrDefault() ;
        }

        public ICollection<Veterinario> GetByNomeVeterinario(string nome)
        {
            nome = nome.Trim().ToUpper();
             var veterinarios = (from veterinario in Db.Veterinario
                                where veterinario.Nome.ToUpper().Trim().Contains(nome)
                                select veterinario).Take(100).ToList();
            return veterinarios;
        }

        public ICollection<HorariosDto> CarregarHorarios(string dia, string veterinarioId)
        {
            List<HorariosDto> horarios = new List<HorariosDto>();

            ICollection<HorariosDto> g;

            if (string.IsNullOrEmpty(veterinarioId) || (Convert.ToInt32(veterinarioId) == 0)) {
               
                    g = (from grade in Db.VeterinarioGrade
                         from veterinario in Db.Veterinario.Where(c => c.Id == grade.VeterinarioId)
                         where grade.DiaSemana.Equals(Convert.ToInt32(Convert.ToDateTime(dia).DayOfWeek))
                         select new HorariosDto
                         {
                             id = grade.Id,
                             veterinarioid = grade.VeterinarioId,
                             geriatra = veterinario.Geriatra,
                             veterinarionome = veterinario.Nome,
                             horini = grade.HorIni,
                             horfim = grade.HorFim,
                             intervalo = grade.Intervalo
                         }

                         ).ToList();
            }
            else
            {
                g = (from grade in Db.VeterinarioGrade
                     from veterinario in Db.Veterinario.Where(c => c.Id == grade.VeterinarioId)
                     where grade.DiaSemana.Equals(Convert.ToInt32(Convert.ToDateTime(dia).DayOfWeek))
                         && grade.VeterinarioId == Convert.ToInt32(veterinarioId) 
                         select new HorariosDto
                         {
                             id = grade.Id,
                             veterinarioid = grade.VeterinarioId,
                             geriatra = veterinario.Geriatra,
                             veterinarionome = veterinario.Nome,
                             horini = grade.HorIni,
                             horfim = grade.HorFim,
                             intervalo = grade.Intervalo
                         }
                         
                         ).ToList();

            }

            foreach (var x in g) {
                while (x.horini.AddMinutes(x.intervalo) <= x.horfim)
                {
                    var hora = x.horini.AddMinutes(x.intervalo).TimeOfDay.ToString();
                    if (!ExisteAgendamento(dia, hora, x.veterinarioid)) {
                        HorariosDto horario = new HorariosDto();
                        horario.id = x.id;
                        horario.veterinarioid = x.veterinarioid;
                        horario.geriatra = x.geriatra;
                        horario.veterinarionome = x.veterinarionome;
                        horario.horario = hora;
                        x.horini = x.horini.AddMinutes(x.intervalo);
                        horarios.Add(horario);
                    }
                    else
                    {
                        x.horini = x.horini.AddMinutes(x.intervalo);
                    }
                }
            }

           
            return horarios;

        }


        public bool ExisteAgendamento(string data, string horario, int veterinarioId)
        {
            var existe = Db.Agendamento.Any(c => (c.DataConsulta == data)
                               && (c.Horario == horario)
                               && (c.VeterinarioId == veterinarioId));      
            return existe;
        }

        public int QtdAgendamento(string data, string horario)
        {
            var qtd = Db.Agendamento.Count(c => (c.DataConsulta == data)
                               && (c.Horario == horario));
            return qtd;
        }

    }
}
