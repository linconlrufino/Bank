using System;
using System.Windows.Forms;
using Banco.Contas;


namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta[] contas;

        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[20];

            Conta c1 = new ContaCorrente();
            c1.Titular = new Cliente("Jacare 0");
            c1.Titular.Email = "jacare11@dodo.com";
            c1.Titular.Idade = 21;
            c1.Titular.Profissao = "11Teste job";
            this.AdicionaConta(c1);

            Conta c2 = new ContaInvestimento();
            c2.Titular = new Cliente("Jacare 1 "); 
            c2.Titular.Email = "jacare22@dodo.com";
            c2.Titular.Idade = 22;
            c2.Titular.Profissao = "22Teste job";
            this.AdicionaConta(c2);

            Conta c3 = new ContaPoupanca();
            c3.Titular = new Cliente("Jacare 2 ");
            c3.Titular.Email = "jacare33@dodo.com";
            c3.Titular.Idade = 23;
            c3.Titular.Profissao = "33Teste job";
            this.AdicionaConta(c3); 


        }

        public Conta MostraInfo()
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);

            return contas[indice];

            //Conta infConta = new ContaCorrente();
            //infConta = contas[indice];
            //return infConta;
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("Titular  : " + conta.Titular.Nome);
            comboDestinoTransferencia.Items.Add("Titular  : " + conta.Titular.Nome);
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
            double valor = Convert.ToDouble(valorDigitado);
            Conta selecionada = this.contas[indice];
            try
            {
                selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro Liberado");
            }
            catch(SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
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

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void botaoInformacao_Click(object sender, EventArgs e)
        {
            Informacao formInformacao = new Informacao(this);

            formInformacao.ShowDialog();

            MostraInfo();
        }

        private void CalcularTributos_Click(object sender, EventArgs e)
        {
            TotalizadorDeTributos totTributos = new TotalizadorDeTributos();

            foreach (Conta conta in contas)
            {
                if (conta is ContaPoupanca valor1)
                {
                    totTributos.Acumula(valor1);
                }
                if (conta is ContaInvestimento valor2)
                {
                    totTributos.Acumula(valor2);
                }
            }

            /*
            ContaInvestimento c01 = new ContaInvestimento();
            c01.Deposita(100);

            ContaPoupanca c02 = new ContaPoupanca();
            c02.Deposita(100);

            SeguroDeVida seguro = new SeguroDeVida();

            totTributos.Acumula(c01);
            totTributos.Acumula(c02);
            totTributos.Acumula(seguro);
            */

            MessageBox.Show("Total :"+totTributos.Total);

        }
    }
}