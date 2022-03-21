using Equinox.Domain.Core.Models;
using System;
namespace Equinox.Domain.Models
{
    public class Movimento : Entity<Movimento> 
    {

        public int UsuarioId { get; private set; }
       public string Evento { get; private set; }
        public string BancoDestino { get; private set; }
        public string AgenciaDestino { get; private set; }
        public string ContaDestino { get; private set; }
        public string BancoOrigem { get; private set; }
        public string AgenciaOrigem { get; private set; }
        public string CpfOrigem { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public virtual Usuario Usuario { get; private set; }


        public Movimento(int id, int usuarioId, string evento, string bancoDestino, 
                         string agenciaDestino, string contaDestino, string bancoOrigem, 
                         string agenciaOrigem, string cpfOrigem,  decimal valor, 
                         DateTime? dataCadastro, Usuario usuario)
        {
            Id = id;
            UsuarioId = usuarioId;
            Evento = evento;
            BancoDestino = bancoDestino;
            AgenciaDestino = agenciaDestino;
            ContaDestino = contaDestino;
            BancoOrigem = bancoOrigem;
            AgenciaOrigem = agenciaOrigem;
            CpfOrigem = cpfOrigem;
            Valor = valor;
            DataCadastro = dataCadastro;
            Usuario = usuario;
        }

        // Empty constructor for EF
        protected Movimento() { }

        public override bool IsValid()
        {
            return true;
        }

    }
}