
namespace Banco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.grouBox = new System.Windows.Forms.GroupBox();
            this.transferencia = new System.Windows.Forms.Button();
            this.comboDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Transfereencia = new System.Windows.Forms.GroupBox();
            this.textoValorTransfer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grouBox.SuspendLayout();
            this.Transfereencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(80, 151);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.PlaceholderText = "Saldo Atual";
            this.textoSaldo.Size = new System.Drawing.Size(100, 23);
            this.textoSaldo.TabIndex = 0;
            this.textoSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(30, 68);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.PlaceholderText = "Titular";
            this.textoTitular.Size = new System.Drawing.Size(100, 23);
            this.textoTitular.TabIndex = 1;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(136, 68);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.PlaceholderText = "Nº Conta";
            this.textoNumero.Size = new System.Drawing.Size(100, 23);
            this.textoNumero.TabIndex = 6;
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoDeposito.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.botaoDeposito.Location = new System.Drawing.Point(30, 257);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(75, 23);
            this.botaoDeposito.TabIndex = 3;
            this.botaoDeposito.Text = "Deposito";
            this.botaoDeposito.UseVisualStyleBackColor = false;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(80, 216);
            this.textoValor.Name = "textoValor";
            this.textoValor.PlaceholderText = "Insira Valor";
            this.textoValor.Size = new System.Drawing.Size(100, 23);
            this.textoValor.TabIndex = 4;
            this.textoValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // botaoSaque
            // 
            this.botaoSaque.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoSaque.ForeColor = System.Drawing.Color.Coral;
            this.botaoSaque.Location = new System.Drawing.Point(161, 257);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(75, 23);
            this.botaoSaque.TabIndex = 5;
            this.botaoSaque.Text = "Saque";
            this.botaoSaque.UseVisualStyleBackColor = false;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nº Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Saldo Atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.botaoDeposito);
            this.groupBox1.Controls.Add(this.botaoSaque);
            this.groupBox1.Location = new System.Drawing.Point(381, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 307);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Escolha a Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(172, 42);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 23);
            this.comboContas.TabIndex = 16;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // grouBox
            // 
            this.grouBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grouBox.Controls.Add(this.Transfereencia);
            this.grouBox.Controls.Add(this.comboContas);
            this.grouBox.Controls.Add(this.label5);
            this.grouBox.Location = new System.Drawing.Point(12, 12);
            this.grouBox.Name = "grouBox";
            this.grouBox.Size = new System.Drawing.Size(350, 309);
            this.grouBox.TabIndex = 12;
            this.grouBox.TabStop = false;
            this.grouBox.Text = "Busca de Conta";
            // 
            // transferencia
            // 
            this.transferencia.Location = new System.Drawing.Point(93, 156);
            this.transferencia.Name = "transferencia";
            this.transferencia.Size = new System.Drawing.Size(75, 23);
            this.transferencia.TabIndex = 19;
            this.transferencia.Text = "Transferir";
            this.transferencia.UseVisualStyleBackColor = true;
            this.transferencia.Click += new System.EventHandler(this.transferencia_Click);
            // 
            // comboDestinoTransferencia
            // 
            this.comboDestinoTransferencia.FormattingEnabled = true;
            this.comboDestinoTransferencia.Location = new System.Drawing.Point(75, 50);
            this.comboDestinoTransferencia.Name = "comboDestinoTransferencia";
            this.comboDestinoTransferencia.Size = new System.Drawing.Size(121, 23);
            this.comboDestinoTransferencia.TabIndex = 18;
            this.comboDestinoTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Transferir Para";
            // 
            // Transfereencia
            // 
            this.Transfereencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Transfereencia.Controls.Add(this.textoValorTransfer);
            this.Transfereencia.Controls.Add(this.comboDestinoTransferencia);
            this.Transfereencia.Controls.Add(this.transferencia);
            this.Transfereencia.Controls.Add(this.label6);
            this.Transfereencia.Location = new System.Drawing.Point(59, 103);
            this.Transfereencia.Name = "Transfereencia";
            this.Transfereencia.Size = new System.Drawing.Size(254, 189);
            this.Transfereencia.TabIndex = 20;
            this.Transfereencia.TabStop = false;
            this.Transfereencia.Text = "Transferência";
            // 
            // textoValorTransfer
            // 
            this.textoValorTransfer.Location = new System.Drawing.Point(75, 115);
            this.textoValorTransfer.Name = "textoValorTransfer";
            this.textoValorTransfer.PlaceholderText = "Valor";
            this.textoValorTransfer.Size = new System.Drawing.Size(121, 23);
            this.textoValorTransfer.TabIndex = 21;
            this.textoValorTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(651, 329);
            this.Controls.Add(this.grouBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grouBox.ResumeLayout(false);
            this.grouBox.PerformLayout();
            this.Transfereencia.ResumeLayout(false);
            this.Transfereencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.GroupBox grouBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboDestinoTransferencia;
        private System.Windows.Forms.Button transferencia;
        private System.Windows.Forms.GroupBox Transfereencia;
        private System.Windows.Forms.TextBox textoValorTransfer;
    }
}

