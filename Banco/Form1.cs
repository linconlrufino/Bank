using System;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];

            contas[0] = new Conta(0);
            this.contas[0].Titular = new Cliente("Jacare 0");

            contas[1] = new ContaPoupanca(1);
            this.contas[1].Titular = new Cliente("Jacare 1 ");

            contas[2] = new ContaCorrente(2);
            this.contas[2].Titular = new Cliente("Jacare 2 ");

            foreach(Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }

            foreach (Conta conta in contas)
            {
                comboDestinoTransferencia.Items.Add(conta.Titular.Nome);
            }

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            string valorDigitado = textoValor.Text;

            double valorOperacao = Convert.ToDouble(valorDigitado);

            contas[indice].Deposita(valorOperacao);

            textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);

            MessageBox.Show("Sucesso");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            string valorDigitado = textoValor.Text;

            double valorOperacao = Convert.ToDouble(valorDigitado);

            bool sucessFail = contas[indice].Saca(valorOperacao);

            textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);

            if (sucessFail)
            {
                MessageBox.Show("Saque Efetuado");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            Conta selecionada = contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboDestinoTransferencia.SelectedIndex;

        }

        private void transferencia_Click(object sender, EventArgs e)
        {

            int indiceTransfe = comboContas.SelectedIndex;
            int indiceRecebe = comboDestinoTransferencia.SelectedIndex;

            Conta selecionadaTransfe = contas[indiceTransfe];
            Conta selecionadaRecebe = contas[indiceRecebe];

            double valorTransfer = Convert.ToDouble(textoValorTransfer.Text);

            if (selecionadaTransfe.Saldo >= valorTransfer)
            {
                selecionadaRecebe.Deposita(valorTransfer);

                selecionadaTransfe.Saca(valorTransfer);

                MessageBox.Show("Transferência Efetuada");
            }
            else
            {
                MessageBox.Show("saldo Insuficiente");
            }

            textoSaldo.Text = Convert.ToString(selecionadaTransfe.Saldo);

        }
    }
}