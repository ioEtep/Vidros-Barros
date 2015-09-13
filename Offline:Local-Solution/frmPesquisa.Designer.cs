namespace T.I._2015
{
    partial class frmPesquisar
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
            this.btnPesqExcluir = new System.Windows.Forms.Button();
            this.btnPesqPesquisar = new System.Windows.Forms.Button();
            this.cbPesqTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoPecaPesq = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnPesqAnterior = new System.Windows.Forms.Button();
            this.btnPesqProximo = new System.Windows.Forms.Button();
            this.grpPesq = new System.Windows.Forms.GroupBox();
            this.txtPesqNomeCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.txtPesqNomeVend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPesqVend = new System.Windows.Forms.GroupBox();
            this.txtCodVend = new System.Windows.Forms.TextBox();
            this.lblNVenda = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblM2 = new System.Windows.Forms.Label();
            this.lblDimencao = new System.Windows.Forms.Label();
            this.txtDimencao = new System.Windows.Forms.TextBox();
            this.lblCorProduto = new System.Windows.Forms.Label();
            this.cbNomeProd = new System.Windows.Forms.ComboBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.grpPesq.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.grpPesqVend.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesqExcluir
            // 
            this.btnPesqExcluir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPesqExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesqExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesqExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnPesqExcluir.Location = new System.Drawing.Point(217, 357);
            this.btnPesqExcluir.Name = "btnPesqExcluir";
            this.btnPesqExcluir.Size = new System.Drawing.Size(98, 37);
            this.btnPesqExcluir.TabIndex = 29;
            this.btnPesqExcluir.Text = "Excluir";
            this.btnPesqExcluir.UseVisualStyleBackColor = false;
            // 
            // btnPesqPesquisar
            // 
            this.btnPesqPesquisar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPesqPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesqPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesqPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesqPesquisar.Location = new System.Drawing.Point(314, 97);
            this.btnPesqPesquisar.Name = "btnPesqPesquisar";
            this.btnPesqPesquisar.Size = new System.Drawing.Size(98, 36);
            this.btnPesqPesquisar.TabIndex = 28;
            this.btnPesqPesquisar.Text = "Pesquisar";
            this.btnPesqPesquisar.UseVisualStyleBackColor = false;
            this.btnPesqPesquisar.Click += new System.EventHandler(this.btnPesqPesquisar_Click);
            // 
            // cbPesqTipo
            // 
            this.cbPesqTipo.BackColor = System.Drawing.Color.White;
            this.cbPesqTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesqTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPesqTipo.FormattingEnabled = true;
            this.cbPesqTipo.Items.AddRange(new object[] {
            "Vidros",
            "Insufilmes",
            "Espelhos",
            "Portas",
            "Esquadrilhas",
            "Forros",
            "Divisórias"});
            this.cbPesqTipo.Location = new System.Drawing.Point(165, 134);
            this.cbPesqTipo.Name = "cbPesqTipo";
            this.cbPesqTipo.Size = new System.Drawing.Size(176, 29);
            this.cbPesqTipo.TabIndex = 20;
            this.cbPesqTipo.TabIndexChanged += new System.EventHandler(this.txtPesqQtdEstoque_TabIndexChanged);
            this.cbPesqTipo.TextChanged += new System.EventHandler(this.cbPesqTipo_TextChanged);
            // 
            // lblTipoPecaPesq
            // 
            this.lblTipoPecaPesq.AutoSize = true;
            this.lblTipoPecaPesq.ForeColor = System.Drawing.Color.White;
            this.lblTipoPecaPesq.Location = new System.Drawing.Point(59, 137);
            this.lblTipoPecaPesq.Name = "lblTipoPecaPesq";
            this.lblTipoPecaPesq.Size = new System.Drawing.Size(100, 21);
            this.lblTipoPecaPesq.TabIndex = 19;
            this.lblTipoPecaPesq.Text = "Tipo de Peca:";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.ForeColor = System.Drawing.Color.White;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 9);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(80, 21);
            this.lblPesquisa.TabIndex = 30;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // btnPesqAnterior
            // 
            this.btnPesqAnterior.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPesqAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesqAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesqAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqAnterior.ForeColor = System.Drawing.Color.Black;
            this.btnPesqAnterior.Location = new System.Drawing.Point(34, 357);
            this.btnPesqAnterior.Name = "btnPesqAnterior";
            this.btnPesqAnterior.Size = new System.Drawing.Size(91, 37);
            this.btnPesqAnterior.TabIndex = 31;
            this.btnPesqAnterior.Text = "Anterior";
            this.btnPesqAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPesqProximo
            // 
            this.btnPesqProximo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPesqProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqProximo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesqProximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesqProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqProximo.ForeColor = System.Drawing.Color.Black;
            this.btnPesqProximo.Location = new System.Drawing.Point(400, 357);
            this.btnPesqProximo.Name = "btnPesqProximo";
            this.btnPesqProximo.Size = new System.Drawing.Size(98, 37);
            this.btnPesqProximo.TabIndex = 32;
            this.btnPesqProximo.Text = "Proximo";
            this.btnPesqProximo.UseVisualStyleBackColor = false;
            // 
            // grpPesq
            // 
            this.grpPesq.Controls.Add(this.txtPesqNomeCli);
            this.grpPesq.Controls.Add(this.label1);
            this.grpPesq.Controls.Add(this.btnPesqPesquisar);
            this.grpPesq.ForeColor = System.Drawing.Color.White;
            this.grpPesq.Location = new System.Drawing.Point(45, 66);
            this.grpPesq.Name = "grpPesq";
            this.grpPesq.Size = new System.Drawing.Size(440, 148);
            this.grpPesq.TabIndex = 35;
            this.grpPesq.TabStop = false;
            this.grpPesq.Text = "Pesquisar";
            // 
            // txtPesqNomeCli
            // 
            this.txtPesqNomeCli.BackColor = System.Drawing.Color.White;
            this.txtPesqNomeCli.Location = new System.Drawing.Point(141, 43);
            this.txtPesqNomeCli.Name = "txtPesqNomeCli";
            this.txtPesqNomeCli.Size = new System.Drawing.Size(271, 29);
            this.txtPesqNomeCli.TabIndex = 36;
            this.txtPesqNomeCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome do Cliente:";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtPesqNomeVend);
            this.grpDados.Controls.Add(this.lblM2);
            this.grpDados.Controls.Add(this.btnPesqExcluir);
            this.grpDados.Controls.Add(this.btnPesqAnterior);
            this.grpDados.Controls.Add(this.lblDimencao);
            this.grpDados.Controls.Add(this.lblTotalCompra);
            this.grpDados.Controls.Add(this.txtTotalCompra);
            this.grpDados.Controls.Add(this.txtDimencao);
            this.grpDados.Controls.Add(this.label2);
            this.grpDados.Controls.Add(this.btnPesqProximo);
            this.grpDados.Controls.Add(this.lblCorProduto);
            this.grpDados.Controls.Add(this.lblNomeCliente);
            this.grpDados.Controls.Add(this.cbPesqTipo);
            this.grpDados.Controls.Add(this.cbNomeProd);
            this.grpDados.Controls.Add(this.lblTipoPecaPesq);
            this.grpDados.Controls.Add(this.txtNomeCliente);
            this.grpDados.ForeColor = System.Drawing.Color.White;
            this.grpDados.Location = new System.Drawing.Point(541, 66);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(511, 420);
            this.grpDados.TabIndex = 36;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados";
            // 
            // txtPesqNomeVend
            // 
            this.txtPesqNomeVend.BackColor = System.Drawing.Color.White;
            this.txtPesqNomeVend.Location = new System.Drawing.Point(174, 79);
            this.txtPesqNomeVend.Name = "txtPesqNomeVend";
            this.txtPesqNomeVend.Size = new System.Drawing.Size(324, 29);
            this.txtPesqNomeVend.TabIndex = 38;
            this.txtPesqNomeVend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome do Vendedor:";
            // 
            // grpPesqVend
            // 
            this.grpPesqVend.Controls.Add(this.txtCodVend);
            this.grpPesqVend.Controls.Add(this.lblNVenda);
            this.grpPesqVend.Controls.Add(this.button1);
            this.grpPesqVend.ForeColor = System.Drawing.Color.White;
            this.grpPesqVend.Location = new System.Drawing.Point(45, 276);
            this.grpPesqVend.Name = "grpPesqVend";
            this.grpPesqVend.Size = new System.Drawing.Size(440, 148);
            this.grpPesqVend.TabIndex = 37;
            this.grpPesqVend.TabStop = false;
            this.grpPesqVend.Text = "Pesquisar pela Venda";
            // 
            // txtCodVend
            // 
            this.txtCodVend.BackColor = System.Drawing.Color.White;
            this.txtCodVend.Location = new System.Drawing.Point(144, 43);
            this.txtCodVend.Name = "txtCodVend";
            this.txtCodVend.Size = new System.Drawing.Size(271, 29);
            this.txtCodVend.TabIndex = 36;
            this.txtCodVend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNVenda
            // 
            this.lblNVenda.AutoSize = true;
            this.lblNVenda.ForeColor = System.Drawing.Color.White;
            this.lblNVenda.Location = new System.Drawing.Point(6, 46);
            this.lblNVenda.Name = "lblNVenda";
            this.lblNVenda.Size = new System.Drawing.Size(132, 21);
            this.lblNVenda.TabIndex = 35;
            this.lblNVenda.Text = "Código da Venda:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(314, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.ForeColor = System.Drawing.Color.White;
            this.lblM2.Location = new System.Drawing.Point(252, 228);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(30, 21);
            this.lblM2.TabIndex = 61;
            this.lblM2.Text = "m²";
            // 
            // lblDimencao
            // 
            this.lblDimencao.AutoSize = true;
            this.lblDimencao.ForeColor = System.Drawing.Color.White;
            this.lblDimencao.Location = new System.Drawing.Point(85, 228);
            this.lblDimencao.Name = "lblDimencao";
            this.lblDimencao.Size = new System.Drawing.Size(83, 21);
            this.lblDimencao.TabIndex = 58;
            this.lblDimencao.Text = "Dimenção:";
            // 
            // txtDimencao
            // 
            this.txtDimencao.Enabled = false;
            this.txtDimencao.Location = new System.Drawing.Point(174, 225);
            this.txtDimencao.Name = "txtDimencao";
            this.txtDimencao.Size = new System.Drawing.Size(72, 29);
            this.txtDimencao.TabIndex = 60;
            // 
            // lblCorProduto
            // 
            this.lblCorProduto.AutoSize = true;
            this.lblCorProduto.ForeColor = System.Drawing.Color.White;
            this.lblCorProduto.Location = new System.Drawing.Point(39, 176);
            this.lblCorProduto.Name = "lblCorProduto";
            this.lblCorProduto.Size = new System.Drawing.Size(120, 21);
            this.lblCorProduto.TabIndex = 50;
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
            this.cbNomeProd.Location = new System.Drawing.Point(165, 173);
            this.cbNomeProd.Name = "cbNomeProd";
            this.cbNomeProd.Size = new System.Drawing.Size(176, 29);
            this.cbNomeProd.TabIndex = 57;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCliente.Location = new System.Drawing.Point(19, 41);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(130, 21);
            this.lblNomeCliente.TabIndex = 53;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Location = new System.Drawing.Point(165, 275);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(176, 29);
            this.txtTotalCompra.TabIndex = 56;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.White;
            this.txtNomeCliente.Location = new System.Drawing.Point(155, 38);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(343, 29);
            this.txtNomeCliente.TabIndex = 54;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.ForeColor = System.Drawing.Color.White;
            this.lblTotalCompra.Location = new System.Drawing.Point(105, 278);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(54, 21);
            this.lblTotalCompra.TabIndex = 55;
            this.lblTotalCompra.Text = "Valor :";
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1087, 914);
            this.Controls.Add(this.grpPesqVend);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.grpPesq);
            this.Controls.Add(this.lblPesquisa);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(174, 115);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.frmNovaCompra_Load);
            this.grpPesq.ResumeLayout(false);
            this.grpPesq.PerformLayout();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpPesqVend.ResumeLayout(false);
            this.grpPesqVend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesqExcluir;
        private System.Windows.Forms.Button btnPesqPesquisar;
        private System.Windows.Forms.ComboBox cbPesqTipo;
        private System.Windows.Forms.Label lblTipoPecaPesq;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnPesqAnterior;
        private System.Windows.Forms.Button btnPesqProximo;
        private System.Windows.Forms.GroupBox grpPesq;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.TextBox txtPesqNomeCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesqNomeVend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPesqVend;
        private System.Windows.Forms.TextBox txtCodVend;
        private System.Windows.Forms.Label lblNVenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.Label lblDimencao;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.TextBox txtDimencao;
        private System.Windows.Forms.Label lblCorProduto;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.ComboBox cbNomeProd;
        private System.Windows.Forms.TextBox txtNomeCliente;
    }
}