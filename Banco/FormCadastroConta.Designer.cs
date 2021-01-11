
namespace Banco
{
    partial class FormCadastroConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.Titular = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoProfissao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textoEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textoIdade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(231, 343);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(121, 44);
            this.botaoCadastro.TabIndex = 0;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(231, 163);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(121, 23);
            this.textoTitular.TabIndex = 1;
            // 
            // Titular
            // 
            this.Titular.AutoSize = true;
            this.Titular.Location = new System.Drawing.Point(170, 163);
            this.Titular.Name = "Titular";
            this.Titular.Size = new System.Drawing.Size(40, 15);
            this.Titular.TabIndex = 4;
            this.Titular.Text = "Titular";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(231, 89);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 23);
            this.comboTipo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de Conta";
            // 
            // textoProfissao
            // 
            this.textoProfissao.Location = new System.Drawing.Point(231, 254);
            this.textoProfissao.Name = "textoProfissao";
            this.textoProfissao.Size = new System.Drawing.Size(121, 23);
            this.textoProfissao.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Profissão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // textoEmail
            // 
            this.textoEmail.Location = new System.Drawing.Point(231, 209);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(121, 23);
            this.textoEmail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Idade";
            // 
            // textoIdade
            // 
            this.textoIdade.Location = new System.Drawing.Point(231, 293);
            this.textoIdade.Name = "textoIdade";
            this.textoIdade.Size = new System.Drawing.Size(121, 23);
            this.textoIdade.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(22, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Preencha os Campos";
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(159, 131);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(51, 15);
            this.Numero.TabIndex = 16;
            this.Numero.Text = "Numero";
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(231, 128);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(121, 23);
            this.textoNumero.TabIndex = 17;
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 441);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textoIdade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textoEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoProfissao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.Titular);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.botaoCadastro);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label Titular;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoProfissao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoIdade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.TextBox textoNumero;
    }
}