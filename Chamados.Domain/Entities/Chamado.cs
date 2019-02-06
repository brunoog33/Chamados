using System;

namespace Chamados.Domain.Entities
{
    public class Chamado
    {
        public long ChamadoID { get; set; }

        public string Descricao { get; set; }

        public long ClienteId { get; set; }

        public DateTime DataAbertura { get; set; }

        public DateTime DataEncerramento { get; set; }

        public int NumeroDeVezesReaberto { get; set; }

        public int ContadorReabertura(int numeroDeVezesReaberto)
        {
            return NumeroDeVezesReaberto++;
        }
    }
}
