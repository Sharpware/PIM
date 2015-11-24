namespace TelasSharpWare.View.Relatorio
{
    partial class RelatorioVendaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioVendaCliente));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizarBtn = new System.Windows.Forms.Button();
            this.fecharBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExibeRelatoriobtn = new System.Windows.Forms.Button();
            this.ParametroIdVendacbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sairBtn = new TelasSharpWare.Botoes.BotaoSair();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.minimizarBtn);
            this.panel3.Controls.Add(this.fecharBtn);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 37);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(190, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 35);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // minimizarBtn
            // 
            this.minimizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizarBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimizarBtn.Location = new System.Drawing.Point(538, -1);
            this.minimizarBtn.Name = "minimizarBtn";
            this.minimizarBtn.Size = new System.Drawing.Size(38, 32);
            this.minimizarBtn.TabIndex = 6;
            this.minimizarBtn.Text = "-";
            this.minimizarBtn.UseVisualStyleBackColor = true;
            this.minimizarBtn.Click += new System.EventHandler(this.minimizarBtn_Click);
            // 
            // fecharBtn
            // 
            this.fecharBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fecharBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fecharBtn.Location = new System.Drawing.Point(581, -1);
            this.fecharBtn.Name = "fecharBtn";
            this.fecharBtn.Size = new System.Drawing.Size(38, 32);
            this.fecharBtn.TabIndex = 5;
            this.fecharBtn.Text = "X";
            this.fecharBtn.UseVisualStyleBackColor = true;
            this.fecharBtn.Click += new System.EventHandler(this.fecharBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExibeRelatoriobtn);
            this.panel1.Controls.Add(this.ParametroIdVendacbx);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(29, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 180);
            this.panel1.TabIndex = 7;
            // 
            // ExibeRelatoriobtn
            // 
            this.ExibeRelatoriobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExibeRelatoriobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExibeRelatoriobtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExibeRelatoriobtn.Location = new System.Drawing.Point(356, 100);
            this.ExibeRelatoriobtn.Name = "ExibeRelatoriobtn";
            this.ExibeRelatoriobtn.Size = new System.Drawing.Size(207, 34);
            this.ExibeRelatoriobtn.TabIndex = 3;
            this.ExibeRelatoriobtn.Text = "Exibir Relatório";
            this.ExibeRelatoriobtn.UseVisualStyleBackColor = true;
            this.ExibeRelatoriobtn.Click += new System.EventHandler(this.ExibeRelatoriobtn_Click);
            // 
            // ParametroIdVendacbx
            // 
            this.ParametroIdVendacbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParametroIdVendacbx.FormattingEnabled = true;
            this.ParametroIdVendacbx.Location = new System.Drawing.Point(45, 105);
            this.ParametroIdVendacbx.Name = "ParametroIdVendacbx";
            this.ParametroIdVendacbx.Size = new System.Drawing.Size(292, 28);
            this.ParametroIdVendacbx.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(3, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(554, 45);
            this.label8.TabIndex = 1;
            this.label8.Text = "Relatório de Venda por Cliente";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // sairBtn
            // 
            this.sairBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sairBtn.BackgroundImage")));
            this.sairBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sairBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sairBtn.Location = new System.Drawing.Point(459, 249);
            this.sairBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(160, 60);
            this.sairBtn.TabIndex = 44;
            this.sairBtn.Load += new System.EventHandler(this.sairBtn_Load);
            // 
            // RelatorioVendaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(644, 321);
            this.Controls.Add(this.sairBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioVendaCliente";
            this.Text = "RelatorioVendaCliente";
            this.Load += new System.EventHandler(this.RelatorioVendaCliente_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minimizarBtn;
        private System.Windows.Forms.Button fecharBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private TelasSharpWare.Botoes.BotaoSair sairBtn;
        private System.Windows.Forms.Button ExibeRelatoriobtn;
        private System.Windows.Forms.ComboBox ParametroIdVendacbx;
    }
}