using System;

namespace Banco
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca() { }
        public ContaPoupanca(int numero) : base(numero) { }

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