using System;
using Equinox.Domain.Core.Models;

namespace Equinox.Domain.Models
{
    public class ClienteContato : Entity<ClienteContato> 
    {
        
        public int ClienteId { get; private set; }
        public int TipoContatoId { get; private set; }

        public TipoContato TipoContato
        {
            get => TipoContato.ObterPorId(TipoContatoId);
            set => TipoContatoId = value.Id;
        }

        public string NomeContato { get; private set; }
        public virtual Cliente  Cliente { get; private set; }

        public ClienteContato(int id, string nomeContato, int tipoContatoId, int clienteId, Cliente cliente)
        {
            Id = id;
            TipoContatoId = tipoContatoId;
            NomeContato = nomeContato;
            ClienteId=clienteId;
            Cliente = cliente;
        }

        // Empty constructor for EF
        protected ClienteContato() { }

        public override bool IsValid()
        {
            return true;
        }

    }
}