using Equinox.Domain.Dto;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Equinox.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Equinox.Infra.Data.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        protected new readonly EquinoxContext Db;

        public UsuarioRepository(EquinoxContext context):base(context)
        {
            Db = context;
        }

        public Usuario GetByIdUsuario(int id)
        {
            return DbSet.Find(id);
        }

        public Usuario GetByUsuario(string cpf)
        {
            return DbSet.Where(c=> c.Cpf.Contains(cpf)).FirstOrDefault() ;
        }

        public Usuario GetByUsuario(string cpf, string senha)
        {
            return DbSet.Where(c => c.Cpf == cpf && c.Senha==senha ).FirstOrDefault();
        }

        public ICollection<Usuario> GetByCodigoCliente(string codigo)
        {
            int.TryParse(codigo, out int ID);

            var usuarios = from usuario in Db.Usuario
                           where usuario.Id == ID || usuario.Cpf == codigo
                           select usuario;

            return usuarios.ToList();
        }

        public IEnumerable<PosicaoDto> GetByPosicao(string cpf)
        {
            var query = (from usuario in Db.Usuario
                         from usuarioAtivo in Db.UsuarioAtivo.Where(x => x.UsuarioId == usuario.Id)
                         from ativo in Db.Ativo.Where(x => x.Id == usuarioAtivo.AtivoId)
                         where usuario.Cpf == cpf
                         select new PosicaoDto
                         {
                             symbol = ativo.Sigla,
                             amount = usuarioAtivo.Quantidade,
                             currentPrice = ativo.Valor
                         });
            return query;
        }

        public UsuarioPosicaoDto GetByUsuarioPosicao(string cpf)
        {
            var posicao = GetByPosicao(cpf);
            UsuarioPosicaoDto usuarioPosicao = new UsuarioPosicaoDto();
            usuarioPosicao.positions = posicao;

            var usuario = GetByUsuario(cpf);
            usuarioPosicao.checkingAccountAmount = usuario.Saldo;

            decimal consolidado = 0;
            foreach (var x in posicao)
            {
                consolidado += x.currentPrice * x.amount;
            }

            usuarioPosicao.consolidated = consolidado + usuario.Saldo;
            return usuarioPosicao;
        }

    }
}
