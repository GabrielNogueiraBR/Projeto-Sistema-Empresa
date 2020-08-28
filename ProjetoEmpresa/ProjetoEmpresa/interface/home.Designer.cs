namespace ProjetoEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            this.SuspendLayout();
            // 
            // imgHome
            // 
            this.imgHome.Image = ((System.Drawing.Image)(resources.GetObject("imgHome.Image")));
            this.imgHome.Location = new System.Drawing.Point(16, 23);
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(150, 150);
            this.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHome.TabIndex = 0;
            this.imgHome.TabStop = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(179, 150);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(406, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar Cadastro";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(179, 188);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(406, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Cadastro";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(179, 227);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(406, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir Cadastro";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(172, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema Empresa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(176, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sistema criado para adicionar e excluir registros de empresa utilizando o web ser" +
    "vice da receita federal.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.imgHome);
            this.Name = "Form1";
            this.Text = "Sistema Empresa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

