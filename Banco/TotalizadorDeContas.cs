using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class TotalizadorDeContas
    {
        public double valorTotal { get; private set; }

        public void Soma(Conta conta)
        {
            valorTotal += conta.Saldo;
        }

    }
}
