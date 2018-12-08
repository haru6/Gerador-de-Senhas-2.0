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
            ((System.ComponentModel.ISupportInitialize)(this.tamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o tamanho da sua senha:";
            // 
            // tamanho
            // 
            this.tamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanho.Location = new System.Drawing.Point(264, 90);
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
            this.tamanho.Size = new System.Drawing.Size(75, 34);
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
            this.senhaTxt.Location = new System.Drawing.Point(142, 253);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(308, 30);
            this.senhaTxt.TabIndex = 2;
            this.senhaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gerarSenhaBtn
            // 
            this.gerarSenhaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarSenhaBtn.Location = new System.Drawing.Point(264, 303);
            this.gerarSenhaBtn.Name = "gerarSenhaBtn";
            this.gerarSenhaBtn.Size = new System.Drawing.Size(94, 38);
            this.gerarSenhaBtn.TabIndex = 3;
            this.gerarSenhaBtn.Text = "Gerar";
            this.gerarSenhaBtn.UseVisualStyleBackColor = true;
            this.gerarSenhaBtn.Click += new System.EventHandler(this.gerarSenhaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.Controls.Add(this.gerarSenhaBtn);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.tamanho);
            this.Controls.Add(this.label1);
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
    }
}

