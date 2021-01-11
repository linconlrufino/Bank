using System;

namespace Banco.Contas
{
    public abstract class Conta
    {
        public string TipoConta { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public static int numeroDeContas;

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public abstract void Saca(double valor);
        /*{
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
         }*/

    }
}