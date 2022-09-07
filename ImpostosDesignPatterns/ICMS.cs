using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostosDesignPatterns
{
    public class ICMS
    {
        public double CalculaICMS(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01;
        }
    }
}
