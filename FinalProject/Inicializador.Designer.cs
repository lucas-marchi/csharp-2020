namespace FinalProject
{
    partial class Inicializador
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label melhorPontuaçãoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicializador));
            this.pbTela = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.TempoDeJogo = new System.Windows.Forms.Timer(this.components);
            this.lblFimDeJogo = new System.Windows.Forms.Label();
            this.scoreBDDataSet = new FinalProject.ScoreBDDataSet();
            this.sCOREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCORETableAdapter = new FinalProject.ScoreBDDataSetTableAdapters.SCORETableAdapter();
            this.tableAdapterManager = new FinalProject.ScoreBDDataSetTableAdapters.TableAdapterManager();
            this.melhorPontuaçãoLabel1 = new System.Windows.Forms.Label();
            this.tBPontosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreBDDataSet1 = new FinalProject.ScoreBDDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.tBPontosTableAdapter = new FinalProject.ScoreBDDataSet1TableAdapters.TBPontosTableAdapter();
            this.tableAdapterManager1 = new FinalProject.ScoreBDDataSet1TableAdapters.TableAdapterManager();
            melhorPontuaçãoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPontosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBDDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // melhorPontuaçãoLabel
            // 
            melhorPontuaçãoLabel.AutoSize = true;
            melhorPontuaçãoLabel.BackColor = System.Drawing.Color.Transparent;
            melhorPontuaçãoLabel.Font = new System.Drawing.Font("Janvier", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            melhorPontuaçãoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            melhorPontuaçãoLabel.Location = new System.Drawing.Point(14, 498);
            melhorPontuaçãoLabel.Name = "melhorPontuaçãoLabel";
            melhorPontuaçãoLabel.Size = new System.Drawing.Size(103, 22);
            melhorPontuaçãoLabel.TabIndex = 7;
            melhorPontuaçãoLabel.Text = "Melhor Score:";
            // 
            // pbTela
            // 
            this.pbTela.BackColor = System.Drawing.Color.Beige;
            this.pbTela.Location = new System.Drawing.Point(12, 47);
            this.pbTela.Name = "pbTela";
            this.pbTela.Size = new System.Drawing.Size(464, 448);
            this.pbTela.TabIndex = 0;
            this.pbTela.TabStop = false;
            this.pbTela.Paint += new System.Windows.Forms.PaintEventHandler(this.PbTela_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Janvier", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pontos:";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblPontos.Font = new System.Drawing.Font("Janvier", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblPontos.Location = new System.Drawing.Point(109, 9);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(78, 32);
            this.lblPontos.TabIndex = 2;
            this.lblPontos.Text = "label2";
            // 
            // lblFimDeJogo
            // 
            this.lblFimDeJogo.AutoSize = true;
            this.lblFimDeJogo.BackColor = System.Drawing.Color.Beige;
            this.lblFimDeJogo.Font = new System.Drawing.Font("Janvier", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFimDeJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblFimDeJogo.Location = new System.Drawing.Point(13, 56);
            this.lblFimDeJogo.Name = "lblFimDeJogo";
            this.lblFimDeJogo.Size = new System.Drawing.Size(69, 26);
            this.lblFimDeJogo.TabIndex = 3;
            this.lblFimDeJogo.Text = "label2";
            this.lblFimDeJogo.Visible = false;
            // 
            // scoreBDDataSet
            // 
            this.scoreBDDataSet.DataSetName = "ScoreBDDataSet";
            this.scoreBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCOREBindingSource
            // 
            this.sCOREBindingSource.DataMember = "SCORE";
            this.sCOREBindingSource.DataSource = this.scoreBDDataSet;
            // 
            // sCORETableAdapter
            // 
            this.sCORETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SCORETableAdapter = this.sCORETableAdapter;
            this.tableAdapterManager.UpdateOrder = FinalProject.ScoreBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // melhorPontuaçãoLabel1
            // 
            this.melhorPontuaçãoLabel1.BackColor = System.Drawing.Color.Transparent;
            this.melhorPontuaçãoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPontosBindingSource, "Pontuacoes", true));
            this.melhorPontuaçãoLabel1.Font = new System.Drawing.Font("Janvier", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melhorPontuaçãoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.melhorPontuaçãoLabel1.Location = new System.Drawing.Point(123, 498);
            this.melhorPontuaçãoLabel1.Name = "melhorPontuaçãoLabel1";
            this.melhorPontuaçãoLabel1.Size = new System.Drawing.Size(100, 23);
            this.melhorPontuaçãoLabel1.TabIndex = 8;
            this.melhorPontuaçãoLabel1.Text = "label4";
            // 
            // tBPontosBindingSource
            // 
            this.tBPontosBindingSource.DataMember = "TBPontos";
            this.tBPontosBindingSource.DataSource = this.scoreBDDataSet1;
            // 
            // scoreBDDataSet1
            // 
            this.scoreBDDataSet1.DataSetName = "ScoreBDDataSet1";
            this.scoreBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Janvier", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(309, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Velocidade:";
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.BackColor = System.Drawing.Color.Transparent;
            this.lblVelocidade.Font = new System.Drawing.Font("Janvier", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblVelocidade.Location = new System.Drawing.Point(411, 17);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(56, 23);
            this.lblVelocidade.TabIndex = 10;
            this.lblVelocidade.Text = "label3";
            // 
            // tBPontosTableAdapter
            // 
            this.tBPontosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.SCORETableAdapter = null;
            this.tableAdapterManager1.TBPontosTableAdapter = this.tBPontosTableAdapter;
            this.tableAdapterManager1.UpdateOrder = FinalProject.ScoreBDDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 534);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(melhorPontuaçãoLabel);
            this.Controls.Add(this.melhorPontuaçãoLabel1);
            this.Controls.Add(this.lblFimDeJogo);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTela);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicializador";
            this.Text = "Serpente: O Jogo";
            this.Load += new System.EventHandler(this.Inicializador_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPontosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBDDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Timer TempoDeJogo;
        private System.Windows.Forms.Label lblFimDeJogo;
        private ScoreBDDataSet scoreBDDataSet;
        private System.Windows.Forms.BindingSource sCOREBindingSource;
        private ScoreBDDataSetTableAdapters.SCORETableAdapter sCORETableAdapter;
        private ScoreBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label melhorPontuaçãoLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVelocidade;
        private ScoreBDDataSet1 scoreBDDataSet1;
        private System.Windows.Forms.BindingSource tBPontosBindingSource;
        private ScoreBDDataSet1TableAdapters.TBPontosTableAdapter tBPontosTableAdapter;
        private ScoreBDDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

