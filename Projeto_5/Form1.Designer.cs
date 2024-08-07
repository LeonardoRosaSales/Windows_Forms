namespace Projeto_5
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
            this.textBox_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.button_adicao = new System.Windows.Forms.Button();
            this.button_multi = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_subs = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor:";
            // 
            // textBox_valor
            // 
            this.textBox_valor.Location = new System.Drawing.Point(108, 16);
            this.textBox_valor.Name = "textBox_valor";
            this.textBox_valor.Size = new System.Drawing.Size(118, 20);
            this.textBox_valor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite outro valor:";
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.Location = new System.Drawing.Point(108, 39);
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(118, 20);
            this.textBox_valor2.TabIndex = 3;
            // 
            // button_adicao
            // 
            this.button_adicao.Location = new System.Drawing.Point(12, 82);
            this.button_adicao.Name = "button_adicao";
            this.button_adicao.Size = new System.Drawing.Size(35, 25);
            this.button_adicao.TabIndex = 4;
            this.button_adicao.Text = "+";
            this.button_adicao.UseVisualStyleBackColor = true;
            this.button_adicao.Click += new System.EventHandler(this.button_adicao_Click);
            // 
            // button_multi
            // 
            this.button_multi.Location = new System.Drawing.Point(135, 82);
            this.button_multi.Name = "button_multi";
            this.button_multi.Size = new System.Drawing.Size(35, 25);
            this.button_multi.TabIndex = 5;
            this.button_multi.Text = "*";
            this.button_multi.UseVisualStyleBackColor = true;
            this.button_multi.Click += new System.EventHandler(this.button_multi_Click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(94, 82);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(35, 25);
            this.button_div.TabIndex = 6;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_subs
            // 
            this.button_subs.Location = new System.Drawing.Point(53, 82);
            this.button_subs.Name = "button_subs";
            this.button_subs.Size = new System.Drawing.Size(35, 25);
            this.button_subs.TabIndex = 7;
            this.button_subs.Text = "-";
            this.button_subs.UseVisualStyleBackColor = true;
            this.button_subs.Click += new System.EventHandler(this.button_subs_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(12, 135);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(67, 13);
            this.label_resultado.TabIndex = 8;
            this.label_resultado.Text = "Resultado....";
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(177, 82);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(57, 25);
            this.button_limpar.TabIndex = 9;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(177, 129);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(57, 25);
            this.button_sair.TabIndex = 10;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 161);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_subs);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_multi);
            this.Controls.Add(this.button_adicao);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_valor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.Button button_adicao;
        private System.Windows.Forms.Button button_multi;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_subs;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_sair;
    }
}

