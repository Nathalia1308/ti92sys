﻿namespace ti92app
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.txtNomeNivel = new System.Windows.Forms.TextBox();
            this.txtSiglaNivel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsereNivel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 279);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 95);
            this.listBox1.TabIndex = 1;
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Location = new System.Drawing.Point(73, 21);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.ReadOnly = true;
            this.txtIdNivel.Size = new System.Drawing.Size(39, 20);
            this.txtIdNivel.TabIndex = 2;
            this.txtIdNivel.TextChanged += new System.EventHandler(this.txtIdNivel_TextChanged);
            // 
            // txtNomeNivel
            // 
            this.txtNomeNivel.Location = new System.Drawing.Point(73, 51);
            this.txtNomeNivel.Name = "txtNomeNivel";
            this.txtNomeNivel.Size = new System.Drawing.Size(104, 20);
            this.txtNomeNivel.TabIndex = 3;
            // 
            // txtSiglaNivel
            // 
            this.txtSiglaNivel.Location = new System.Drawing.Point(73, 85);
            this.txtSiglaNivel.Name = "txtSiglaNivel";
            this.txtSiglaNivel.Size = new System.Drawing.Size(68, 20);
            this.txtSiglaNivel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SIGLA";
            // 
            // btnInsereNivel
            // 
            this.btnInsereNivel.Location = new System.Drawing.Point(33, 132);
            this.btnInsereNivel.Name = "btnInsereNivel";
            this.btnInsereNivel.Size = new System.Drawing.Size(75, 23);
            this.btnInsereNivel.TabIndex = 8;
            this.btnInsereNivel.Text = "Inserir";
            this.btnInsereNivel.UseVisualStyleBackColor = true;
            this.btnInsereNivel.Click += new System.EventHandler(this.btnInsereNivel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnInsereNivel);
            this.groupBox1.Controls.Add(this.txtIdNivel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNomeNivel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSiglaNivel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 174);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nível";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(114, 132);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(199, 132);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(29, 253);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(280, 20);
            this.txtBusca.TabIndex = 10;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.TextBox txtNomeNivel;
        private System.Windows.Forms.TextBox txtSiglaNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsereNivel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtBusca;
    }
}

