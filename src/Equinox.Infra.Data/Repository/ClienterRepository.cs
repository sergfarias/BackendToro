using Equinox.Domain.Dto;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Equinox.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Equinox.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        protected new readonly EquinoxContext Db;

        public ClienteRepository(EquinoxContext context):base(context)
        {
            Db = context;
        }

        public Cliente GetByIdCliente(int id)
        {
            return DbSet.Find(id);
        }

        public Cliente GetByCPFCliente(string termo)
        {
            return DbSet.Where(c=> c.Cpf.Contains(termo)).FirstOrDefault() ;
        }

        public Cliente GetByCPFClienteAsNoTracking(string termo)
        {
            return DbSet.Where(c => c.Cpf.Contains(termo)).AsNoTracking().FirstOrDefault();
        }

        public ClienteAnimal GetByAnimalAsNoTracking(int clienteId, int animalId)
        {
            //.AsNoTracking()
            return Db.ClienteAnimal.Where(c => (c.ClienteId == clienteId) && (c.Id == animalId)).FirstOrDefault();
        }

        public ICollection<Cliente> GetByCodigoCliente(string codigo)
        {
            int.TryParse(codigo, out int ID);

            var clientes = from cliente in Db.Cliente
                           where cliente.Id == ID || cliente.Cpf == codigo
                           select cliente;

            return clientes.ToList();
        }

        public ICollection<Cliente> GetByTermoCliente(string termo, string campo = null)
        {
            ICollection<Cliente> clientes = null;

            termo = termo.Trim().ToUpper();

            if (campo == "2")
            {
                clientes = (from cliente in Db.Cliente
                            where cliente.Nome.ToUpper().Trim().Contains(termo)
                            //|| cliente.NM_FANTASIA.ToUpper().Trim().Contains(Termo) )
                            select cliente).Take(100).ToList();
            }
            if (campo == "4")
            {
                clientes = (from cliente in Db.Cliente
                           from clicontato in Db.ClienteContato.Where(e => cliente.Id == e.ClienteId)
                           where clicontato.NomeContato.Contains(termo) 
                           select cliente).ToList();
            }

            return clientes;

        }

        public IEnumerable<ClienteAnimalDto> GetByClienteAnimal(string Termo)
        {

            var query = (from cliente in Db.Cliente
                        from clienteAnimal in Db.ClienteAnimal.Where(x => x.ClienteId == cliente.Id)
                         from tipoAnimal in Db.TipoAnimal.Where(x => x.Id == clienteAnimal.TipoAnimalId)
                         where cliente.Cpf == Termo
                        select new ClienteAnimalDto
                        {
                            clienteid = cliente.Id,
                            id = clienteAnimal.Id,
                            nome = clienteAnimal.Nome,
                            idade = clienteAnimal.Idade,
                            tipoanimalid = clienteAnimal.TipoAnimalId,
                            tipoanimalnome = tipoAnimal.Nome
                        });

            return query;
        }

        public IEnumerable<ClienteContatoDto> GetByClienteContato(string Termo)
        {
            var query = from cliente in Db.Cliente
                        from clientecontato in Db.ClienteContato.Where(x => cliente.Id == x.ClienteId)
                        where cliente.Cpf == Termo
                        select new ClienteContatoDto
                        {
                          id_contato =   clientecontato.Id,
                          id_cliente =  clientecontato.ClienteId,
                          id_tipo_contato =  clientecontato.TipoContatoId,
                          ds_contato =  clientecontato.NomeContato
                        };

            return query.ToList();
        }

        public dynamic RecuperarDropDownTipoContato()
        {
            var query = from tpContato in Db.TipoContato
                        orderby tpContato.Id ascending
                        select new
                        {
                            id_tipo_contato = tpContato.Id,
                            ds_tipo_contato = tpContato.Nome
                        };

            return query.ToList();
        }

        public dynamic RecuperarDropDownTipoAnimal()
        {
            var query = from tpContato in Db.TipoAnimal
                        orderby tpContato.Id ascending
                        select new
                        {
                            id = tpContato.Id,
                            nome = tpContato.Nome
                        };

            return query.ToList();
        }

    }
}
