using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Models
{
    public class Venda
    {
        public int Id { get; set; }

        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}