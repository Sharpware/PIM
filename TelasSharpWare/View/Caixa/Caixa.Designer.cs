namespace TelasSharpWare
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            this.vendaProdutosDgv = new System.Windows.Forms.DataGridView();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoPrdouto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamanhoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.valorTotalLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantidadeItensLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valorProdutoLbl = new System.Windows.Forms.Label();
            this.idProdutoTbx = new System.Windows.Forms.TextBox();
            this.nomeProdutoTbx = new System.Windows.Forms.TextBox();
            this.descricaoProdutoTbx = new System.Windows.Forms.TextBox();
            this.tamanhoTbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CaixaSsl = new System.Windows.Forms.ToolStripStatusLabel();
            this.vendedorVendaCbx = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clienteVendaTbx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.atalhosBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fecharBtn = new System.Windows.Forms.Button();
            this.atalhosPnl = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoCancelarVenda1 = new TelasSharpWare.View.Botoes.BotaoCancelarVenda();
            this.modoDePagamentoBtn = new TelasSharpWare.View.Botoes.BotaoModoDePagamento();
            this.adicionarClienteBtn = new TelasSharpWare.Botoes.BotaoAdicionarClienteCaixa();
            this.finalizarVenda = new TelasSharpWare.Botoes.BotaoFinalizarVenda();
            this.adicionarProdutoBtn = new TelasSharpWare.Botoes.BotaoAdProduto();
            ((System.ComponentModel.ISupportInitialize)(this.vendaProdutosDgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.atalhosPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // vendaProdutosDgv
            // 
            this.vendaProdutosDgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vendaProdutosDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendaProdutosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendaProdutosDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduto,
            this.NomeProduto,
            this.DescricaoPrdouto,
            this.TamanhoProduto,
            this.ValorProduto});
            this.vendaProdutosDgv.Location = new System.Drawing.Point(536, 62);
            this.vendaProdutosDgv.Name = "vendaProdutosDgv";
            this.vendaProdutosDgv.Size = new System.Drawing.Size(703, 246);
            this.vendaProdutosDgv.TabIndex = 1;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.HeaderText = "Codigo";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            this.CodigoProduto.Width = 150;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 150;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor do produto: R$";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 356);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.valorTotalLbl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.quantidadeItensLbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(14, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 203);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(144, 150);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 33);
            this.label21.TabIndex = 7;
            this.label21.Text = "0,00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(314, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 33);
            this.label20.TabIndex = 6;
            this.label20.Text = "0,00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(312, 33);
            this.label19.TabIndex = 5;
            this.label19.Text = "Pagamento cliente: R$";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 33);
            this.label18.TabIndex = 4;
            this.label18.Text = "Troco: R$";
            // 
            // valorTotalLbl
            // 
            this.valorTotalLbl.AutoSize = true;
            this.valorTotalLbl.Location = new System.Drawing.Point(208, 64);
            this.valorTotalLbl.Name = "valorTotalLbl";
            this.valorTotalLbl.Size = new System.Drawing.Size(71, 33);
            this.valorTotalLbl.TabIndex = 3;
            this.valorTotalLbl.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valor Total: R$";
            // 
            // quantidadeItensLbl
            // 
            this.quantidadeItensLbl.AutoSize = true;
            this.quantidadeItensLbl.Font = new System.Drawing.Font("Arial Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeItensLbl.Location = new System.Drawing.Point(322, 29);
            this.quantidadeItensLbl.Name = "quantidadeItensLbl";
            this.quantidadeItensLbl.Size = new System.Drawing.Size(53, 38);
            this.quantidadeItensLbl.TabIndex = 1;
            this.quantidadeItensLbl.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade de itens:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.valorProdutoLbl);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // valorProdutoLbl
            // 
            this.valorProdutoLbl.AutoSize = true;
            this.valorProdutoLbl.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorProdutoLbl.Location = new System.Drawing.Point(290, 48);
            this.valorProdutoLbl.Name = "valorProdutoLbl";
            this.valorProdutoLbl.Size = new System.Drawing.Size(71, 33);
            this.valorProdutoLbl.TabIndex = 3;
            this.valorProdutoLbl.Text = "0,00";
            // 
            // idProdutoTbx
            // 
            this.idProdutoTbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProdutoTbx.ForeColor = System.Drawing.SystemColors.WindowText;
            this.idProdutoTbx.Location = new System.Drawing.Point(18, 27);
            this.idProdutoTbx.Name = "idProdutoTbx";
            this.idProdutoTbx.Size = new System.Drawing.Size(412, 22);
            this.idProdutoTbx.TabIndex = 4;
            // 
            // nomeProdutoTbx
            // 
            this.nomeProdutoTbx.Enabled = false;
            this.nomeProdutoTbx.Location = new System.Drawing.Point(18, 72);
            this.nomeProdutoTbx.Name = "nomeProdutoTbx";
            this.nomeProdutoTbx.ReadOnly = true;
            this.nomeProdutoTbx.Size = new System.Drawing.Size(412, 20);
            this.nomeProdutoTbx.TabIndex = 6;
            // 
            // descricaoProdutoTbx
            // 
            this.descricaoProdutoTbx.Enabled = false;
            this.descricaoProdutoTbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoProdutoTbx.Location = new System.Drawing.Point(18, 115);
            this.descricaoProdutoTbx.Multiline = true;
            this.descricaoProdutoTbx.Name = "descricaoProdutoTbx";
            this.descricaoProdutoTbx.ReadOnly = true;
            this.descricaoProdutoTbx.Size = new System.Drawing.Size(412, 80);
            this.descricaoProdutoTbx.TabIndex = 7;
            // 
            // tamanhoTbx
            // 
            this.tamanhoTbx.Enabled = false;
            this.tamanhoTbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanhoTbx.Location = new System.Drawing.Point(447, 27);
            this.tamanhoTbx.Name = "tamanhoTbx";
            this.tamanhoTbx.ReadOnly = true;
            this.tamanhoTbx.Size = new System.Drawing.Size(51, 22);
            this.tamanhoTbx.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nome do produto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Descrição:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(533, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Selecione o vendedor:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaixaSsl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 736);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1368, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CaixaSsl
            // 
            this.CaixaSsl.BackColor = System.Drawing.SystemColors.Control;
            this.CaixaSsl.Name = "CaixaSsl";
            this.CaixaSsl.Size = new System.Drawing.Size(35, 17);
            this.CaixaSsl.Text = "Caixa";
            // 
            // vendedorVendaCbx
            // 
            this.vendedorVendaCbx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorVendaCbx.FormattingEnabled = true;
            this.vendedorVendaCbx.Items.AddRange(new object[] {
            "Carlos Aurea",
            "Pedro Felipe",
            "Lucas Henrique",
            "Marisa Santana"});
            this.vendedorVendaCbx.Location = new System.Drawing.Point(536, 416);
            this.vendedorVendaCbx.Name = "vendedorVendaCbx";
            this.vendedorVendaCbx.Size = new System.Drawing.Size(430, 25);
            this.vendedorVendaCbx.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.panel3.Controls.Add(this.adicionarProdutoBtn);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tamanhoTbx);
            this.panel3.Controls.Add(this.descricaoProdutoTbx);
            this.panel3.Controls.Add(this.idProdutoTbx);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.nomeProdutoTbx);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(536, 454);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 270);
            this.panel3.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(444, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tamanho:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Digite o codigo do produto:";
            // 
            // clienteVendaTbx
            // 
            this.clienteVendaTbx.Enabled = false;
            this.clienteVendaTbx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteVendaTbx.Location = new System.Drawing.Point(536, 368);
            this.clienteVendaTbx.Name = "clienteVendaTbx";
            this.clienteVendaTbx.ReadOnly = true;
            this.clienteVendaTbx.Size = new System.Drawing.Size(430, 25);
            this.clienteVendaTbx.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(533, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cliente:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.atalhosBtn);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.fecharBtn);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1368, 37);
            this.panel4.TabIndex = 22;
            // 
            // atalhosBtn
            // 
            this.atalhosBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.atalhosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atalhosBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atalhosBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.atalhosBtn.Location = new System.Drawing.Point(11, 3);
            this.atalhosBtn.Name = "atalhosBtn";
            this.atalhosBtn.Size = new System.Drawing.Size(36, 29);
            this.atalhosBtn.TabIndex = 10;
            this.atalhosBtn.Text = "?";
            this.atalhosBtn.UseVisualStyleBackColor = true;
            this.atalhosBtn.Click += new System.EventHandler(this.atalhosBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(678, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 35);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // fecharBtn
            // 
            this.fecharBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fecharBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fecharBtn.Location = new System.Drawing.Point(1325, -1);
            this.fecharBtn.Name = "fecharBtn";
            this.fecharBtn.Size = new System.Drawing.Size(38, 32);
            this.fecharBtn.TabIndex = 5;
            this.fecharBtn.Text = "X";
            this.fecharBtn.UseVisualStyleBackColor = true;
            this.fecharBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // atalhosPnl
            // 
            this.atalhosPnl.BackColor = System.Drawing.Color.White;
            this.atalhosPnl.Controls.Add(this.label17);
            this.atalhosPnl.Controls.Add(this.label16);
            this.atalhosPnl.Controls.Add(this.label15);
            this.atalhosPnl.Controls.Add(this.label14);
            this.atalhosPnl.Controls.Add(this.label13);
            this.atalhosPnl.Controls.Add(this.label6);
            this.atalhosPnl.Controls.Add(this.label4);
            this.atalhosPnl.Controls.Add(this.label2);
            this.atalhosPnl.Location = new System.Drawing.Point(0, 39);
            this.atalhosPnl.Name = "atalhosPnl";
            this.atalhosPnl.Size = new System.Drawing.Size(242, 235);
            this.atalhosPnl.TabIndex = 23;
            this.atalhosPnl.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 21);
            this.label17.TabIndex = 7;
            this.label17.Text = "F11 - Fechar Venda";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 21);
            this.label16.TabIndex = 6;
            this.label16.Text = "F10 - Abrir Venda";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 21);
            this.label15.TabIndex = 5;
            this.label15.Text = "F6 - Finalizar venda";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 21);
            this.label14.TabIndex = 4;
            this.label14.Text = "F5 - Cancelar Venda";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "F4 - Adicionar quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "F3 - Cancelar Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "F2 - Adicionar Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "F1 - Adicionar Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 297);
            this.panel1.TabIndex = 0;
            // 
            // botaoCancelarVenda1
            // 
            this.botaoCancelarVenda1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCancelarVenda1.BackgroundImage")));
            this.botaoCancelarVenda1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoCancelarVenda1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelarVenda1.Location = new System.Drawing.Point(1124, 541);
            this.botaoCancelarVenda1.Name = "botaoCancelarVenda1";
            this.botaoCancelarVenda1.Size = new System.Drawing.Size(230, 80);
            this.botaoCancelarVenda1.TabIndex = 26;
            // 
            // modoDePagamentoBtn
            // 
            this.modoDePagamentoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modoDePagamentoBtn.BackgroundImage")));
            this.modoDePagamentoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modoDePagamentoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modoDePagamentoBtn.Location = new System.Drawing.Point(1124, 628);
            this.modoDePagamentoBtn.Name = "modoDePagamentoBtn";
            this.modoDePagamentoBtn.Size = new System.Drawing.Size(230, 80);
            this.modoDePagamentoBtn.TabIndex = 25;
            this.modoDePagamentoBtn.Click += new System.EventHandler(this.botaoModoDePagamento1_Click);
            // 
            // adicionarClienteBtn
            // 
            this.adicionarClienteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adicionarClienteBtn.BackgroundImage")));
            this.adicionarClienteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adicionarClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionarClienteBtn.Location = new System.Drawing.Point(1124, 454);
            this.adicionarClienteBtn.Name = "adicionarClienteBtn";
            this.adicionarClienteBtn.Size = new System.Drawing.Size(230, 80);
            this.adicionarClienteBtn.TabIndex = 20;
            this.adicionarClienteBtn.Click += new System.EventHandler(this.botaoAdicionarClienteCaixa1_Click);
            // 
            // finalizarVenda
            // 
            this.finalizarVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalizarVenda.BackgroundImage")));
            this.finalizarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finalizarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizarVenda.Location = new System.Drawing.Point(1124, 628);
            this.finalizarVenda.Name = "finalizarVenda";
            this.finalizarVenda.Size = new System.Drawing.Size(230, 80);
            this.finalizarVenda.TabIndex = 17;
            this.finalizarVenda.Visible = false;
            // 
            // adicionarProdutoBtn
            // 
            this.adicionarProdutoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adicionarProdutoBtn.BackgroundImage")));
            this.adicionarProdutoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adicionarProdutoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionarProdutoBtn.Location = new System.Drawing.Point(313, 201);
            this.adicionarProdutoBtn.Name = "adicionarProdutoBtn";
            this.adicionarProdutoBtn.Size = new System.Drawing.Size(200, 66);
            this.adicionarProdutoBtn.TabIndex = 24;
            this.adicionarProdutoBtn.Click += new System.EventHandler(this.adicionarProdutoBtn_Click);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1368, 758);
            this.Controls.Add(this.botaoCancelarVenda1);
            this.Controls.Add(this.modoDePagamentoBtn);
            this.Controls.Add(this.atalhosPnl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.adicionarClienteBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.clienteVendaTbx);
            this.Controls.Add(this.finalizarVenda);
            this.Controls.Add(this.vendedorVendaCbx);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.vendaProdutosDgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.vendaProdutosDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.atalhosPnl.ResumeLayout(false);
            this.atalhosPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView vendaProdutosDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label valorTotalLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label quantidadeItensLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label valorProdutoLbl;
        private System.Windows.Forms.TextBox idProdutoTbx;
        private System.Windows.Forms.TextBox nomeProdutoTbx;
        private System.Windows.Forms.TextBox descricaoProdutoTbx;
        private System.Windows.Forms.TextBox tamanhoTbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CaixaSsl;
        private System.Windows.Forms.ComboBox vendedorVendaCbx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private Botoes.BotaoFinalizarVenda finalizarVenda;
        private System.Windows.Forms.TextBox clienteVendaTbx;
        private System.Windows.Forms.Label label12;
        private Botoes.BotaoAdicionarClienteCaixa adicionarClienteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoPrdouto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamanhoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProduto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button fecharBtn;
        private System.Windows.Forms.Button atalhosBtn;
        private System.Windows.Forms.Panel atalhosPnl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Botoes.BotaoAdProduto adicionarProdutoBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private View.Botoes.BotaoModoDePagamento modoDePagamentoBtn;
        private View.Botoes.BotaoCancelarVenda botaoCancelarVenda1;
    }
}