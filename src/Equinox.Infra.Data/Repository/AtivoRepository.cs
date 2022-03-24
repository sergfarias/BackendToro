using Equinox.Domain.Dto;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Equinox.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Equinox.Infra.Data.Repository
{
    public class AtivoRepository : Repository<Ativo>, IAtivoRepository
    {
        protected new readonly EquinoxContext Db;

        public AtivoRepository(EquinoxContext context):base(context)
        {
            Db = context;
        }

        public Ativo GetByAtivo(int id)
        {
            return DbSet.Find(id);
        }

        public Ativo GetByAtivo(string sigla)
        {
            return DbSet.Where(c => c.Sigla == sigla).FirstOrDefault();
        }

    }
}
