using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoCombustivel
{
    public abstract class absConsumo
    {
        public double Consumo { get; set; }
        public double Combustivel { get; set; }
        public string Mensagem { get; set; }
    }
}
