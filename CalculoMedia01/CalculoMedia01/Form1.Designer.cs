namespace CalculoMedia01
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbN1 = new System.Windows.Forms.TextBox();
            this.txbN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbN3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbN4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbMedia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSoma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero1";
            // 
            // txbN1
            // 
            this.txbN1.Location = new System.Drawing.Point(16, 30);
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(47, 20);
            this.txbN1.TabIndex = 1;
            // 
            // txbN2
            // 
            this.txbN2.Location = new System.Drawing.Point(72, 30);
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(47, 20);
            this.txbN2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero2";
            // 
            // txbN3
            // 
            this.txbN3.Location = new System.Drawing.Point(125, 30);
            this.txbN3.Name = "txbN3";
            this.txbN3.Size = new System.Drawing.Size(47, 20);
            this.txbN3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero3";
            // 
            // txbN4
            // 
            this.txbN4.Location = new System.Drawing.Point(181, 30);
            this.txbN4.Name = "txbN4";
            this.txbN4.Size = new System.Drawing.Size(47, 20);
            this.txbN4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero4";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 71);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(57, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(72, 71);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(50, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbMedia
            // 
            this.txbMedia.Location = new System.Drawing.Point(87, 139);
            this.txbMedia.Name = "txbMedia";
            this.txbMedia.Size = new System.Drawing.Size(53, 20);
            this.txbMedia.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Média";
            // 
            // txbSoma
            // 
            this.txbSoma.Location = new System.Drawing.Point(16, 139);
            this.txbSoma.Name = "txbSoma";
            this.txbSoma.Size = new System.Drawing.Size(57, 20);
            this.txbSoma.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Somatporia";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(125, 71);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(61, 23);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(282, 175);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txbMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbSoma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbN4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbN3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbN2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbN1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbN1;
        private System.Windows.Forms.TextBox txbN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbN3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbN4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txbMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSoma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFechar;
    }
}

