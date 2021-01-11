using System;
using System.Windows.Forms;
using Banco.Contas;


namespace Banco
{
    public partial class Informacao : Form
    {
        private Form1 formPrincipal;

        public Informacao(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void Informacao_Load(object sender, EventArgs e)
        {
            Conta infoConta = new ContaCorrente();

            infoConta =  formPrincipal.MostraInfo();
            
            if(infoConta.TipoConta == "Corrente")
            {
                textoTipoConta.Text = infoConta.TipoConta;
            }
            else if(infoConta.TipoConta == "Poupanca")
            {
                textoTipoConta.Text = infoConta.TipoConta;
            }
            else
            {
                textoTipoConta.Text = infoConta.TipoConta;
            }

            textoContaInfo.Text = Convert.ToString(infoConta.Numero);
            textoNomeInfo.Text = infoConta.Titular.Nome;
            textoEmailInfo.Text = infoConta.Titular.Email;
            textoProfissaoInfo.Text = infoConta.Titular.Profissao;
            textoIdadeInfo.Text = Convert.ToString(infoConta.Titular.Idade);
        }
    }
}
