using Equinox.Domain.Dto;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Equinox.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Equinox.Infra.Data.Repository
{
    public class UsuarioAtivoRepository : Repository<UsuarioAtivo>, IUsuarioAtivoRepository
    {
        protected new readonly EquinoxContext Db;

        public UsuarioAtivoRepository(EquinoxContext context):base(context)
        {
            Db = context;
        }

        public UsuarioAtivo GetByUsuarioAtivo(int id)
        {
            return DbSet.Find(id);
        }

    }
}
