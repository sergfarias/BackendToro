using Equinox.Domain.Core.Models;
using System;
namespace Equinox.Domain.Models
{
    public class UsuarioAtivo : Entity<UsuarioAtivo> 
    {

        public int AtivoId { get; private set; }
        public int UsuarioId { get; private set; }
        public int Quantidade { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public virtual Usuario Usuario { get; private set; }
        public virtual Ativo Ativo { get; private set; }

        public UsuarioAtivo(int id, int ativoId, int usuarioId, int quantidade,
                            Usuario usuario, Ativo ativo, DateTime? dataCadastro)
        {
            Id = id;
            AtivoId = ativoId;
            UsuarioId = usuarioId;
            Quantidade = quantidade;
            Usuario = usuario;
            Ativo = ativo;
            DataCadastro = dataCadastro;
        }

        // Empty constructor for EF
        protected UsuarioAtivo() { }

        public override bool IsValid()
        {
            return true;
        }

    }
}