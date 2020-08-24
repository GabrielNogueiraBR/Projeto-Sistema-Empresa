namespace ProjetoEmpresa
{
    partial class ResultadoConsulta
    {
        string cnpj = "";
        string razaoSocial = "";
        string atividadePrincial = "";

        public ResultadoConsulta(string cnpj, string razaoSocial, string atividadePrincial){
            this.cnpj = cnpj;          
            this.razaoSocial = razaoSocial;
            this.atividadePrincial = atividadePrincial;
        }
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAtividadePrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.Location = new System.Drawing.Point(161, 27);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(408, 23);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = cnpj;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razão Social:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.Location = new System.Drawing.Point(161, 59);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(408, 23);
            this.lblRazaoSocial.TabIndex = 3;
            this.lblRazaoSocial.Text = razaoSocial;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Atividade Principal";
            // 
            // lblAtividadePrincipal
            // 
            this.lblAtividadePrincipal.Location = new System.Drawing.Point(161, 90);
            this.lblAtividadePrincipal.Name = "lblAtividadePrincipal";
            this.lblAtividadePrincipal.Size = new System.Drawing.Size(408, 23);
            this.lblAtividadePrincipal.TabIndex = 5;
            this.lblAtividadePrincipal.Text = atividadePrincial;
            // 
            // ResultadoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 307);
            this.Controls.Add(this.lblAtividadePrincipal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ResultadoConsulta";
            this.Text = "Resultado da Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAtividadePrincipal;
    }
}