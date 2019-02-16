using System;

namespace Chamados.Domain.Entities
{
    public class Chamado
    {
        public long ChamadoID { get; set; }

        public string Descricao { get; set; }

        public long ClienteId { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataEncerramento { get; set; }

        public int NumeroDeVezesReaberto { get; set; }

        public virtual Cliente Cliente { get; set; } // Lazyload do Entity

        public int ContadorReabertura(int numeroDeVezesReaberto)
        {
            return NumeroDeVezesReaberto++;
        }
    }
}
