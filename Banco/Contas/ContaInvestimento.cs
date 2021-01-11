using System;
using Banco.Contas;


namespace Banco
{
    class ContaInvestimento : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.10;
            }
        }

        public  double CalculaTributos()
        {
            return this.Saldo * 0.03;
        }
    }
}
