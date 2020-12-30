namespace Banco
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(int numero) : base(numero)
        {
        }

        public override bool Saca(double valor)
        {
            valor += 0.05;

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