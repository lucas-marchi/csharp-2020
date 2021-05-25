namespace Tarefa2209
{
    partial class RealizarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarVenda));
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.cbVeiculos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenda
            // 
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(404, 12);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(384, 327);
            this.dgvVenda.TabIndex = 1;
            this.dgvVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVenda_CellContentClick);
            // 
            // cbVeiculos
            // 
            this.cbVeiculos.FormattingEnabled = true;
            this.cbVeiculos.Items.AddRange(new object[] {
            "Yamaha YS 250 Fazer",
            "Yamaha Axis 90",
            "Yamaha Crypton 100",
            "Yamaha FZ 6 600",
            "Yamaha FZ6 N",
            "Yamaha MT 01",
            "Yamaha TT-R 125",
            "Yamaha XJ6 N",
            "Yamaha XT 660 R",
            "Yamaha YZF R6"});
            this.cbVeiculos.Location = new System.Drawing.Point(12, 28);
            this.cbVeiculos.Name = "cbVeiculos";
            this.cbVeiculos.Size = new System.Drawing.Size(386, 21);
            this.cbVeiculos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estoque";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 315);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(385, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // RealizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVeiculos);
            this.Controls.Add(this.dgvVenda);
            this.Name = "RealizarVenda";
            this.Text = "Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.ComboBox cbVeiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
    }
}