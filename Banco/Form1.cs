using System;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private ContaPoupanca conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new ContaPoupanca();
            this.conta.Numero = 1;
            Cliente cliente = new Cliente("Dodo");
            conta.Titular = cliente;

            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);

            Conta c1 = new Conta();
            ContaPoupanca c2 = new ContaPoupanca();

            TotalizadorDeContas t = new TotalizadorDeContas();

            t.Soma(c1);
            t.Soma(c2);

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            bool sucessFail = conta.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            if (sucessFail)
            {
                MessageBox.Show("Saque Efetuado");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }


    }
}
