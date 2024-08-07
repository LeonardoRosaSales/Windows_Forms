namespace Projeto_3
{
    partial class Form_calculadora
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
            this.label_calcu = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.textBox__peso = new System.Windows.Forms.TextBox();
            this.textBox__altura = new System.Windows.Forms.TextBox();
            this.label__altura = new System.Windows.Forms.Label();
            this.label__imc = new System.Windows.Forms.Label();
            this.label__situacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_result_imc = new System.Windows.Forms.Label();
            this.label_result_situacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_calcu
            // 
            this.label_calcu.AutoSize = true;
            this.label_calcu.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calcu.Location = new System.Drawing.Point(26, 9);
            this.label_calcu.Name = "label_calcu";
            this.label_calcu.Size = new System.Drawing.Size(175, 23);
            this.label_calcu.TabIndex = 0;
            this.label_calcu.Text = "CALCULADORA IMC";
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.Location = new System.Drawing.Point(81, 44);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(65, 23);
            this.peso.TabIndex = 1;
            this.peso.Text = "Peso:";
            // 
            // textBox__peso
            // 
            this.textBox__peso.Location = new System.Drawing.Point(28, 70);
            this.textBox__peso.Name = "textBox__peso";
            this.textBox__peso.Size = new System.Drawing.Size(171, 20);
            this.textBox__peso.TabIndex = 2;
            // 
            // textBox__altura
            // 
            this.textBox__altura.Location = new System.Drawing.Point(28, 140);
            this.textBox__altura.Name = "textBox__altura";
            this.textBox__altura.Size = new System.Drawing.Size(171, 20);
            this.textBox__altura.TabIndex = 3;
            this.textBox__altura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label__altura
            // 
            this.label__altura.AutoSize = true;
            this.label__altura.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label__altura.Location = new System.Drawing.Point(70, 114);
            this.label__altura.Name = "label__altura";
            this.label__altura.Size = new System.Drawing.Size(87, 23);
            this.label__altura.TabIndex = 4;
            this.label__altura.Text = "Altura:";
            // 
            // label__imc
            // 
            this.label__imc.AutoSize = true;
            this.label__imc.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label__imc.Location = new System.Drawing.Point(92, 174);
            this.label__imc.Name = "label__imc";
            this.label__imc.Size = new System.Drawing.Size(43, 23);
            this.label__imc.TabIndex = 5;
            this.label__imc.Text = "IMC";
            this.label__imc.Click += new System.EventHandler(this.label__imc_Click);
            // 
            // label__situacao
            // 
            this.label__situacao.AutoSize = true;
            this.label__situacao.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label__situacao.Location = new System.Drawing.Point(59, 242);
            this.label__situacao.Name = "label__situacao";
            this.label__situacao.Size = new System.Drawing.Size(109, 23);
            this.label__situacao.TabIndex = 6;
            this.label__situacao.Text = "Situação:";
            this.label__situacao.Click += new System.EventHandler(this.label__situacao_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_result_imc
            // 
            this.label_result_imc.AutoSize = true;
            this.label_result_imc.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result_imc.Location = new System.Drawing.Point(81, 207);
            this.label_result_imc.Name = "label_result_imc";
            this.label_result_imc.Size = new System.Drawing.Size(77, 16);
            this.label_result_imc.TabIndex = 8;
            this.label_result_imc.Text = "Resultado...";
            // 
            // label_result_situacao
            // 
            this.label_result_situacao.AutoSize = true;
            this.label_result_situacao.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result_situacao.Location = new System.Drawing.Point(82, 282);
            this.label_result_situacao.Name = "label_result_situacao";
            this.label_result_situacao.Size = new System.Drawing.Size(77, 16);
            this.label_result_situacao.TabIndex = 9;
            this.label_result_situacao.Text = "Resultado...";
            // 
            // Form_calculadora
            // 
            this.ClientSize = new System.Drawing.Size(235, 389);
            this.Controls.Add(this.label_result_situacao);
            this.Controls.Add(this.label_result_imc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label__situacao);
            this.Controls.Add(this.label__imc);
            this.Controls.Add(this.label__altura);
            this.Controls.Add(this.textBox__altura);
            this.Controls.Add(this.textBox__peso);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.label_calcu);
            this.Name = "Form_calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_calculadora;
        private System.Windows.Forms.Label label_peso;
        private System.Windows.Forms.TextBox textBox_peso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_altura;
        private System.Windows.Forms.Label label_imc;
        private System.Windows.Forms.Label label_situacao;
        private System.Windows.Forms.Label label_calcu;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.TextBox textBox__peso;
        private System.Windows.Forms.TextBox textBox__altura;
        private System.Windows.Forms.Label label__altura;
        private System.Windows.Forms.Label label__imc;
        private System.Windows.Forms.Label label__situacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_result_imc;
        private System.Windows.Forms.Label label_result_situacao;
    }
}

