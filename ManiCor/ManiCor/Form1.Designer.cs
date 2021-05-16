namespace ManiCor
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
            this.btnVermelho = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnVermelho
            // 
            this.btnVermelho.Location = new System.Drawing.Point(29, 45);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(67, 30);
            this.btnVermelho.TabIndex = 0;
            this.btnVermelho.Text = "Vermelho";
            this.btnVermelho.UseVisualStyleBackColor = true;
            this.btnVermelho.Click += new System.EventHandler(this.btnVermelho_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(102, 45);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(72, 30);
            this.btnAzul.TabIndex = 1;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.Location = new System.Drawing.Point(180, 45);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(65, 30);
            this.btnVerde.TabIndex = 2;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.Location = new System.Drawing.Point(251, 45);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(68, 30);
            this.btnAmarelo.TabIndex = 3;
            this.btnAmarelo.Text = "Amarelo";
            this.btnAmarelo.UseVisualStyleBackColor = true;
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(34, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 205);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVermelho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Panel panel1;
    }
}

