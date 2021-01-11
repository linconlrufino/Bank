
namespace Banco
{
    partial class Informacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoNomeInfo = new System.Windows.Forms.TextBox();
            this.textoContaInfo = new System.Windows.Forms.TextBox();
            this.textoEmailInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textoProfissaoInfo = new System.Windows.Forms.TextBox();
            this.textoIdadeInfo = new System.Windows.Forms.TextBox();
            this.textoTipoConta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero da Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // textoNomeInfo
            // 
            this.textoNomeInfo.Location = new System.Drawing.Point(398, 180);
            this.textoNomeInfo.Name = "textoNomeInfo";
            this.textoNomeInfo.Size = new System.Drawing.Size(100, 23);
            this.textoNomeInfo.TabIndex = 3;
            // 
            // textoContaInfo
            // 
            this.textoContaInfo.Location = new System.Drawing.Point(398, 136);
            this.textoContaInfo.Name = "textoContaInfo";
            this.textoContaInfo.Size = new System.Drawing.Size(100, 23);
            this.textoContaInfo.TabIndex = 4;
            // 
            // textoEmailInfo
            // 
            this.textoEmailInfo.Location = new System.Drawing.Point(398, 224);
            this.textoEmailInfo.Name = "textoEmailInfo";
            this.textoEmailInfo.Size = new System.Drawing.Size(100, 23);
            this.textoEmailInfo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profissão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Idade";
            // 
            // textoProfissaoInfo
            // 
            this.textoProfissaoInfo.Location = new System.Drawing.Point(398, 276);
            this.textoProfissaoInfo.Name = "textoProfissaoInfo";
            this.textoProfissaoInfo.Size = new System.Drawing.Size(100, 23);
            this.textoProfissaoInfo.TabIndex = 8;
            // 
            // textoIdadeInfo
            // 
            this.textoIdadeInfo.Location = new System.Drawing.Point(398, 330);
            this.textoIdadeInfo.Name = "textoIdadeInfo";
            this.textoIdadeInfo.Size = new System.Drawing.Size(100, 23);
            this.textoIdadeInfo.TabIndex = 9;
            // 
            // textoTipoConta
            // 
            this.textoTipoConta.Location = new System.Drawing.Point(398, 96);
            this.textoTipoConta.Name = "textoTipoConta";
            this.textoTipoConta.Size = new System.Drawing.Size(100, 23);
            this.textoTipoConta.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo de Conta";
            // 
            // Informacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textoTipoConta);
            this.Controls.Add(this.textoIdadeInfo);
            this.Controls.Add(this.textoProfissaoInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textoEmailInfo);
            this.Controls.Add(this.textoContaInfo);
            this.Controls.Add(this.textoNomeInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Informacao";
            this.Text = "Informacao";
            this.Load += new System.EventHandler(this.Informacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoNomeInfo;
        private System.Windows.Forms.TextBox textoContaInfo;
        private System.Windows.Forms.TextBox textoEmailInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoProfissaoInfo;
        private System.Windows.Forms.TextBox textoIdadeInfo;
        private System.Windows.Forms.TextBox textoTipoConta;
        private System.Windows.Forms.Label label6;
    }
}