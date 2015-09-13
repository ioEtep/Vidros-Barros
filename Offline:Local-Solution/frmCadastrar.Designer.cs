namespace T.I._2015
{
    partial class frmCadastrar
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
            this.lblCadFixo = new System.Windows.Forms.Label();
            this.lblCadCel = new System.Windows.Forms.Label();
            this.lblCadTipoCliente = new System.Windows.Forms.Label();
            this.cbCadTipoClienteCad = new System.Windows.Forms.ComboBox();
            this.txtCadEmailCad = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.txtCliNome = new System.Windows.Forms.TextBox();
            this.lblNomeClienteCad = new System.Windows.Forms.Label();
            this.lblCadastrarTitulo = new System.Windows.Forms.Label();
            this.btnPesqPesquisar = new System.Windows.Forms.Button();
            this.lblCadCPF = new System.Windows.Forms.Label();
            this.mskCadTelFix = new System.Windows.Forms.MaskedTextBox();
            this.mskCadTelCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskCadCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCadNomeEmpresa = new System.Windows.Forms.Label();
            this.txtCadNomeEmpresa = new System.Windows.Forms.TextBox();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.lblSexCli = new System.Windows.Forms.Label();
            this.cmbCliSex = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCadFixo
            // 
            this.lblCadFixo.AutoSize = true;
            this.lblCadFixo.ForeColor = System.Drawing.Color.White;
            this.lblCadFixo.Location = new System.Drawing.Point(398, 227);
            this.lblCadFixo.Name = "lblCadFixo";
            this.lblCadFixo.Size = new System.Drawing.Size(104, 21);
            this.lblCadFixo.TabIndex = 22;
            this.lblCadFixo.Text = "Telefone Fixo:";
            // 
            // lblCadCel
            // 
            this.lblCadCel.AutoSize = true;
            this.lblCadCel.ForeColor = System.Drawing.Color.White;
            this.lblCadCel.Location = new System.Drawing.Point(375, 276);
            this.lblCadCel.Name = "lblCadCel";
            this.lblCadCel.Size = new System.Drawing.Size(125, 21);
            this.lblCadCel.TabIndex = 18;
            this.lblCadCel.Text = "Telefone Celular:";
            // 
            // lblCadTipoCliente
            // 
            this.lblCadTipoCliente.AutoSize = true;
            this.lblCadTipoCliente.ForeColor = System.Drawing.Color.White;
            this.lblCadTipoCliente.Location = new System.Drawing.Point(735, 130);
            this.lblCadTipoCliente.Name = "lblCadTipoCliente";
            this.lblCadTipoCliente.Size = new System.Drawing.Size(116, 21);
            this.lblCadTipoCliente.TabIndex = 17;
            this.lblCadTipoCliente.Text = "Tipo de Cliente:";
            // 
            // cbCadTipoClienteCad
            // 
            this.cbCadTipoClienteCad.BackColor = System.Drawing.Color.White;
            this.cbCadTipoClienteCad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCadTipoClienteCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCadTipoClienteCad.FormattingEnabled = true;
            this.cbCadTipoClienteCad.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.cbCadTipoClienteCad.Location = new System.Drawing.Point(857, 127);
            this.cbCadTipoClienteCad.Name = "cbCadTipoClienteCad";
            this.cbCadTipoClienteCad.Size = new System.Drawing.Size(194, 29);
            this.cbCadTipoClienteCad.TabIndex = 16;
            this.cbCadTipoClienteCad.SelectedIndexChanged += new System.EventHandler(this.cbCadTipoClienteCad_SelectedIndexChanged);
            // 
            // txtCadEmailCad
            // 
            this.txtCadEmailCad.BackColor = System.Drawing.Color.White;
            this.txtCadEmailCad.Location = new System.Drawing.Point(508, 179);
            this.txtCadEmailCad.Name = "txtCadEmailCad";
            this.txtCadEmailCad.Size = new System.Drawing.Size(343, 29);
            this.txtCadEmailCad.TabIndex = 15;
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.ForeColor = System.Drawing.Color.White;
            this.lblEmailCad.Location = new System.Drawing.Point(377, 182);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(125, 21);
            this.lblEmailCad.TabIndex = 14;
            this.lblEmailCad.Text = "Email do Cliente:";
            // 
            // txtCliNome
            // 
            this.txtCliNome.BackColor = System.Drawing.Color.White;
            this.txtCliNome.Location = new System.Drawing.Point(510, 83);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.Size = new System.Drawing.Size(541, 29);
            this.txtCliNome.TabIndex = 13;
            this.txtCliNome.TabIndexChanged += new System.EventHandler(this.txtCadNomeClienteCad_TabIndexChanged);
            // 
            // lblNomeClienteCad
            // 
            this.lblNomeClienteCad.AutoSize = true;
            this.lblNomeClienteCad.ForeColor = System.Drawing.Color.White;
            this.lblNomeClienteCad.Location = new System.Drawing.Point(372, 86);
            this.lblNomeClienteCad.Name = "lblNomeClienteCad";
            this.lblNomeClienteCad.Size = new System.Drawing.Size(130, 21);
            this.lblNomeClienteCad.TabIndex = 12;
            this.lblNomeClienteCad.Text = "Nome do Cliente:\r\n";
            // 
            // lblCadastrarTitulo
            // 
            this.lblCadastrarTitulo.AutoSize = true;
            this.lblCadastrarTitulo.ForeColor = System.Drawing.Color.White;
            this.lblCadastrarTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblCadastrarTitulo.Name = "lblCadastrarTitulo";
            this.lblCadastrarTitulo.Size = new System.Drawing.Size(132, 21);
            this.lblCadastrarTitulo.TabIndex = 24;
            this.lblCadastrarTitulo.Text = "Cadastrar Cliente:";
            // 
            // btnPesqPesquisar
            // 
            this.btnPesqPesquisar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPesqPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesqPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesqPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqPesquisar.Location = new System.Drawing.Point(932, 526);
            this.btnPesqPesquisar.Name = "btnPesqPesquisar";
            this.btnPesqPesquisar.Size = new System.Drawing.Size(117, 53);
            this.btnPesqPesquisar.TabIndex = 29;
            this.btnPesqPesquisar.Text = "Cadastrar";
            this.btnPesqPesquisar.UseVisualStyleBackColor = false;
            // 
            // lblCadCPF
            // 
            this.lblCadCPF.AutoSize = true;
            this.lblCadCPF.ForeColor = System.Drawing.Color.White;
            this.lblCadCPF.Location = new System.Drawing.Point(460, 326);
            this.lblCadCPF.Name = "lblCadCPF";
            this.lblCadCPF.Size = new System.Drawing.Size(40, 21);
            this.lblCadCPF.TabIndex = 30;
            this.lblCadCPF.Text = "CPF:";
            this.lblCadCPF.Visible = false;
            // 
            // mskCadTelFix
            // 
            this.mskCadTelFix.Location = new System.Drawing.Point(508, 224);
            this.mskCadTelFix.Mask = "(99)9999-9999";
            this.mskCadTelFix.Name = "mskCadTelFix";
            this.mskCadTelFix.Size = new System.Drawing.Size(176, 29);
            this.mskCadTelFix.TabIndex = 31;
            this.mskCadTelFix.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCadTelFix_MaskInputRejected);
            this.mskCadTelFix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCadTelFix_KeyPress);
            // 
            // mskCadTelCelular
            // 
            this.mskCadTelCelular.Location = new System.Drawing.Point(508, 271);
            this.mskCadTelCelular.Mask = "(00)00000-0000";
            this.mskCadTelCelular.Name = "mskCadTelCelular";
            this.mskCadTelCelular.Size = new System.Drawing.Size(176, 29);
            this.mskCadTelCelular.TabIndex = 32;
            this.mskCadTelCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCadTelCelular_KeyPress);
            // 
            // mskCadCpf
            // 
            this.mskCadCpf.Location = new System.Drawing.Point(508, 323);
            this.mskCadCpf.Mask = "000.000.000.00";
            this.mskCadCpf.Name = "mskCadCpf";
            this.mskCadCpf.Size = new System.Drawing.Size(176, 29);
            this.mskCadCpf.TabIndex = 33;
            this.mskCadCpf.Visible = false;
            this.mskCadCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCadCpf_KeyPress);
            // 
            // lblCadNomeEmpresa
            // 
            this.lblCadNomeEmpresa.AutoSize = true;
            this.lblCadNomeEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblCadNomeEmpresa.Location = new System.Drawing.Point(727, 230);
            this.lblCadNomeEmpresa.Name = "lblCadNomeEmpresa";
            this.lblCadNomeEmpresa.Size = new System.Drawing.Size(141, 21);
            this.lblCadNomeEmpresa.TabIndex = 34;
            this.lblCadNomeEmpresa.Text = "Nome da Empresa:";
            this.lblCadNomeEmpresa.Visible = false;
            // 
            // txtCadNomeEmpresa
            // 
            this.txtCadNomeEmpresa.BackColor = System.Drawing.Color.White;
            this.txtCadNomeEmpresa.Location = new System.Drawing.Point(874, 227);
            this.txtCadNomeEmpresa.Name = "txtCadNomeEmpresa";
            this.txtCadNomeEmpresa.Size = new System.Drawing.Size(177, 29);
            this.txtCadNomeEmpresa.TabIndex = 35;
            this.txtCadNomeEmpresa.Visible = false;
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(874, 267);
            this.mskCNPJ.Mask = "99.999.999-999/99";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(176, 29);
            this.mskCNPJ.TabIndex = 37;
            this.mskCNPJ.Visible = false;
            this.mskCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCNPJ_MaskInputRejected);
            this.mskCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCNPJ_KeyPress);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.ForeColor = System.Drawing.Color.White;
            this.lblCnpj.Location = new System.Drawing.Point(818, 270);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(50, 21);
            this.lblCnpj.TabIndex = 36;
            this.lblCnpj.Text = "CNPJ:";
            this.lblCnpj.Visible = false;
            // 
            // txtCodCli
            // 
            this.txtCodCli.BackColor = System.Drawing.Color.White;
            this.txtCodCli.Location = new System.Drawing.Point(153, 83);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(176, 29);
            this.txtCodCli.TabIndex = 39;
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.ForeColor = System.Drawing.Color.White;
            this.lblCodCli.Location = new System.Drawing.Point(15, 86);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(137, 21);
            this.lblCodCli.TabIndex = 38;
            this.lblCodCli.Text = "Código do Cliente:\r\n";
            // 
            // lblSexCli
            // 
            this.lblSexCli.AutoSize = true;
            this.lblSexCli.ForeColor = System.Drawing.Color.White;
            this.lblSexCli.Location = new System.Drawing.Point(384, 130);
            this.lblSexCli.Name = "lblSexCli";
            this.lblSexCli.Size = new System.Drawing.Size(120, 21);
            this.lblSexCli.TabIndex = 41;
            this.lblSexCli.Text = "Sexo do Cliente:";
            // 
            // cmbCliSex
            // 
            this.cmbCliSex.BackColor = System.Drawing.Color.White;
            this.cmbCliSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliSex.FormattingEnabled = true;
            this.cmbCliSex.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbCliSex.Location = new System.Drawing.Point(510, 127);
            this.cmbCliSex.Name = "cmbCliSex";
            this.cmbCliSex.Size = new System.Drawing.Size(176, 29);
            this.cmbCliSex.TabIndex = 40;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.Location = new System.Drawing.Point(508, 371);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(541, 29);
            this.txtEndereco.TabIndex = 43;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.ForeColor = System.Drawing.Color.White;
            this.lblEndereco.Location = new System.Drawing.Point(423, 374);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 21);
            this.lblEndereco.TabIndex = 42;
            this.lblEndereco.Text = "Endereco:";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.Location = new System.Drawing.Point(873, 419);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(176, 29);
            this.txtBairro.TabIndex = 45;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.ForeColor = System.Drawing.Color.White;
            this.lblCEP.Location = new System.Drawing.Point(460, 419);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(40, 21);
            this.lblCEP.TabIndex = 44;
            this.lblCEP.Text = "CEP:";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(506, 416);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(176, 29);
            this.mskCEP.TabIndex = 46;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(812, 422);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 21);
            this.lblBairro.TabIndex = 47;
            this.lblBairro.Text = "Bairro:";
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1087, 914);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblSexCli);
            this.Controls.Add(this.cmbCliSex);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.lblCodCli);
            this.Controls.Add(this.mskCNPJ);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.txtCadNomeEmpresa);
            this.Controls.Add(this.lblCadNomeEmpresa);
            this.Controls.Add(this.mskCadCpf);
            this.Controls.Add(this.mskCadTelCelular);
            this.Controls.Add(this.mskCadTelFix);
            this.Controls.Add(this.lblCadCPF);
            this.Controls.Add(this.btnPesqPesquisar);
            this.Controls.Add(this.lblCadastrarTitulo);
            this.Controls.Add(this.lblCadFixo);
            this.Controls.Add(this.lblCadCel);
            this.Controls.Add(this.lblCadTipoCliente);
            this.Controls.Add(this.cbCadTipoClienteCad);
            this.Controls.Add(this.txtCadEmailCad);
            this.Controls.Add(this.lblEmailCad);
            this.Controls.Add(this.txtCliNome);
            this.Controls.Add(this.lblNomeClienteCad);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(174, 115);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.frmCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadFixo;
        private System.Windows.Forms.Label lblCadCel;
        private System.Windows.Forms.Label lblCadTipoCliente;
        private System.Windows.Forms.ComboBox cbCadTipoClienteCad;
        private System.Windows.Forms.TextBox txtCadEmailCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.TextBox txtCliNome;
        private System.Windows.Forms.Label lblNomeClienteCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCadastrarTitulo;
        private System.Windows.Forms.Button btnPesqPesquisar;
        private System.Windows.Forms.Label lblCadCPF;
        private System.Windows.Forms.MaskedTextBox mskCadTelFix;
        private System.Windows.Forms.MaskedTextBox mskCadTelCelular;
        private System.Windows.Forms.MaskedTextBox mskCadCpf;
        private System.Windows.Forms.Label lblCadNomeEmpresa;
        private System.Windows.Forms.TextBox txtCadNomeEmpresa;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.Label lblSexCli;
        private System.Windows.Forms.ComboBox cmbCliSex;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblBairro;
    }
}