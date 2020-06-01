namespace Projetos_Pessoais
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxRelatorio = new System.Windows.Forms.PictureBox();
            this.pbxCalcular = new System.Windows.Forms.PictureBox();
            this.pbxRetorno = new System.Windows.Forms.PictureBox();
            this.pbxExporta = new System.Windows.Forms.PictureBox();
            this.pbxFechar = new System.Windows.Forms.PictureBox();
            this.pbxNovo = new System.Windows.Forms.PictureBox();
            this.txtClienteDinheiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.lblProdutoTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalcular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRetorno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExporta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNovo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 10);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 10);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(662, 690);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtClienteDinheiro);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblTroco);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.txtQuantidade);
            this.panel2.Controls.Add(this.lblPrecoTotal);
            this.panel2.Controls.Add(this.lblProdutoTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(662, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 690);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Projetos_Pessoais.Properties.Resources.Confirme_01;
            this.pictureBox1.Location = new System.Drawing.Point(538, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.pbxRelatorio);
            this.panel3.Controls.Add(this.pbxCalcular);
            this.panel3.Controls.Add(this.pbxRetorno);
            this.panel3.Controls.Add(this.pbxExporta);
            this.panel3.Controls.Add(this.pbxFechar);
            this.panel3.Controls.Add(this.pbxNovo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 50);
            this.panel3.TabIndex = 9;
            // 
            // pbxRelatorio
            // 
            this.pbxRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRelatorio.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxRelatorio.Image = global::Projetos_Pessoais.Properties.Resources.Relatorio_02;
            this.pbxRelatorio.Location = new System.Drawing.Point(200, 0);
            this.pbxRelatorio.Name = "pbxRelatorio";
            this.pbxRelatorio.Size = new System.Drawing.Size(50, 50);
            this.pbxRelatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRelatorio.TabIndex = 15;
            this.pbxRelatorio.TabStop = false;
            // 
            // pbxCalcular
            // 
            this.pbxCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCalcular.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxCalcular.Image = global::Projetos_Pessoais.Properties.Resources.Calculadora_02;
            this.pbxCalcular.Location = new System.Drawing.Point(150, 0);
            this.pbxCalcular.Name = "pbxCalcular";
            this.pbxCalcular.Size = new System.Drawing.Size(50, 50);
            this.pbxCalcular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCalcular.TabIndex = 14;
            this.pbxCalcular.TabStop = false;
            // 
            // pbxRetorno
            // 
            this.pbxRetorno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRetorno.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxRetorno.Image = global::Projetos_Pessoais.Properties.Resources.Volta_03;
            this.pbxRetorno.Location = new System.Drawing.Point(100, 0);
            this.pbxRetorno.Name = "pbxRetorno";
            this.pbxRetorno.Size = new System.Drawing.Size(50, 50);
            this.pbxRetorno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRetorno.TabIndex = 13;
            this.pbxRetorno.TabStop = false;
            // 
            // pbxExporta
            // 
            this.pbxExporta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExporta.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxExporta.Image = global::Projetos_Pessoais.Properties.Resources.Exporta_03;
            this.pbxExporta.Location = new System.Drawing.Point(50, 0);
            this.pbxExporta.Name = "pbxExporta";
            this.pbxExporta.Size = new System.Drawing.Size(50, 50);
            this.pbxExporta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExporta.TabIndex = 12;
            this.pbxExporta.TabStop = false;
            // 
            // pbxFechar
            // 
            this.pbxFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxFechar.Image = global::Projetos_Pessoais.Properties.Resources.Fechar_02;
            this.pbxFechar.Location = new System.Drawing.Point(588, 0);
            this.pbxFechar.Name = "pbxFechar";
            this.pbxFechar.Size = new System.Drawing.Size(50, 50);
            this.pbxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFechar.TabIndex = 11;
            this.pbxFechar.TabStop = false;
            this.pbxFechar.Click += new System.EventHandler(this.pbxFechar_Click);
            // 
            // pbxNovo
            // 
            this.pbxNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxNovo.Image = global::Projetos_Pessoais.Properties.Resources.Novo_03;
            this.pbxNovo.Location = new System.Drawing.Point(0, 0);
            this.pbxNovo.Name = "pbxNovo";
            this.pbxNovo.Size = new System.Drawing.Size(50, 50);
            this.pbxNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNovo.TabIndex = 10;
            this.pbxNovo.TabStop = false;
            this.pbxNovo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtClienteDinheiro
            // 
            this.txtClienteDinheiro.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtClienteDinheiro.Location = new System.Drawing.Point(324, 417);
            this.txtClienteDinheiro.Name = "txtClienteDinheiro";
            this.txtClienteDinheiro.Size = new System.Drawing.Size(190, 27);
            this.txtClienteDinheiro.TabIndex = 8;
            this.txtClienteDinheiro.Text = "R$ 0,00 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "CLIENTE DINHEIRO";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.White;
            this.lblTroco.Location = new System.Drawing.Point(200, 341);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(196, 30);
            this.lblTroco.TabIndex = 6;
            this.lblTroco.Text = "TROCO: R$ 0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(319, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "QUANTIDADE";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCodigo.Location = new System.Drawing.Point(324, 172);
            this.txtCodigo.MaxLength = 8;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(190, 27);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.Text = "00000000";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtQuantidade.Location = new System.Drawing.Point(75, 172);
            this.txtQuantidade.MaxLength = 900;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(190, 27);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.Text = "0";
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTotal.ForeColor = System.Drawing.Color.White;
            this.lblPrecoTotal.Location = new System.Drawing.Point(319, 249);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(269, 30);
            this.lblPrecoTotal.TabIndex = 1;
            this.lblPrecoTotal.Text = "PREÇO TOTAL: R$ 0,00";
            // 
            // lblProdutoTotal
            // 
            this.lblProdutoTotal.AutoSize = true;
            this.lblProdutoTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoTotal.ForeColor = System.Drawing.Color.White;
            this.lblProdutoTotal.Location = new System.Drawing.Point(59, 249);
            this.lblProdutoTotal.Name = "lblProdutoTotal";
            this.lblProdutoTotal.Size = new System.Drawing.Size(234, 30);
            this.lblProdutoTotal.TabIndex = 0;
            this.lblProdutoTotal.Text = "PRODUTO TOTAL: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalcular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRetorno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExporta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNovo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Label lblProdutoTotal;
        private System.Windows.Forms.PictureBox pbxNovo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtClienteDinheiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbxFechar;
        private System.Windows.Forms.PictureBox pbxExporta;
        private System.Windows.Forms.PictureBox pbxRetorno;
        private System.Windows.Forms.PictureBox pbxCalcular;
        private System.Windows.Forms.PictureBox pbxRelatorio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

