using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributos();
        }
    }
}
