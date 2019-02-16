

using System;
using System.Collections.Generic;

namespace Chamados.Domain.Entities
{
    public class Cliente
    {
        public long ClienteId { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<Chamado> Chamados { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
