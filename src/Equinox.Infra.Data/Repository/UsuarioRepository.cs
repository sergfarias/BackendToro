using Equinox.Domain.Dto;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Equinox.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
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


        public IEnumerable<AtivoDto> GetByAtivo()
        {
            var dataFinal = DateTime.Now;
            var dataInicial =  dataFinal.AddDays(-6); 

            dataInicial = Convert.ToDateTime(dataInicial.ToString("yyyy-MM-dd"));
            dataFinal = Convert.ToDateTime(dataFinal.ToString("yyyy-MM-dd"));

            var query = (from ativo in Db.Ativo
                         from usuarioAtivo in Db.UsuarioAtivo.Where(x => x.AtivoId == ativo.Id)
                         from usuario in Db.Usuario.Where(x => x.Id == usuarioAtivo.UsuarioId)
                         where (usuarioAtivo.DataCadastro.Value >= dataInicial
                                && usuarioAtivo.DataCadastro.Value <= dataFinal)
                         select new AtivoDto
                         {
                             symbol = ativo.Sigla,
                             currentPrice = ativo.Valor
                         });

            var siglaMaisVendidos = query.GroupBy(userInfo => userInfo.symbol)
                                    .OrderBy(group => group.Key)
                                    .Select(group => Tuple.Create(group.Key, group.Count()))
                                    .ToList()
                                    .OrderByDescending(c => c.Item2).Take(4)
                                    .Select(p => new { p.Item1 }).ToList();
           
            var retorno = query.Distinct().ToList().Where(c => siglaMaisVendidos.Any(p => c.symbol.Contains(p.Item1)));

            return retorno.Take(4).ToList(); 
        }

    }
}
