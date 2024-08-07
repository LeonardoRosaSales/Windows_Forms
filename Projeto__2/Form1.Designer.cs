namespace Projeto__2
{
    partial class Form_Saudacao
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
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.button_exibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(12, 9);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(65, 23);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(83, 12);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(194, 20);
            this.textBox_nome.TabIndex = 1;
            // 
            // button_exibir
            // 
            this.button_exibir.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_exibir.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exibir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_exibir.Location = new System.Drawing.Point(95, 63);
            this.button_exibir.Name = "button_exibir";
            this.button_exibir.Size = new System.Drawing.Size(114, 61);
            this.button_exibir.TabIndex = 2;
            this.button_exibir.Text = "&Clique Aqui!";
            this.button_exibir.UseVisualStyleBackColor = false;
            this.button_exibir.Click += new System.EventHandler(this.button_exibir_Click);
            // 
            // Form_Saudacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(342, 161);
            this.Controls.Add(this.button_exibir);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Saudacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto 2 - Saudação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Button button_exibir;
    }
}

