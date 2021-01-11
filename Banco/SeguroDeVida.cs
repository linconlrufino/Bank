using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class SeguroDeVida: ITributavel
    {
        public double CalculaTributos()
        {
            return 43;
        }
    }
}
