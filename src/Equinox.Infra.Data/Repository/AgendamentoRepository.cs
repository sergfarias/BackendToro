using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Equinox.Infra.Data.Context;
using System.Linq;
using Equinox.Domain.Dto;
using Microsoft.EntityFrameworkCore;

namespace Equinox.Infra.Data.Repository
{
    public class AgendamentoRepository : Repository<Agendamento>, IAgendamentoRepository
    {
        protected new readonly EquinoxContext Db;

        public AgendamentoRepository(EquinoxContext context):base(context)
        {
            Db = context;
        }

    }
}
