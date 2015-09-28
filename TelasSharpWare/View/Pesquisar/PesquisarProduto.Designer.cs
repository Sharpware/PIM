namespace TelasSharpWare
{
    partial class PesquisarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tipoProdutoCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tamanhoTbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeProdutoTbx = new System.Windows.Forms.TextBox();
            this.idProdutoTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.marcaProdutoTbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pesquisaProdutosDgv = new System.Windows.Forms.DataGridView();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoPrdouto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamanhoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fecharBtn = new System.Windows.Forms.Button();
            this.finalizarPesquisaProdutoBtn = new TelasSharpWare.Botoes.BotaoFinalizarPesquisa();
            this.pesquisarProdutosBtn = new TelasSharpWare.Botoes.BotaoPesqProduto();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaProdutosDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(753, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 227);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tipoProdutoCbx);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tamanhoTbx);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nomeProdutoTbx);
            this.panel2.Controls.Add(this.idProdutoTbx);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.marcaProdutoTbx);
            this.panel2.Location = new System.Drawing.Point(200, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 227);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(31, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo";
            // 
            // tipoProdutoCbx
            // 
            this.tipoProdutoCbx.FormattingEnabled = true;
            this.tipoProdutoCbx.Items.AddRange(new object[] {
            "Corrida ou caminhada",
            "Corrida performance",
            "Skate",
            "Surf",
            "Chuteira de salão",
            "Chuteira de campo",
            "Vôlei",
            "Fitness e musculação",
            "Basquete"});
            this.tipoProdutoCbx.Location = new System.Drawing.Point(35, 84);
            this.tipoProdutoCbx.Name = "tipoProdutoCbx";
            this.tipoProdutoCbx.Size = new System.Drawing.Size(305, 21);
            this.tipoProdutoCbx.TabIndex = 8;
            this.tipoProdutoCbx.Text = "Todos--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(360, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tamanho";
            // 
            // tamanhoTbx
            // 
            this.tamanhoTbx.FormattingEnabled = true;
            this.tamanhoTbx.Items.AddRange(new object[] {
            "34-35",
            "35-36",
            "36-37",
            "37-38",
            "38-39",
            "39-40",
            "40-41",
            "41-42",
            "42-43",
            "43-44",
            "44-45",
            "45+"});
            this.tamanhoTbx.Location = new System.Drawing.Point(364, 184);
            this.tamanhoTbx.Name = "tamanhoTbx";
            this.tamanhoTbx.Size = new System.Drawing.Size(78, 21);
            this.tamanhoTbx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome do produto";
            // 
            // nomeProdutoTbx
            // 
            this.nomeProdutoTbx.Location = new System.Drawing.Point(35, 185);
            this.nomeProdutoTbx.Name = "nomeProdutoTbx";
            this.nomeProdutoTbx.Size = new System.Drawing.Size(305, 20);
            this.nomeProdutoTbx.TabIndex = 4;
            // 
            // idProdutoTbx
            // 
            this.idProdutoTbx.Location = new System.Drawing.Point(35, 37);
            this.idProdutoTbx.Name = "idProdutoTbx";
            this.idProdutoTbx.Size = new System.Drawing.Size(128, 20);
            this.idProdutoTbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(31, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // marcaProdutoTbx
            // 
            this.marcaProdutoTbx.FormattingEnabled = true;
            this.marcaProdutoTbx.Items.AddRange(new object[] {
            "NIKE",
            "ADIDAS",
            "PUMA",
            "MIZUNO",
            "ASICS",
            "OAKLEY",
            "OLIMPIKUS",
            "TIMBERLAND"});
            this.marcaProdutoTbx.Location = new System.Drawing.Point(35, 137);
            this.marcaProdutoTbx.Name = "marcaProdutoTbx";
            this.marcaProdutoTbx.Size = new System.Drawing.Size(305, 21);
            this.marcaProdutoTbx.TabIndex = 0;
            this.marcaProdutoTbx.Text = "Todos--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(264, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(822, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "PESQUISAR PRODUTO";
            // 
            // pesquisaProdutosDgv
            // 
            this.pesquisaProdutosDgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pesquisaProdutosDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pesquisaProdutosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pesquisaProdutosDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduto,
            this.Tipo,
            this.NomeProduto,
            this.DescricaoPrdouto,
            this.TamanhoProduto,
            this.ValorProduto,
            this.Quantidade});
            this.pesquisaProdutosDgv.Location = new System.Drawing.Point(190, 366);
            this.pesquisaProdutosDgv.Name = "pesquisaProdutosDgv";
            this.pesquisaProdutosDgv.Size = new System.Drawing.Size(931, 191);
            this.pesquisaProdutosDgv.TabIndex = 3;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.HeaderText = "Codigo";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            this.CodigoProduto.Width = 150;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome do produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 200;
            // 
            // DescricaoPrdouto
            // 
            this.DescricaoPrdouto.HeaderText = "Descrição";
            this.DescricaoPrdouto.Name = "DescricaoPrdouto";
            this.DescricaoPrdouto.ReadOnly = true;
            this.DescricaoPrdouto.Width = 220;
            // 
            // TamanhoProduto
            // 
            this.TamanhoProduto.HeaderText = "Tamanho";
            this.TamanhoProduto.Name = "TamanhoProduto";
            this.TamanhoProduto.ReadOnly = true;
            this.TamanhoProduto.Width = 70;
            // 
            // ValorProduto
            // 
            this.ValorProduto.HeaderText = "Valor";
            this.ValorProduto.Name = "ValorProduto";
            this.ValorProduto.ReadOnly = true;
            this.ValorProduto.Width = 70;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade em estoque";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(279, 593);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 139);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fecharBtn
            // 
            this.fecharBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fecharBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.fecharBtn.Location = new System.Drawing.Point(1313, 3);
            this.fecharBtn.Name = "fecharBtn";
            this.fecharBtn.Size = new System.Drawing.Size(38, 32);
            this.fecharBtn.TabIndex = 6;
            this.fecharBtn.Text = "X";
            this.fecharBtn.UseVisualStyleBackColor = true;
            this.fecharBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalizarPesquisaProdutoBtn
            // 
            this.finalizarPesquisaProdutoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalizarPesquisaProdutoBtn.BackgroundImage")));
            this.finalizarPesquisaProdutoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finalizarPesquisaProdutoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizarPesquisaProdutoBtn.Location = new System.Drawing.Point(1122, 687);
            this.finalizarPesquisaProdutoBtn.Name = "finalizarPesquisaProdutoBtn";
            this.finalizarPesquisaProdutoBtn.Size = new System.Drawing.Size(220, 60);
            this.finalizarPesquisaProdutoBtn.TabIndex = 5;
            // 
            // pesquisarProdutosBtn
            // 
            this.pesquisarProdutosBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pesquisarProdutosBtn.BackgroundImage")));
            this.pesquisarProdutosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pesquisarProdutosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisarProdutosBtn.Location = new System.Drawing.Point(1122, 604);
            this.pesquisarProdutosBtn.Name = "pesquisarProdutosBtn";
            this.pesquisarProdutosBtn.Size = new System.Drawing.Size(220, 67);
            this.pesquisarProdutosBtn.TabIndex = 7;
            // 
            // PesquisarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1354, 759);
            this.ControlBox = false;
            this.Controls.Add(this.pesquisarProdutosBtn);
            this.Controls.Add(this.fecharBtn);
            this.Controls.Add(this.finalizarPesquisaProdutoBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pesquisaProdutosDgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaProdutosDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeProdutoTbx;
        private System.Windows.Forms.TextBox idProdutoTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox marcaProdutoTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pesquisaProdutosDgv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Botoes.BotaoFinalizarPesquisa finalizarPesquisaProdutoBtn;
        private System.Windows.Forms.Button fecharBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipoProdutoCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tamanhoTbx;
        private Botoes.BotaoPesqProduto pesquisarProdutosBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoPrdouto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamanhoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}