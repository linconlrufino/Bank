using System;

namespace Banco
{
    public class ContaPoupanca : Conta
    {

        public override bool Saca(double valor)
        {
          
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor += 0.10;
                return true;
            }
            return false;
        }
    }
}