
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chamados.MVC.ViewModel
{
    public class ClienteViewModel
    {
        [Key]
        public long ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Razão Socila")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Máximo {0} caracteres")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Preencha o campo Razão Socila")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Máximo {0} caracteres")]
        public string NomeFantasia { get; set; }

        [ScaffoldColumn(false)]// Não exibe este campo
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<ChamadoViewModel> Chamados { get; set; }
    }
}