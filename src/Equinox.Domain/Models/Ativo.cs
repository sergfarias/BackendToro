using System;
using Equinox.Domain.Core.Models;
using System.Collections.Generic;

namespace Equinox.Domain.Models
{
    public class Ativo : Entity<Ativo> 
    {

        public string Sigla { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public virtual ICollection<UsuarioAtivo> UsuarioAtivo { get; private set; }


        public Ativo(int id, string sigla, string descricao,  
                     decimal valor, DateTime? dataCadastro,
                     ICollection<UsuarioAtivo> usuarioAtivo)
        {
            Id = id;
            Sigla = sigla;
            Descricao = descricao;
            Valor = valor;
            DataCadastro = dataCadastro;
            UsuarioAtivo = usuarioAtivo; 
        }

        // Empty constructor for EF
        protected Ativo() { }

        public override bool IsValid()
        {
            return true;
        }

    }
}