namespace T.I._2015
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pbSplash = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSplash
            // 
            this.pbSplash.ForeColor = System.Drawing.Color.Red;
            this.pbSplash.Location = new System.Drawing.Point(26, 289);
            this.pbSplash.Name = "pbSplash";
            this.pbSplash.Size = new System.Drawing.Size(643, 23);
            this.pbSplash.TabIndex = 2;
            this.pbSplash.UseWaitCursor = true;
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 25;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::T.I._2015.Properties.Resources.Logo_completo;
            this.pictureBox1.Location = new System.Drawing.Point(138, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.BackColor = System.Drawing.Color.Transparent;
            this.lblLoad.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.Color.White;
            this.lblLoad.Location = new System.Drawing.Point(22, 263);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(94, 23);
            this.lblLoad.TabIndex = 4;
            this.lblLoad.Text = "Carregando...";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(697, 361);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.pbSplash);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vidros Galego Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbSplash;
        protected System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoad;
    }
}

