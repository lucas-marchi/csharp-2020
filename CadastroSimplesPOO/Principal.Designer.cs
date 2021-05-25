namespace Tarefa2209
{
    partial class Principal
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
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLerTodos = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToAddRows = false;
            this.dgvCadastro.AllowUserToDeleteRows = false;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Location = new System.Drawing.Point(284, 12);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.ReadOnly = true;
            this.dgvCadastro.Size = new System.Drawing.Size(329, 266);
            this.dgvCadastro.TabIndex = 6;
            this.dgvCadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastro_CellContentClick_1);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(6, 99);
            this.tbEndereco.Multiline = true;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(249, 54);
            this.tbEndereco.TabIndex = 5;
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.Location = new System.Drawing.Point(3, 83);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(56, 13);
            this.Endereco.TabIndex = 4;
            this.Endereco.Text = "Endereço:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(47, 15);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(208, 20);
            this.tbNome.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(3, 18);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(150, 159);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.ButtonConfirmar_Click);
            // 
            // btnLerTodos
            // 
            this.btnLerTodos.Enabled = false;
            this.btnLerTodos.Location = new System.Drawing.Point(76, 159);
            this.btnLerTodos.Name = "btnLerTodos";
            this.btnLerTodos.Size = new System.Drawing.Size(68, 23);
            this.btnLerTodos.TabIndex = 11;
            this.btnLerTodos.Text = "Ver Todos";
            this.btnLerTodos.UseVisualStyleBackColor = true;
            this.btnLerTodos.Click += new System.EventHandler(this.BtnLerTodos_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(6, 159);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVenda);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnLerTodos);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.Endereco);
            this.panel1.Controls.Add(this.tbEndereco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 290);
            this.panel1.TabIndex = 12;
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.SystemColors.Control;
            this.btnVenda.Enabled = false;
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Location = new System.Drawing.Point(6, 208);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(249, 70);
            this.btnVenda.TabIndex = 12;
            this.btnVenda.Text = "Realizar Venda";
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.BtnVenda_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 290);
            this.Controls.Add(this.dgvCadastro);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Cadastro Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLerTodos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVenda;
    }
}

