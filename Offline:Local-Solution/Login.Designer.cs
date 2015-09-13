namespace T.I._2015
{
    partial class frmLogin
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
            this.txtLogNome = new System.Windows.Forms.TextBox();
            this.lblLogNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnLogCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogNome
            // 
            this.txtLogNome.Location = new System.Drawing.Point(147, 60);
            this.txtLogNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogNome.Name = "txtLogNome";
            this.txtLogNome.Size = new System.Drawing.Size(224, 25);
            this.txtLogNome.TabIndex = 0;
            // 
            // lblLogNome
            // 
            this.lblLogNome.AutoSize = true;
            this.lblLogNome.Location = new System.Drawing.Point(82, 63);
            this.lblLogNome.Name = "lblLogNome";
            this.lblLogNome.Size = new System.Drawing.Size(43, 17);
            this.lblLogNome.TabIndex = 1;
            this.lblLogNome.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(82, 96);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 17);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(147, 93);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(224, 25);
            this.txtSenha.TabIndex = 2;
            // 
            // pbLogin
            // 
            this.pbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogin.Image = global::T.I._2015.Properties.Resources.user_104;
            this.pbLogin.Location = new System.Drawing.Point(12, 22);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(43, 43);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 4;
            this.pbLogin.TabStop = false;
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Location = new System.Drawing.Point(147, 166);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(86, 28);
            this.btnLogar.TabIndex = 16;
            this.btnLogar.Text = "Entrar";
            this.btnLogar.UseVisualStyleBackColor = false;
            // 
            // btnLogCancelar
            // 
            this.btnLogCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogCancelar.Location = new System.Drawing.Point(325, 166);
            this.btnLogCancelar.Name = "btnLogCancelar";
            this.btnLogCancelar.Size = new System.Drawing.Size(86, 28);
            this.btnLogCancelar.TabIndex = 17;
            this.btnLogCancelar.Text = "Cancelar";
            this.btnLogCancelar.UseVisualStyleBackColor = false;
            this.btnLogCancelar.Click += new System.EventHandler(this.btnLogCancelar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 206);
            this.Controls.Add(this.btnLogCancelar);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblLogNome);
            this.Controls.Add(this.txtLogNome);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogNome;
        private System.Windows.Forms.Label lblLogNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnLogCancelar;
    }
}