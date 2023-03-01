namespace ti92app
{
    partial class FrmPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtPedido = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.clnSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDados.SuspendLayout();
            this.grbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.label3);
            this.grbDados.Controls.Add(this.cmbUsuario);
            this.grbDados.Controls.Add(this.label2);
            this.grbDados.Controls.Add(this.cmbCliente);
            this.grbDados.Controls.Add(this.btnInserir);
            this.grbDados.Enabled = false;
            this.grbDados.Location = new System.Drawing.Point(92, 118);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(512, 150);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Atendente";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(80, 75);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(181, 21);
            this.cmbUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(58, 39);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(159, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(419, 114);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(87, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtPedido
            // 
            this.txtPedido.AutoSize = true;
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(88, 69);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(115, 24);
            this.txtPedido.TabIndex = 1;
            this.txtPedido.Text = "PEDIDO Nº";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(209, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 31);
            this.txtId.TabIndex = 2;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.label9);
            this.grbProduto.Controls.Add(this.txtDesconto);
            this.grbProduto.Controls.Add(this.label8);
            this.grbProduto.Controls.Add(this.label7);
            this.grbProduto.Controls.Add(this.label6);
            this.grbProduto.Controls.Add(this.label5);
            this.grbProduto.Controls.Add(this.label4);
            this.grbProduto.Controls.Add(this.txtIdProd);
            this.grbProduto.Controls.Add(this.txtQuantidade);
            this.grbProduto.Controls.Add(this.txtUnidade);
            this.grbProduto.Controls.Add(this.txtPreco);
            this.grbProduto.Controls.Add(this.txtDescricao);
            this.grbProduto.Controls.Add(this.btnAdicionar);
            this.grbProduto.Enabled = false;
            this.grbProduto.Location = new System.Drawing.Point(628, 118);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(447, 150);
            this.grbProduto.TabIndex = 3;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "Produtos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(239, 88);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(115, 20);
            this.txtDesconto.TabIndex = 14;
            this.txtDesconto.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Qtd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(17, 40);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(66, 20);
            this.txtIdProd.TabIndex = 5;
            this.txtIdProd.TextChanged += new System.EventHandler(this.txtIdProd_TextChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(149, 88);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(73, 20);
            this.txtQuantidade.TabIndex = 4;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(279, 40);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.ReadOnly = true;
            this.txtUnidade.Size = new System.Drawing.Size(153, 20);
            this.txtUnidade.TabIndex = 3;
            this.txtUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(17, 88);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(115, 20);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(99, 40);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(157, 20);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(355, 114);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(86, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSeq,
            this.clnCodigo,
            this.clnDescricao,
            this.clnUnidade,
            this.clnPreco,
            this.clnQuantidade,
            this.clnDesconto,
            this.clnTotal});
            this.dgvItens.Location = new System.Drawing.Point(92, 274);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.Size = new System.Drawing.Size(983, 211);
            this.dgvItens.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(935, 507);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(140, 31);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL R$";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(1000, 89);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "+Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(315, 69);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 24);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Sts";
            // 
            // clnSeq
            // 
            this.clnSeq.Frozen = true;
            this.clnSeq.HeaderText = "#";
            this.clnSeq.Name = "clnSeq";
            this.clnSeq.ReadOnly = true;
            this.clnSeq.Width = 20;
            // 
            // clnCodigo
            // 
            this.clnCodigo.Frozen = true;
            this.clnCodigo.HeaderText = "Cód";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Width = 70;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Frozen = true;
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 525;
            // 
            // clnUnidade
            // 
            this.clnUnidade.Frozen = true;
            this.clnUnidade.HeaderText = "Und";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 55;
            // 
            // clnPreco
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.clnPreco.DefaultCellStyle = dataGridViewCellStyle1;
            this.clnPreco.Frozen = true;
            this.clnPreco.HeaderText = "Preço R$";
            this.clnPreco.Name = "clnPreco";
            this.clnPreco.ReadOnly = true;
            this.clnPreco.Width = 85;
            // 
            // clnQuantidade
            // 
            this.clnQuantidade.Frozen = true;
            this.clnQuantidade.HeaderText = "Qtd";
            this.clnQuantidade.Name = "clnQuantidade";
            this.clnQuantidade.ReadOnly = true;
            this.clnQuantidade.Width = 65;
            // 
            // clnDesconto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.clnDesconto.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnDesconto.Frozen = true;
            this.clnDesconto.HeaderText = "Desconto";
            this.clnDesconto.Name = "clnDesconto";
            this.clnDesconto.ReadOnly = true;
            this.clnDesconto.Width = 60;
            // 
            // clnTotal
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.clnTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnTotal.Frozen = true;
            this.clnTotal.HeaderText = "Total R$";
            this.clnTotal.Name = "clnTotal";
            this.clnTotal.ReadOnly = true;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 817);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.grbProduto);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.grbDados);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.grbProduto.ResumeLayout(false);
            this.grbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label txtPedido;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
    }
}