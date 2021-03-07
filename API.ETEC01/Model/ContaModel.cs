using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ETEC01.Model
{
    public class ContaModel
    {
        public int Id { get; set; }
        public string NomeDoCredor { get; set; }
        public DateTime DataDoVencimento { get; set; }
        public double ValoraPagar { get; set; }
        public DateTime DataDoPagamento { get; set; }
        public string Email { get; set; }
    }
}
