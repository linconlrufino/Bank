using Banco.Contas;

namespace Banco
{
    public class ContaCorrente : Conta
    {
        private static int totalDeContas = 0;
        
        public ContaCorrente()
        {
            ContaCorrente.totalDeContas ++; 
        }

        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }

        public override void Saca(double valor)
        {

            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.10;
            }
        }
    }
}