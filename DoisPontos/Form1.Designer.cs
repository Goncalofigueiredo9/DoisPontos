namespace DoisPontos
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
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1.Location = new System.Drawing.Point(258, 154);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(108, 35);
            this.x1.TabIndex = 0;
            // 
            // y1
            // 
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y1.Location = new System.Drawing.Point(372, 156);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(108, 35);
            this.y1.TabIndex = 1;
            // 
            // x2
            // 
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2.Location = new System.Drawing.Point(258, 199);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(108, 35);
            this.x2.TabIndex = 2;
            // 
            // y2
            // 
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y2.Location = new System.Drawing.Point(372, 197);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(108, 35);
            this.y2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 92);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ponto 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ponto 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Distância entre pontos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(301, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(401, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

