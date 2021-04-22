using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.LaerteTeste2020.Models
{
    public class Beneficiario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BeneficiarioId { get; set; }
        [StringLength(40)]
        public string Nome { get; set; }
        [StringLength(40)]
        public string Fone { get; set; }
        public DateTime DataNascimento { get; set; }
        [StringLength(9)]
        public string Cep { get; set; }
        public int Dependentes { get; set; }

        public int? PlanoId { get; set; }
        public Plano Plano { get; set; }
    }
}
