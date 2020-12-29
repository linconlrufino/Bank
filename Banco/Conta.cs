using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get;  set; }
        public double Saldo { get;  set; }
        public Cliente Titular { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual bool Saca(double valor)
        {
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}