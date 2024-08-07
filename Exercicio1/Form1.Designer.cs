namespace Exercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox_nome = new TextBox();
            maskedTextBox_telefone = new MaskedTextBox();
            textBox_endereco = new TextBox();
            textBox_email = new TextBox();
            textBox_prato = new TextBox();
            maskedTextBox_cpf = new MaskedTextBox();
            dateTimePicker_data = new DateTimePicker();
            comboBox_avaliacao = new ComboBox();
            button_cadastrar = new Button();
            button_excluir = new Button();
            button_limpar = new Button();
            dataGridView_lista = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(2, 2);
            label1.Name = "label1";
            label1.Size = new Size(555, 28);
            label1.TabIndex = 0;
            label1.Text = "Avaliação do Cliente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 35);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 62);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 90);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 118);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(263, 37);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 5;
            label6.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(263, 66);
            label7.Name = "label7";
            label7.Size = new Size(168, 23);
            label7.TabIndex = 6;
            label7.Text = "Data da Última Visita:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(263, 93);
            label8.Name = "label8";
            label8.Size = new Size(146, 23);
            label8.TabIndex = 7;
            label8.Text = "Pratos Preferidos:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(262, 120);
            label9.Name = "label9";
            label9.Size = new Size(98, 23);
            label9.TabIndex = 8;
            label9.Text = "Avaliações:";
            // 
            // textBox_nome
            // 
            textBox_nome.Location = new Point(70, 37);
            textBox_nome.Margin = new Padding(3, 2, 3, 2);
            textBox_nome.Name = "textBox_nome";
            textBox_nome.Size = new Size(167, 23);
            textBox_nome.TabIndex = 9;
            // 
            // maskedTextBox_telefone
            // 
            maskedTextBox_telefone.Location = new Point(92, 62);
            maskedTextBox_telefone.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox_telefone.Mask = "(99) 9 9999-9999";
            maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            maskedTextBox_telefone.Size = new Size(145, 23);
            maskedTextBox_telefone.TabIndex = 10;
            // 
            // textBox_endereco
            // 
            textBox_endereco.Location = new Point(101, 90);
            textBox_endereco.Margin = new Padding(3, 2, 3, 2);
            textBox_endereco.Name = "textBox_endereco";
            textBox_endereco.Size = new Size(136, 23);
            textBox_endereco.TabIndex = 11;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(68, 119);
            textBox_email.Margin = new Padding(3, 2, 3, 2);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(168, 23);
            textBox_email.TabIndex = 12;
            // 
            // textBox_prato
            // 
            textBox_prato.Location = new Point(420, 94);
            textBox_prato.Margin = new Padding(3, 2, 3, 2);
            textBox_prato.Name = "textBox_prato";
            textBox_prato.Size = new Size(137, 23);
            textBox_prato.TabIndex = 13;
            // 
            // maskedTextBox_cpf
            // 
            maskedTextBox_cpf.Location = new Point(318, 37);
            maskedTextBox_cpf.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox_cpf.Mask = "999.999.999-99";
            maskedTextBox_cpf.Name = "maskedTextBox_cpf";
            maskedTextBox_cpf.Size = new Size(121, 23);
            maskedTextBox_cpf.TabIndex = 14;
            // 
            // dateTimePicker_data
            // 
            dateTimePicker_data.Format = DateTimePickerFormat.Short;
            dateTimePicker_data.Location = new Point(444, 66);
            dateTimePicker_data.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_data.Name = "dateTimePicker_data";
            dateTimePicker_data.Size = new Size(113, 23);
            dateTimePicker_data.TabIndex = 15;
            // 
            // comboBox_avaliacao
            // 
            comboBox_avaliacao.FormattingEnabled = true;
            comboBox_avaliacao.Items.AddRange(new object[] { "----------", "5 Estrelas", "4 Estrelas", "3 Estrelas", "2 Estrelas", "1 Estrelas" });
            comboBox_avaliacao.Location = new Point(368, 120);
            comboBox_avaliacao.Margin = new Padding(3, 2, 3, 2);
            comboBox_avaliacao.Name = "comboBox_avaliacao";
            comboBox_avaliacao.Size = new Size(114, 23);
            comboBox_avaliacao.TabIndex = 16;
            // 
            // button_cadastrar
            // 
            button_cadastrar.BackColor = Color.Orange;
            button_cadastrar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_cadastrar.ForeColor = SystemColors.ButtonHighlight;
            button_cadastrar.Location = new Point(17, 155);
            button_cadastrar.Margin = new Padding(3, 2, 3, 2);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(131, 38);
            button_cadastrar.TabIndex = 17;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = false;
            button_cadastrar.Click += button_cadastrar_Click;
            // 
            // button_excluir
            // 
            button_excluir.BackColor = Color.Red;
            button_excluir.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_excluir.ForeColor = SystemColors.ButtonHighlight;
            button_excluir.Location = new Point(208, 155);
            button_excluir.Margin = new Padding(3, 2, 3, 2);
            button_excluir.Name = "button_excluir";
            button_excluir.Size = new Size(131, 38);
            button_excluir.TabIndex = 19;
            button_excluir.Text = "Excluir";
            button_excluir.UseVisualStyleBackColor = false;
            button_excluir.Click += button_excluir_Click;
            // 
            // button_limpar
            // 
            button_limpar.BackColor = SystemColors.ButtonHighlight;
            button_limpar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_limpar.Location = new Point(401, 155);
            button_limpar.Margin = new Padding(3, 2, 3, 2);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(131, 38);
            button_limpar.TabIndex = 20;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = false;
            button_limpar.Click += button_limpar_Click;
            // 
            // dataGridView_lista
            // 
            dataGridView_lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_lista.Location = new Point(4, 197);
            dataGridView_lista.Margin = new Padding(3, 2, 3, 2);
            dataGridView_lista.Name = "dataGridView_lista";
            dataGridView_lista.RowHeadersWidth = 51;
            dataGridView_lista.Size = new Size(553, 141);
            dataGridView_lista.TabIndex = 21;
            dataGridView_lista.CellDoubleClick += dataGridView_lista_CellDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(559, 340);
            Controls.Add(dataGridView_lista);
            Controls.Add(button_limpar);
            Controls.Add(button_excluir);
            Controls.Add(button_cadastrar);
            Controls.Add(comboBox_avaliacao);
            Controls.Add(dateTimePicker_data);
            Controls.Add(maskedTextBox_cpf);
            Controls.Add(textBox_prato);
            Controls.Add(textBox_email);
            Controls.Add(textBox_endereco);
            Controls.Add(maskedTextBox_telefone);
            Controls.Add(textBox_nome);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Avaliação do Cliente";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox_nome;
        private MaskedTextBox maskedTextBox_telefone;
        private TextBox textBox_endereco;
        private TextBox textBox_email;
        private TextBox textBox_prato;
        private MaskedTextBox maskedTextBox_cpf;
        private DateTimePicker dateTimePicker_data;
        private ComboBox comboBox_avaliacao;
        private Button button_cadastrar;
        private Button button_excluir;
        private Button button_limpar;
        private DataGridView dataGridView_lista;
    }
}
