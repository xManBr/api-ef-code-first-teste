using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.LaerteTeste2020.Models
{
    public class Plano
    {
        public int PlanoId { get; set; }
        [StringLength(40)]
        public string Nome { get; set; }
        public decimal Mensalidade { get; set; }
    }
}
