namespace Ex4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.CriarExibir = new System.Windows.Forms.Button();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(444, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.BackColor = System.Drawing.Color.Transparent;
            this.lbl_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(440, 37);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(270, 20);
            this.lbl_output.TabIndex = 22;
            this.lbl_output.Text = "Os dados do veiculo aparecerão aqui";
            // 
            // CriarExibir
            // 
            this.CriarExibir.BackColor = System.Drawing.Color.DodgerBlue;
            this.CriarExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarExibir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CriarExibir.Location = new System.Drawing.Point(87, 282);
            this.CriarExibir.Name = "CriarExibir";
            this.CriarExibir.Size = new System.Drawing.Size(263, 41);
            this.CriarExibir.TabIndex = 21;
            this.CriarExibir.Text = "Calcular Media";
            this.CriarExibir.UseVisualStyleBackColor = false;
            this.CriarExibir.Click += new System.EventHandler(this.CriarExibir_Click);
            // 
            // txt_nota2
            // 
            this.txt_nota2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nota2.Location = new System.Drawing.Point(143, 180);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(100, 25);
            this.txt_nota2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nota 2:";
            // 
            // txt_nota1
            // 
            this.txt_nota1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nota1.Location = new System.Drawing.Point(143, 149);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(100, 25);
            this.txt_nota1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nota 1:";
            // 
            // txt_Idade
            // 
            this.txt_Idade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Idade.Location = new System.Drawing.Point(143, 118);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(100, 25);
            this.txt_Idade.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Idade:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(143, 87);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 25);
            this.txt_Nome.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.CriarExibir);
            this.Controls.Add(this.txt_nota2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button CriarExibir;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label1;
    }
}

