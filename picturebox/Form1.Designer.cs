
namespace picturebox
{
    partial class frmPictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureBox));
            this.pbComputador = new System.Windows.Forms.PictureBox();
            this.pbImagemImportada = new System.Windows.Forms.PictureBox();
            this.pbCidade = new System.Windows.Forms.PictureBox();
            this.btnVerImagem = new System.Windows.Forms.Button();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.btnAnexarImagem = new System.Windows.Forms.Button();
            this.pbAnexarImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemImportada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).BeginInit();
            this.panelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputador
            // 
            this.pbComputador.Image = ((System.Drawing.Image)(resources.GetObject("pbComputador.Image")));
            this.pbComputador.Location = new System.Drawing.Point(28, 31);
            this.pbComputador.Name = "pbComputador";
            this.pbComputador.Size = new System.Drawing.Size(597, 123);
            this.pbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbComputador.TabIndex = 0;
            this.pbComputador.TabStop = false;
            // 
            // pbImagemImportada
            // 
            this.pbImagemImportada.Image = global::picturebox.Properties.Resources.computador;
            this.pbImagemImportada.Location = new System.Drawing.Point(28, 160);
            this.pbImagemImportada.Name = "pbImagemImportada";
            this.pbImagemImportada.Size = new System.Drawing.Size(546, 179);
            this.pbImagemImportada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemImportada.TabIndex = 1;
            this.pbImagemImportada.TabStop = false;
            // 
            // pbCidade
            // 
            this.pbCidade.Location = new System.Drawing.Point(28, 345);
            this.pbCidade.Name = "pbCidade";
            this.pbCidade.Size = new System.Drawing.Size(546, 141);
            this.pbCidade.TabIndex = 2;
            this.pbCidade.TabStop = false;
            // 
            // btnVerImagem
            // 
            this.btnVerImagem.BackColor = System.Drawing.Color.Maroon;
            this.btnVerImagem.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerImagem.ForeColor = System.Drawing.Color.Gold;
            this.btnVerImagem.Location = new System.Drawing.Point(619, 386);
            this.btnVerImagem.Name = "btnVerImagem";
            this.btnVerImagem.Size = new System.Drawing.Size(148, 61);
            this.btnVerImagem.TabIndex = 3;
            this.btnVerImagem.Text = "Ver Imagem";
            this.btnVerImagem.UseVisualStyleBackColor = false;
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.LightBlue;
            this.panelFundo.Controls.Add(this.btnAnexarImagem);
            this.panelFundo.Controls.Add(this.pbAnexarImagem);
            this.panelFundo.Location = new System.Drawing.Point(631, 31);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(247, 335);
            this.panelFundo.TabIndex = 4;
            // 
            // btnAnexarImagem
            // 
            this.btnAnexarImagem.BackColor = System.Drawing.Color.Gold;
            this.btnAnexarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexarImagem.ForeColor = System.Drawing.Color.Maroon;
            this.btnAnexarImagem.Location = new System.Drawing.Point(46, 217);
            this.btnAnexarImagem.Name = "btnAnexarImagem";
            this.btnAnexarImagem.Size = new System.Drawing.Size(145, 68);
            this.btnAnexarImagem.TabIndex = 1;
            this.btnAnexarImagem.Text = "Anexar Imagem";
            this.btnAnexarImagem.UseVisualStyleBackColor = false;
            this.btnAnexarImagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAnexarImagem_MouseClick);
            // 
            // pbAnexarImagem
            // 
            this.pbAnexarImagem.Location = new System.Drawing.Point(23, 27);
            this.pbAnexarImagem.Name = "pbAnexarImagem";
            this.pbAnexarImagem.Size = new System.Drawing.Size(193, 166);
            this.pbAnexarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAnexarImagem.TabIndex = 0;
            this.pbAnexarImagem.TabStop = false;
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 487);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.btnVerImagem);
            this.Controls.Add(this.pbCidade);
            this.Controls.Add(this.pbImagemImportada);
            this.Controls.Add(this.pbComputador);
            this.Name = "frmPictureBox";
            this.Text = "Picture Box";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemImportada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).EndInit();
            this.panelFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbComputador;
        private System.Windows.Forms.PictureBox pbImagemImportada;
        private System.Windows.Forms.PictureBox pbCidade;
        private System.Windows.Forms.Button btnVerImagem;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Button btnAnexarImagem;
        private System.Windows.Forms.PictureBox pbAnexarImagem;
    }
}

