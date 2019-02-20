using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chamados.MVC.ViewModel
{
    public class ChamadoViewModel
    {
        [Key]
        public long ChamadoID { get; set; }

        public string Descricao { get; set; }

        public long ClienteId { get; set; }

        [ScaffoldColumn(false)]// Não exibe este campo
        public DateTime DataCadastro { get; set; }

        public DateTime DataEncerramento { get; set; }

        public int NumeroDeVezesReaberto { get; set; }

        public virtual ClienteViewModel Cliente { get; set; } // virtual - Lazyload do Entity
    }
}