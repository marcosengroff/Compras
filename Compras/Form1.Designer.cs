namespace Compras
{
    partial class frmCompras
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQTB = new System.Windows.Forms.Label();
            this.lblForma = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtVTotal = new System.Windows.Forms.TextBox();
            this.nudQTD = new System.Windows.Forms.NumericUpDown();
            this.lblVTotal = new System.Windows.Forms.Label();
            this.radVista = new System.Windows.Forms.RadioButton();
            this.radParcelado = new System.Windows.Forms.RadioButton();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQTD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(13, 28);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(157, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Informe o valor do produto (R$):";
            // 
            // lblQTB
            // 
            this.lblQTB.AutoSize = true;
            this.lblQTB.Location = new System.Drawing.Point(60, 60);
            this.lblQTB.Name = "lblQTB";
            this.lblQTB.Size = new System.Drawing.Size(110, 13);
            this.lblQTB.TabIndex = 1;
            this.lblQTB.Text = "Informe a quantidade:";
            this.lblQTB.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Location = new System.Drawing.Point(16, 131);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(111, 13);
            this.lblForma.TabIndex = 2;
            this.lblForma.Text = "Forma de Pagamento:";
            this.lblForma.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(5, 83);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(185, 25);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(46, 20);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_KeyPress);
            // 
            // txtVTotal
            // 
            this.txtVTotal.Enabled = false;
            this.txtVTotal.Location = new System.Drawing.Point(185, 88);
            this.txtVTotal.Name = "txtVTotal";
            this.txtVTotal.Size = new System.Drawing.Size(46, 20);
            this.txtVTotal.TabIndex = 5;
            this.txtVTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudQTD
            // 
            this.nudQTD.Location = new System.Drawing.Point(185, 58);
            this.nudQTD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQTD.Name = "nudQTD";
            this.nudQTD.Size = new System.Drawing.Size(46, 20);
            this.nudQTD.TabIndex = 6;
            this.nudQTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQTD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblVTotal
            // 
            this.lblVTotal.AutoSize = true;
            this.lblVTotal.Location = new System.Drawing.Point(86, 88);
            this.lblVTotal.Name = "lblVTotal";
            this.lblVTotal.Size = new System.Drawing.Size(84, 13);
            this.lblVTotal.TabIndex = 7;
            this.lblVTotal.Text = "Valor Total (R$):";
            // 
            // radVista
            // 
            this.radVista.AutoSize = true;
            this.radVista.Location = new System.Drawing.Point(16, 160);
            this.radVista.Name = "radVista";
            this.radVista.Size = new System.Drawing.Size(57, 17);
            this.radVista.TabIndex = 8;
            this.radVista.TabStop = true;
            this.radVista.Text = "A vista";
            this.radVista.UseVisualStyleBackColor = true;
            this.radVista.Visible = false;
            this.radVista.CheckedChanged += new System.EventHandler(this.radVista_CheckedChanged);
            // 
            // radParcelado
            // 
            this.radParcelado.AutoSize = true;
            this.radParcelado.Location = new System.Drawing.Point(139, 160);
            this.radParcelado.Name = "radParcelado";
            this.radParcelado.Size = new System.Drawing.Size(130, 17);
            this.radParcelado.TabIndex = 9;
            this.radParcelado.TabStop = true;
            this.radParcelado.Text = "Parcelado em 3 vezes";
            this.radParcelado.UseVisualStyleBackColor = true;
            this.radParcelado.Visible = false;
            this.radParcelado.CheckedChanged += new System.EventHandler(this.radParcelado_CheckedChanged);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(16, 201);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(35, 13);
            this.lblMensagem.TabIndex = 10;
            this.lblMensagem.Text = "label5";
            this.lblMensagem.Visible = false;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(185, 194);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.ReadOnly = true;
            this.txtFinal.Size = new System.Drawing.Size(46, 20);
            this.txtFinal.TabIndex = 11;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFinal.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(19, 256);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(139, 256);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 300);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.radParcelado);
            this.Controls.Add(this.radVista);
            this.Controls.Add(this.lblVTotal);
            this.Controls.Add(this.nudQTD);
            this.Controls.Add(this.txtVTotal);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblForma);
            this.Controls.Add(this.lblQTB);
            this.Controls.Add(this.lblProduto);
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.nudQTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQTB;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtVTotal;
        private System.Windows.Forms.NumericUpDown nudQTD;
        private System.Windows.Forms.Label lblVTotal;
        private System.Windows.Forms.RadioButton radVista;
        private System.Windows.Forms.RadioButton radParcelado;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

