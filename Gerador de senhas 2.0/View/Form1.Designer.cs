namespace Gerador_de_senhas_2._0
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
            this.tamanho = new System.Windows.Forms.NumericUpDown();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.gerarSenhaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaiusRadio = new System.Windows.Forms.RadioButton();
            this.MinuscRadio = new System.Windows.Forms.RadioButton();
            this.EspecRadio = new System.Windows.Forms.RadioButton();
            this.NumRadio = new System.Windows.Forms.RadioButton();
            this.MaiusMinusRadio = new System.Windows.Forms.RadioButton();
            this.MaiusEspecRadio = new System.Windows.Forms.RadioButton();
            this.MaiuNumRadio = new System.Windows.Forms.RadioButton();
            this.MinusEspecRadio = new System.Windows.Forms.RadioButton();
            this.MinusNumRadio = new System.Windows.Forms.RadioButton();
            this.EspecNumRadio = new System.Windows.Forms.RadioButton();
            this.MaiusMinusEspecRadio = new System.Windows.Forms.RadioButton();
            this.MaiusMinusNumRadio = new System.Windows.Forms.RadioButton();
            this.MaiusEspecNumRadio = new System.Windows.Forms.RadioButton();
            this.MinusEspecNumRadio = new System.Windows.Forms.RadioButton();
            this.TodosRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerador de senhas";
            // 
            // tamanho
            // 
            this.tamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanho.Location = new System.Drawing.Point(286, 135);
            this.tamanho.Margin = new System.Windows.Forms.Padding(2);
            this.tamanho.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tamanho.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.tamanho.Name = "tamanho";
            this.tamanho.Size = new System.Drawing.Size(56, 28);
            this.tamanho.TabIndex = 1;
            this.tamanho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tamanho.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // senhaTxt
            // 
            this.senhaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.Location = new System.Drawing.Point(209, 463);
            this.senhaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(232, 26);
            this.senhaTxt.TabIndex = 2;
            this.senhaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gerarSenhaBtn
            // 
            this.gerarSenhaBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gerarSenhaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarSenhaBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gerarSenhaBtn.Location = new System.Drawing.Point(288, 505);
            this.gerarSenhaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.gerarSenhaBtn.Name = "gerarSenhaBtn";
            this.gerarSenhaBtn.Size = new System.Drawing.Size(70, 31);
            this.gerarSenhaBtn.TabIndex = 3;
            this.gerarSenhaBtn.Text = "Gerar";
            this.gerarSenhaBtn.UseVisualStyleBackColor = false;
            this.gerarSenhaBtn.Click += new System.EventHandler(this.gerarSenhaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamanho da sua senha : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "1 TIPO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "2 TIPOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "3 TIPOS";
            // 
            // MaiusRadio
            // 
            this.MaiusRadio.AutoSize = true;
            this.MaiusRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaiusRadio.Location = new System.Drawing.Point(38, 225);
            this.MaiusRadio.Name = "MaiusRadio";
            this.MaiusRadio.Size = new System.Drawing.Size(115, 17);
            this.MaiusRadio.TabIndex = 24;
            this.MaiusRadio.TabStop = true;
            this.MaiusRadio.Text = "Letra Maiuscula";
            this.MaiusRadio.UseVisualStyleBackColor = true;
            // 
            // MinuscRadio
            // 
            this.MinuscRadio.AutoSize = true;
            this.MinuscRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuscRadio.Location = new System.Drawing.Point(38, 248);
            this.MinuscRadio.Name = "MinuscRadio";
            this.MinuscRadio.Size = new System.Drawing.Size(115, 17);
            this.MinuscRadio.TabIndex = 25;
            this.MinuscRadio.TabStop = true;
            this.MinuscRadio.Text = "Letra Minuscula";
            this.MinuscRadio.UseVisualStyleBackColor = true;
            // 
            // EspecRadio
            // 
            this.EspecRadio.AutoSize = true;
            this.EspecRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspecRadio.Location = new System.Drawing.Point(38, 271);
            this.EspecRadio.Name = "EspecRadio";
            this.EspecRadio.Size = new System.Drawing.Size(125, 17);
            this.EspecRadio.TabIndex = 26;
            this.EspecRadio.TabStop = true;
            this.EspecRadio.Text = "Caracter Especial";
            this.EspecRadio.UseVisualStyleBackColor = true;
            // 
            // NumRadio
            // 
            this.NumRadio.AutoSize = true;
            this.NumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumRadio.Location = new System.Drawing.Point(38, 294);
            this.NumRadio.Name = "NumRadio";
            this.NumRadio.Size = new System.Drawing.Size(68, 17);
            this.NumRadio.TabIndex = 27;
            this.NumRadio.TabStop = true;
            this.NumRadio.Text = "Número";
            this.NumRadio.UseVisualStyleBackColor = true;
            // 
            // MaiusMinusRadio
            // 
            this.MaiusMinusRadio.AutoSize = true;
            this.MaiusMinusRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaiusMinusRadio.Location = new System.Drawing.Point(195, 225);
            this.MaiusMinusRadio.Name = "MaiusMinusRadio";
            this.MaiusMinusRadio.Size = new System.Drawing.Size(154, 17);
            this.MaiusMinusRadio.TabIndex = 28;
            this.MaiusMinusRadio.TabStop = true;
            this.MaiusMinusRadio.Text = "Maiuscula + Minuscula";
            this.MaiusMinusRadio.UseVisualStyleBackColor = true;
            // 
            // MaiusEspecRadio
            // 
            this.MaiusEspecRadio.AutoSize = true;
            this.MaiusEspecRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaiusEspecRadio.Location = new System.Drawing.Point(195, 248);
            this.MaiusEspecRadio.Name = "MaiusEspecRadio";
            this.MaiusEspecRadio.Size = new System.Drawing.Size(145, 17);
            this.MaiusEspecRadio.TabIndex = 29;
            this.MaiusEspecRadio.TabStop = true;
            this.MaiusEspecRadio.Text = "Maiuscula + Especial";
            this.MaiusEspecRadio.UseVisualStyleBackColor = true;
            // 
            // MaiuNumRadio
            // 
            this.MaiuNumRadio.AutoSize = true;
            this.MaiuNumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaiuNumRadio.Location = new System.Drawing.Point(195, 271);
            this.MaiuNumRadio.Name = "MaiuNumRadio";
            this.MaiuNumRadio.Size = new System.Drawing.Size(140, 17);
            this.MaiuNumRadio.TabIndex = 30;
            this.MaiuNumRadio.TabStop = true;
            this.MaiuNumRadio.Text = "Maiuscula + Número";
            this.MaiuNumRadio.UseVisualStyleBackColor = true;
            // 
            // MinusEspecRadio
            // 
            this.MinusEspecRadio.AutoSize = true;
            this.MinusEspecRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusEspecRadio.Location = new System.Drawing.Point(195, 294);
            this.MinusEspecRadio.Name = "MinusEspecRadio";
            this.MinusEspecRadio.Size = new System.Drawing.Size(145, 17);
            this.MinusEspecRadio.TabIndex = 31;
            this.MinusEspecRadio.TabStop = true;
            this.MinusEspecRadio.Text = "Minuscula + Especial";
            this.MinusEspecRadio.UseVisualStyleBackColor = true;
            // 
            // MinusNumRadio
            // 
            this.MinusNumRadio.AutoSize = true;
            this.MinusNumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusNumRadio.Location = new System.Drawing.Point(195, 317);
            this.MinusNumRadio.Name = "MinusNumRadio";
            this.MinusNumRadio.Size = new System.Drawing.Size(140, 17);
            this.MinusNumRadio.TabIndex = 32;
            this.MinusNumRadio.TabStop = true;
            this.MinusNumRadio.Text = "Minuscula + Número";
            this.MinusNumRadio.UseVisualStyleBackColor = true;
            // 
            // EspecNumRadio
            // 
            this.EspecNumRadio.AutoSize = true;
            this.EspecNumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspecNumRadio.Location = new System.Drawing.Point(195, 340);
            this.EspecNumRadio.Name = "EspecNumRadio";
            this.EspecNumRadio.Size = new System.Drawing.Size(139, 17);
            this.EspecNumRadio.TabIndex = 33;
            this.EspecNumRadio.TabStop = true;
            this.EspecNumRadio.Text = "Especial   + Número";
            this.EspecNumRadio.UseVisualStyleBackColor = true;
            // 
            // MaiusMinusEspecRadio
            // 
            this.MaiusMinusEspecRadio.AutoSize = true;
            this.MaiusMinusEspecRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaiusMinusEspecRadio.Location = new System.Drawing.Point(397, 225);
            this.MaiusMinusEspecRadio.Name = "MaiusMinusEspecRadio";
            this.MaiusMinusEspecRadio.Size = new System.Drawing.Size(221, 17);
            this.MaiusMinusEspecRadio.TabIndex = 34;
            this.MaiusMinusEspecRadio.TabStop = true;
            this.MaiusMinusEspecRadio.Text = "Maiuscula + Minuscula + Especial ";
            this.MaiusMinusEspecRadio.UseVisualStyleBackColor = true;
            // 
            // MaiusMinusNumRadio
            // 
            this.MaiusMinusNumRadio.AutoSize = true;
            this.MaiusMinusNumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaiusMinusNumRadio.Location = new System.Drawing.Point(397, 248);
            this.MaiusMinusNumRadio.Name = "MaiusMinusNumRadio";
            this.MaiusMinusNumRadio.Size = new System.Drawing.Size(212, 17);
            this.MaiusMinusNumRadio.TabIndex = 35;
            this.MaiusMinusNumRadio.TabStop = true;
            this.MaiusMinusNumRadio.Text = "Maiuscula + Minuscula + Número";
            this.MaiusMinusNumRadio.UseVisualStyleBackColor = true;
            // 
            // MaiusEspecNumRadio
            // 
            this.MaiusEspecNumRadio.AutoSize = true;
            this.MaiusEspecNumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaiusEspecNumRadio.Location = new System.Drawing.Point(397, 271);
            this.MaiusEspecNumRadio.Name = "MaiusEspecNumRadio";
            this.MaiusEspecNumRadio.Size = new System.Drawing.Size(211, 17);
            this.MaiusEspecNumRadio.TabIndex = 36;
            this.MaiusEspecNumRadio.TabStop = true;
            this.MaiusEspecNumRadio.Text = "Maiuscula + Especial   + Número";
            this.MaiusEspecNumRadio.UseVisualStyleBackColor = true;
            // 
            // MinusEspecNumRadio
            // 
            this.MinusEspecNumRadio.AutoSize = true;
            this.MinusEspecNumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusEspecNumRadio.Location = new System.Drawing.Point(397, 294);
            this.MinusEspecNumRadio.Name = "MinusEspecNumRadio";
            this.MinusEspecNumRadio.Size = new System.Drawing.Size(211, 17);
            this.MinusEspecNumRadio.TabIndex = 37;
            this.MinusEspecNumRadio.TabStop = true;
            this.MinusEspecNumRadio.Text = "Minuscula + Especial   + Número";
            this.MinusEspecNumRadio.UseVisualStyleBackColor = true;
            // 
            // TodosRadio
            // 
            this.TodosRadio.AutoSize = true;
            this.TodosRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodosRadio.Location = new System.Drawing.Point(279, 411);
            this.TodosRadio.Name = "TodosRadio";
            this.TodosRadio.Size = new System.Drawing.Size(87, 28);
            this.TodosRadio.TabIndex = 38;
            this.TodosRadio.TabStop = true;
            this.TodosRadio.Text = "Todos";
            this.TodosRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(656, 547);
            this.Controls.Add(this.TodosRadio);
            this.Controls.Add(this.MinusEspecNumRadio);
            this.Controls.Add(this.MaiusEspecNumRadio);
            this.Controls.Add(this.MaiusMinusNumRadio);
            this.Controls.Add(this.MaiusMinusEspecRadio);
            this.Controls.Add(this.EspecNumRadio);
            this.Controls.Add(this.MinusNumRadio);
            this.Controls.Add(this.MinusEspecRadio);
            this.Controls.Add(this.MaiuNumRadio);
            this.Controls.Add(this.MaiusEspecRadio);
            this.Controls.Add(this.MaiusMinusRadio);
            this.Controls.Add(this.NumRadio);
            this.Controls.Add(this.EspecRadio);
            this.Controls.Add(this.MinuscRadio);
            this.Controls.Add(this.MaiusRadio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gerarSenhaBtn);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.tamanho);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tamanho;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Button gerarSenhaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton MaiusRadio;
        private System.Windows.Forms.RadioButton MinuscRadio;
        private System.Windows.Forms.RadioButton EspecRadio;
        private System.Windows.Forms.RadioButton NumRadio;
        private System.Windows.Forms.RadioButton MaiusMinusRadio;
        private System.Windows.Forms.RadioButton MaiusEspecRadio;
        private System.Windows.Forms.RadioButton MaiuNumRadio;
        private System.Windows.Forms.RadioButton MinusEspecRadio;
        private System.Windows.Forms.RadioButton MinusNumRadio;
        private System.Windows.Forms.RadioButton EspecNumRadio;
        private System.Windows.Forms.RadioButton MaiusMinusEspecRadio;
        private System.Windows.Forms.RadioButton MaiusMinusNumRadio;
        private System.Windows.Forms.RadioButton MaiusEspecNumRadio;
        private System.Windows.Forms.RadioButton MinusEspecNumRadio;
        private System.Windows.Forms.RadioButton TodosRadio;
    }
}

