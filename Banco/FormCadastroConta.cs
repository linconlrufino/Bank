using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Banco.Contas;


namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void FormCadastroConta_Load_1(object sender, EventArgs e)
        {
            comboTipo.Items.Add("Corrente");
            comboTipo.Items.Add("Poupanca");
            comboTipo.Items.Add("Investimento"); 
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());

        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            if (comboTipo.Text.Equals("Corrente"))
            {
                Conta novaConta = new ContaCorrente();
                novaConta.TipoConta = "Corrente";
                novaConta.Titular = new Cliente(textoTitular.Text);
                novaConta.Titular.Email = textoEmail.Text;
                novaConta.Titular.Profissao = textoProfissao.Text;
                novaConta.Titular.Idade = Convert.ToInt32(textoIdade.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }
            else if (comboTipo.Text.Equals("Poupanca"))
            {
                Conta novaConta = new ContaPoupanca();
                novaConta.TipoConta = "Poupanca";
                novaConta.Titular = new Cliente(textoTitular.Text);
                novaConta.Titular.Email = textoEmail.Text;
                novaConta.Titular.Profissao = textoProfissao.Text;
                novaConta.Titular.Idade = Convert.ToInt32(textoIdade.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }
            else
            {
                Conta novaConta = new ContaInvestimento();
                novaConta.TipoConta = "Investimento";
                novaConta.Titular = new Cliente(textoTitular.Text);
                novaConta.Titular.Email = textoEmail.Text;
                novaConta.Titular.Profissao = textoProfissao.Text;
                novaConta.Titular.Idade = Convert.ToInt32(textoIdade.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }

        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        { }


    }
}
