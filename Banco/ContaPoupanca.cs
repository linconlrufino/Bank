using System;

namespace Banco
{
    public class ContaPoupanca : Conta
    {

        public void CalcularRendimento()
        {

        }

        public override bool Saca(double valor)
        {
            valor += 0.10;

            if (this.Saldo >= valor)
            {
                //this.Saldo -= valor;
                base.Saca(valor);
                return true;
            }
            return false;
        }
    }
}