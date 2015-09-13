namespace T.I._2015
{
    partial class frmNovaVenda
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
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.cbTipoProdutoVenda = new System.Windows.Forms.ComboBox();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.lblVendTitulo = new System.Windows.Forms.Label();
            this.dgVendAtual = new System.Windows.Forms.DataGridView();
            this.lblVendCarrinho = new System.Windows.Forms.Label();
            this.cmbTamVidro = new System.Windows.Forms.Panel();
            this.lblCheck = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblM2 = new System.Windows.Forms.Label();
            this.lblDimencao = new System.Windows.Forms.Label();
            this.txtDimencao = new System.Windows.Forms.TextBox();
            this.grpDimencao = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblComprimento = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnVendConcluirCompra = new System.Windows.Forms.Button();
            this.lblCorProduto = new System.Windows.Forms.Label();
            this.cbNomeProd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendAtual)).BeginInit();
            this.cmbTamVidro.SuspendLayout();
            this.grpDimencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Location = new System.Drawing.Point(198, 304);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(176, 29);
            this.txtTotalCompra.TabIndex = 33;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.ForeColor = System.Drawing.Color.White;
            this.lblTotalCompra.Location = new System.Drawing.Point(136, 307);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(54, 21);
            this.lblTotalCompra.TabIndex = 32;
            this.lblTotalCompra.Text = "Valor :";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.White;
            this.txtNomeCliente.Location = new System.Drawing.Point(198, 56);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(176, 29);
            this.txtNomeCliente.TabIndex = 28;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCliente.Location = new System.Drawing.Point(53, 59);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(130, 21);
            this.lblNomeCliente.TabIndex = 27;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // cbTipoProdutoVenda
            // 
            this.cbTipoProdutoVenda.BackColor = System.Drawing.Color.White;
            this.cbTipoProdutoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProdutoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoProdutoVenda.FormattingEnabled = true;
            this.cbTipoProdutoVenda.Items.AddRange(new object[] {
            "Vidros",
            "Insufilmes",
            "Espelhos",
            "Portas",
            "Esquadrilhas"});
            this.cbTipoProdutoVenda.Location = new System.Drawing.Point(198, 142);
            this.cbTipoProdutoVenda.Name = "cbTipoProdutoVenda";
            this.cbTipoProdutoVenda.Size = new System.Drawing.Size(176, 29);
            this.cbTipoProdutoVenda.TabIndex = 24;
            this.cbTipoProdutoVenda.SelectedIndexChanged += new System.EventHandler(this.cbTipoProdutoVenda_SelectedIndexChanged);
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.ForeColor = System.Drawing.Color.White;
            this.lblTipoProduto.Location = new System.Drawing.Point(58, 145);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(125, 21);
            this.lblTipoProduto.TabIndex = 22;
            this.lblTipoProduto.Text = "Tipo do Produto:";
            // 
            // lblVendTitulo
            // 
            this.lblVendTitulo.AutoSize = true;
            this.lblVendTitulo.ForeColor = System.Drawing.Color.White;
            this.lblVendTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblVendTitulo.Name = "lblVendTitulo";
            this.lblVendTitulo.Size = new System.Drawing.Size(98, 21);
            this.lblVendTitulo.TabIndex = 34;
            this.lblVendTitulo.Text = "Nova Venda:";
            // 
            // dgVendAtual
            // 
            this.dgVendAtual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendAtual.Location = new System.Drawing.Point(16, 564);
            this.dgVendAtual.Name = "dgVendAtual";
            this.dgVendAtual.Size = new System.Drawing.Size(1049, 307);
            this.dgVendAtual.TabIndex = 36;
            // 
            // lblVendCarrinho
            // 
            this.lblVendCarrinho.AutoSize = true;
            this.lblVendCarrinho.ForeColor = System.Drawing.Color.White;
            this.lblVendCarrinho.Location = new System.Drawing.Point(22, 540);
            this.lblVendCarrinho.Name = "lblVendCarrinho";
            this.lblVendCarrinho.Size = new System.Drawing.Size(162, 21);
            this.lblVendCarrinho.TabIndex = 37;
            this.lblVendCarrinho.Text = "Carrinho de Compras:";
            // 
            // cmbTamVidro
            // 
            this.cmbTamVidro.Controls.Add(this.lblCheck);
            this.cmbTamVidro.Controls.Add(this.button1);
            this.cmbTamVidro.Controls.Add(this.lblM2);
            this.cmbTamVidro.Controls.Add(this.lblDimencao);
            this.cmbTamVidro.Controls.Add(this.txtDimencao);
            this.cmbTamVidro.Controls.Add(this.grpDimencao);
            this.cmbTamVidro.Controls.Add(this.btnVendConcluirCompra);
            this.cmbTamVidro.Controls.Add(this.lblCorProduto);
            this.cmbTamVidro.Controls.Add(this.lblTipoProduto);
            this.cmbTamVidro.Controls.Add(this.cbTipoProdutoVenda);
            this.cmbTamVidro.Controls.Add(this.cbNomeProd);
            this.cmbTamVidro.Controls.Add(this.lblNomeCliente);
            this.cmbTamVidro.Controls.Add(this.txtTotalCompra);
            this.cmbTamVidro.Controls.Add(this.txtNomeCliente);
            this.cmbTamVidro.Controls.Add(this.lblTotalCompra);
            this.cmbTamVidro.Location = new System.Drawing.Point(37, 61);
            this.cmbTamVidro.Name = "cmbTamVidro";
            this.cmbTamVidro.Size = new System.Drawing.Size(892, 476);
            this.cmbTamVidro.TabIndex = 41;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.ForeColor = System.Drawing.Color.White;
            this.lblCheck.Location = new System.Drawing.Point(481, 59);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(22, 21);
            this.lblCheck.TabIndex = 50;
            this.lblCheck.Text = "--";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(396, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 31);
            this.button1.TabIndex = 48;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.ForeColor = System.Drawing.Color.White;
            this.lblM2.Location = new System.Drawing.Point(276, 235);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(30, 21);
            this.lblM2.TabIndex = 49;
            this.lblM2.Text = "m²";
            // 
            // lblDimencao
            // 
            this.lblDimencao.AutoSize = true;
            this.lblDimencao.ForeColor = System.Drawing.Color.White;
            this.lblDimencao.Location = new System.Drawing.Point(102, 235);
            this.lblDimencao.Name = "lblDimencao";
            this.lblDimencao.Size = new System.Drawing.Size(83, 21);
            this.lblDimencao.TabIndex = 47;
            this.lblDimencao.Text = "Dimenção:";
            // 
            // txtDimencao
            // 
            this.txtDimencao.Enabled = false;
            this.txtDimencao.Location = new System.Drawing.Point(198, 230);
            this.txtDimencao.Name = "txtDimencao";
            this.txtDimencao.Size = new System.Drawing.Size(72, 29);
            this.txtDimencao.TabIndex = 48;
            this.txtDimencao.TextChanged += new System.EventHandler(this.txtDimencao_TextChanged);
            // 
            // grpDimencao
            // 
            this.grpDimencao.Controls.Add(this.btnCalcular);
            this.grpDimencao.Controls.Add(this.lblComprimento);
            this.grpDimencao.Controls.Add(this.lblAltura);
            this.grpDimencao.Controls.Add(this.txtComprimento);
            this.grpDimencao.Controls.Add(this.txtAltura);
            this.grpDimencao.ForeColor = System.Drawing.Color.White;
            this.grpDimencao.Location = new System.Drawing.Point(451, 133);
            this.grpDimencao.Name = "grpDimencao";
            this.grpDimencao.Size = new System.Drawing.Size(387, 183);
            this.grpDimencao.TabIndex = 44;
            this.grpDimencao.TabStop = false;
            this.grpDimencao.Text = "Dimenções";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(284, 134);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 37);
            this.btnCalcular.TabIndex = 47;
            this.btnCalcular.Text = "Calcule";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblComprimento
            // 
            this.lblComprimento.AutoSize = true;
            this.lblComprimento.ForeColor = System.Drawing.Color.White;
            this.lblComprimento.Location = new System.Drawing.Point(13, 99);
            this.lblComprimento.Name = "lblComprimento";
            this.lblComprimento.Size = new System.Drawing.Size(110, 21);
            this.lblComprimento.TabIndex = 45;
            this.lblComprimento.Text = "Comprimento:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.ForeColor = System.Drawing.Color.White;
            this.lblAltura.Location = new System.Drawing.Point(51, 55);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(55, 21);
            this.lblAltura.TabIndex = 46;
            this.lblAltura.Text = "Altura:";
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(129, 96);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(176, 29);
            this.txtComprimento.TabIndex = 45;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(129, 52);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(176, 29);
            this.txtAltura.TabIndex = 46;
            // 
            // btnVendConcluirCompra
            // 
            this.btnVendConcluirCompra.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVendConcluirCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendConcluirCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnVendConcluirCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVendConcluirCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendConcluirCompra.Location = new System.Drawing.Point(699, 412);
            this.btnVendConcluirCompra.Name = "btnVendConcluirCompra";
            this.btnVendConcluirCompra.Size = new System.Drawing.Size(188, 44);
            this.btnVendConcluirCompra.TabIndex = 39;
            this.btnVendConcluirCompra.Text = "Adicionar Produto";
            this.btnVendConcluirCompra.UseVisualStyleBackColor = false;
            this.btnVendConcluirCompra.Click += new System.EventHandler(this.btnVendConcluirCompra_Click);
            // 
            // lblCorProduto
            // 
            this.lblCorProduto.AutoSize = true;
            this.lblCorProduto.ForeColor = System.Drawing.Color.White;
            this.lblCorProduto.Location = new System.Drawing.Point(63, 181);
            this.lblCorProduto.Name = "lblCorProduto";
            this.lblCorProduto.Size = new System.Drawing.Size(120, 21);
            this.lblCorProduto.TabIndex = 18;
            this.lblCorProduto.Text = "Cor do Produto:";
            // 
            // cbNomeProd
            // 
            this.cbNomeProd.BackColor = System.Drawing.Color.White;
            this.cbNomeProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomeProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNomeProd.FormattingEnabled = true;
            this.cbNomeProd.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Preto - Claro",
            "Preto - Escuro",
            "Azul ",
            "Azul -Celeste",
            "Azul - Royal",
            "Azul - Marinho",
            "Azul - Claro",
            "Água-marinha",
            "Verde-mar",
            "Lima",
            "Verde-lima",
            "Verde-broto",
            "Chartreuse",
            "Verde-chá",
            "Verde - Aspargo",
            "Verde - Abacate",
            "Verde - Esmeralda",
            "Verde-bandeira",
            "Verde -Musgo",
            "Verde - Oliva",
            "Verde - Escuro",
            "Verde - Floresta",
            "Verde - Grama",
            "Verde - Jade",
            "Verde - Kentucky",
            "Verde - Primavera",
            "Verde - Turquesa",
            "Verde - Desbotado",
            "Verde - Fantasma",
            "Verde - Menta",
            "Verde - Exército",
            "Verde - Marciano",
            "Verde - Lunar"});
            this.cbNomeProd.Location = new System.Drawing.Point(198, 178);
            this.cbNomeProd.Name = "cbNomeProd";
            this.cbNomeProd.Size = new System.Drawing.Size(176, 29);
            this.cbNomeProd.TabIndex = 35;
            // 
            // frmNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1087, 914);
            this.Controls.Add(this.cmbTamVidro);
            this.Controls.Add(this.lblVendCarrinho);
            this.Controls.Add(this.dgVendAtual);
            this.Controls.Add(this.lblVendTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(174, 115);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nova Compra";
            this.Load += new System.EventHandler(this.frmNovaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendAtual)).EndInit();
            this.cmbTamVidro.ResumeLayout(false);
            this.cmbTamVidro.PerformLayout();
            this.grpDimencao.ResumeLayout(false);
            this.grpDimencao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.ComboBox cbTipoProdutoVenda;
        private System.Windows.Forms.Label lblTipoProduto;
        private System.Windows.Forms.Label lblVendTitulo;
        private System.Windows.Forms.DataGridView dgVendAtual;
        private System.Windows.Forms.Label lblVendCarrinho;
        private System.Windows.Forms.Panel cmbTamVidro;
        private System.Windows.Forms.Button btnVendConcluirCompra;
        private System.Windows.Forms.Label lblDimencao;
        private System.Windows.Forms.TextBox txtDimencao;
        private System.Windows.Forms.GroupBox grpDimencao;
        private System.Windows.Forms.Label lblComprimento;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.Label lblCorProduto;
        private System.Windows.Forms.ComboBox cbNomeProd;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Button button1;
    }
}