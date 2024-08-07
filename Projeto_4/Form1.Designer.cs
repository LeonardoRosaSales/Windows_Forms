namespace Projeto_4
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
            this.label_reserva = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_destino = new System.Windows.Forms.Label();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            this.groupBox_transporte = new System.Windows.Forms.GroupBox();
            this.radioButton_onibus = new System.Windows.Forms.RadioButton();
            this.radioButton_aviao = new System.Windows.Forms.RadioButton();
            this.groupBox_valores = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_numero_total = new System.Windows.Forms.Label();
            this.label_numero_destino = new System.Windows.Forms.Label();
            this.label_numero_transp = new System.Windows.Forms.Label();
            this.label_real = new System.Windows.Forms.Label();
            this.label_valor_total = new System.Windows.Forms.Label();
            this.label_gasto_dest = new System.Windows.Forms.Label();
            this.label_gasto_trans = new System.Windows.Forms.Label();
            this.button_confirmar = new System.Windows.Forms.Button();
            this.button_calcular = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.groupBox_transporte.SuspendLayout();
            this.groupBox_valores.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_reserva
            // 
            this.label_reserva.AutoSize = true;
            this.label_reserva.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_reserva.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reserva.ForeColor = System.Drawing.Color.White;
            this.label_reserva.Location = new System.Drawing.Point(3, -1);
            this.label_reserva.Name = "label_reserva";
            this.label_reserva.Padding = new System.Windows.Forms.Padding(180, 0, 180, 0);
            this.label_reserva.Size = new System.Drawing.Size(619, 28);
            this.label_reserva.TabIndex = 0;
            this.label_reserva.Text = "Reserva de Passagem";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(12, 42);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(43, 13);
            this.label_nome.TabIndex = 1;
            this.label_nome.Text = "Nome:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(61, 39);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(375, 20);
            this.textBox_nome.TabIndex = 2;
            // 
            // label_destino
            // 
            this.label_destino.AutoSize = true;
            this.label_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_destino.Location = new System.Drawing.Point(7, 68);
            this.label_destino.Name = "label_destino";
            this.label_destino.Size = new System.Drawing.Size(54, 13);
            this.label_destino.TabIndex = 4;
            this.label_destino.Text = "Destino:";
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "SC"});
            this.comboBox_destino.Location = new System.Drawing.Point(65, 65);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(80, 21);
            this.comboBox_destino.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data:";
            // 
            // dateTimePicker_data
            // 
            this.dateTimePicker_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_data.Location = new System.Drawing.Point(56, 92);
            this.dateTimePicker_data.Name = "dateTimePicker_data";
            this.dateTimePicker_data.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker_data.TabIndex = 7;
            // 
            // groupBox_transporte
            // 
            this.groupBox_transporte.Controls.Add(this.radioButton_onibus);
            this.groupBox_transporte.Controls.Add(this.radioButton_aviao);
            this.groupBox_transporte.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_transporte.Location = new System.Drawing.Point(236, 65);
            this.groupBox_transporte.Name = "groupBox_transporte";
            this.groupBox_transporte.Size = new System.Drawing.Size(200, 71);
            this.groupBox_transporte.TabIndex = 8;
            this.groupBox_transporte.TabStop = false;
            this.groupBox_transporte.Text = "Meio de transporte";
            // 
            // radioButton_onibus
            // 
            this.radioButton_onibus.AutoSize = true;
            this.radioButton_onibus.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_onibus.Location = new System.Drawing.Point(5, 44);
            this.radioButton_onibus.Name = "radioButton_onibus";
            this.radioButton_onibus.Size = new System.Drawing.Size(68, 20);
            this.radioButton_onibus.TabIndex = 10;
            this.radioButton_onibus.TabStop = true;
            this.radioButton_onibus.Text = "Ônibus";
            this.radioButton_onibus.UseVisualStyleBackColor = true;
            // 
            // radioButton_aviao
            // 
            this.radioButton_aviao.AutoSize = true;
            this.radioButton_aviao.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_aviao.Location = new System.Drawing.Point(5, 20);
            this.radioButton_aviao.Name = "radioButton_aviao";
            this.radioButton_aviao.Size = new System.Drawing.Size(58, 20);
            this.radioButton_aviao.TabIndex = 9;
            this.radioButton_aviao.TabStop = true;
            this.radioButton_aviao.Text = "Avião";
            this.radioButton_aviao.UseVisualStyleBackColor = true;
            // 
            // groupBox_valores
            // 
            this.groupBox_valores.Controls.Add(this.label5);
            this.groupBox_valores.Controls.Add(this.label4);
            this.groupBox_valores.Controls.Add(this.label_numero_total);
            this.groupBox_valores.Controls.Add(this.label_numero_destino);
            this.groupBox_valores.Controls.Add(this.label_numero_transp);
            this.groupBox_valores.Controls.Add(this.label_real);
            this.groupBox_valores.Controls.Add(this.label_valor_total);
            this.groupBox_valores.Controls.Add(this.label_gasto_dest);
            this.groupBox_valores.Controls.Add(this.label_gasto_trans);
            this.groupBox_valores.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_valores.Location = new System.Drawing.Point(15, 142);
            this.groupBox_valores.Name = "groupBox_valores";
            this.groupBox_valores.Size = new System.Drawing.Size(552, 92);
            this.groupBox_valores.TabIndex = 11;
            this.groupBox_valores.TabStop = false;
            this.groupBox_valores.Text = "Valores do Pacote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "R$";
            // 
            // label_numero_total
            // 
            this.label_numero_total.AutoSize = true;
            this.label_numero_total.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero_total.Location = new System.Drawing.Point(405, 45);
            this.label_numero_total.Name = "label_numero_total";
            this.label_numero_total.Size = new System.Drawing.Size(39, 16);
            this.label_numero_total.TabIndex = 15;
            this.label_numero_total.Text = "00,00";
            // 
            // label_numero_destino
            // 
            this.label_numero_destino.AutoSize = true;
            this.label_numero_destino.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero_destino.Location = new System.Drawing.Point(218, 45);
            this.label_numero_destino.Name = "label_numero_destino";
            this.label_numero_destino.Size = new System.Drawing.Size(39, 16);
            this.label_numero_destino.TabIndex = 14;
            this.label_numero_destino.Text = "00,00";
            // 
            // label_numero_transp
            // 
            this.label_numero_transp.AutoSize = true;
            this.label_numero_transp.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero_transp.Location = new System.Drawing.Point(65, 45);
            this.label_numero_transp.Name = "label_numero_transp";
            this.label_numero_transp.Size = new System.Drawing.Size(39, 16);
            this.label_numero_transp.TabIndex = 13;
            this.label_numero_transp.Text = "00,00";
            // 
            // label_real
            // 
            this.label_real.AutoSize = true;
            this.label_real.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_real.Location = new System.Drawing.Point(36, 45);
            this.label_real.Name = "label_real";
            this.label_real.Size = new System.Drawing.Size(23, 16);
            this.label_real.TabIndex = 12;
            this.label_real.Text = "R$";
            // 
            // label_valor_total
            // 
            this.label_valor_total.AutoSize = true;
            this.label_valor_total.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor_total.Location = new System.Drawing.Point(376, 19);
            this.label_valor_total.Name = "label_valor_total";
            this.label_valor_total.Size = new System.Drawing.Size(74, 16);
            this.label_valor_total.TabIndex = 2;
            this.label_valor_total.Text = "Valor Total";
            // 
            // label_gasto_dest
            // 
            this.label_gasto_dest.AutoSize = true;
            this.label_gasto_dest.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gasto_dest.Location = new System.Drawing.Point(189, 19);
            this.label_gasto_dest.Name = "label_gasto_dest";
            this.label_gasto_dest.Size = new System.Drawing.Size(118, 16);
            this.label_gasto_dest.TabIndex = 1;
            this.label_gasto_dest.Text = "Gasto com Destino";
            // 
            // label_gasto_trans
            // 
            this.label_gasto_trans.AutoSize = true;
            this.label_gasto_trans.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gasto_trans.Location = new System.Drawing.Point(36, 19);
            this.label_gasto_trans.Name = "label_gasto_trans";
            this.label_gasto_trans.Size = new System.Drawing.Size(111, 16);
            this.label_gasto_trans.TabIndex = 0;
            this.label_gasto_trans.Text = "Gasto Transporte";
            // 
            // button_confirmar
            // 
            this.button_confirmar.Location = new System.Drawing.Point(454, 40);
            this.button_confirmar.Name = "button_confirmar";
            this.button_confirmar.Size = new System.Drawing.Size(75, 30);
            this.button_confirmar.TabIndex = 12;
            this.button_confirmar.Text = "Confirmar";
            this.button_confirmar.UseVisualStyleBackColor = true;
            this.button_confirmar.Click += new System.EventHandler(this.button_confirmar_Click);
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(454, 76);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(75, 30);
            this.button_calcular.TabIndex = 13;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(535, 76);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 30);
            this.button_sair.TabIndex = 14;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(535, 40);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 30);
            this.button_limpar.TabIndex = 15;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.button_confirmar);
            this.Controls.Add(this.groupBox_valores);
            this.Controls.Add(this.groupBox_transporte);
            this.Controls.Add(this.dateTimePicker_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_destino);
            this.Controls.Add(this.label_destino);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.label_reserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_transporte.ResumeLayout(false);
            this.groupBox_transporte.PerformLayout();
            this.groupBox_valores.ResumeLayout(false);
            this.groupBox_valores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_reserva;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_destino;
        private System.Windows.Forms.ComboBox comboBox_destino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data;
        private System.Windows.Forms.GroupBox groupBox_transporte;
        private System.Windows.Forms.RadioButton radioButton_onibus;
        private System.Windows.Forms.RadioButton radioButton_aviao;
        private System.Windows.Forms.GroupBox groupBox_valores;
        private System.Windows.Forms.Label label_valor_total;
        private System.Windows.Forms.Label label_gasto_dest;
        private System.Windows.Forms.Label label_gasto_trans;
        private System.Windows.Forms.Label label_numero_total;
        private System.Windows.Forms.Label label_numero_destino;
        private System.Windows.Forms.Label label_numero_transp;
        private System.Windows.Forms.Button button_confirmar;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_real;
    }
}

