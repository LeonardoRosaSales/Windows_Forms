namespace Exercicio2.br.com.exrcicio.VIEW
{
    partial class frmCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_clientes = new System.Windows.Forms.TabControl();
            this.page_dadosPessoais = new System.Windows.Forms.TabPage();
            this.cb_certificado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_progresso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_dataInscricao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dg_consulta = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar_consulta = new System.Windows.Forms.Button();
            this.txt_nome_consulta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tab_clientes.SuspendLayout();
            this.page_dadosPessoais.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Participantes de Curso Online";
            // 
            // tab_clientes
            // 
            this.tab_clientes.Controls.Add(this.page_dadosPessoais);
            this.tab_clientes.Controls.Add(this.tabPage2);
            this.tab_clientes.Location = new System.Drawing.Point(8, 106);
            this.tab_clientes.Name = "tab_clientes";
            this.tab_clientes.SelectedIndex = 0;
            this.tab_clientes.Size = new System.Drawing.Size(426, 321);
            this.tab_clientes.TabIndex = 2;
            // 
            // page_dadosPessoais
            // 
            this.page_dadosPessoais.Controls.Add(this.cb_certificado);
            this.page_dadosPessoais.Controls.Add(this.label10);
            this.page_dadosPessoais.Controls.Add(this.txt_progresso);
            this.page_dadosPessoais.Controls.Add(this.label9);
            this.page_dadosPessoais.Controls.Add(this.cb_status);
            this.page_dadosPessoais.Controls.Add(this.label7);
            this.page_dadosPessoais.Controls.Add(this.dtp_dataInscricao);
            this.page_dadosPessoais.Controls.Add(this.label5);
            this.page_dadosPessoais.Controls.Add(this.txt_curso);
            this.page_dadosPessoais.Controls.Add(this.label2);
            this.page_dadosPessoais.Controls.Add(this.txt_telefone);
            this.page_dadosPessoais.Controls.Add(this.btn_pesquisar);
            this.page_dadosPessoais.Controls.Add(this.txt_email);
            this.page_dadosPessoais.Controls.Add(this.label8);
            this.page_dadosPessoais.Controls.Add(this.label6);
            this.page_dadosPessoais.Controls.Add(this.txt_nome);
            this.page_dadosPessoais.Controls.Add(this.label4);
            this.page_dadosPessoais.Controls.Add(this.txt_codigo);
            this.page_dadosPessoais.Controls.Add(this.label3);
            this.page_dadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.page_dadosPessoais.Name = "page_dadosPessoais";
            this.page_dadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.page_dadosPessoais.Size = new System.Drawing.Size(418, 295);
            this.page_dadosPessoais.TabIndex = 0;
            this.page_dadosPessoais.Text = "Dados Pessoais";
            this.page_dadosPessoais.UseVisualStyleBackColor = true;
            // 
            // cb_certificado
            // 
            this.cb_certificado.FormattingEnabled = true;
            this.cb_certificado.Items.AddRange(new object[] {
            "Emitido",
            "Não Emitido"});
            this.cb_certificado.Location = new System.Drawing.Point(80, 208);
            this.cb_certificado.Name = "cb_certificado";
            this.cb_certificado.Size = new System.Drawing.Size(104, 21);
            this.cb_certificado.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(6, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Certificado:";
            // 
            // txt_progresso
            // 
            this.txt_progresso.Location = new System.Drawing.Point(77, 183);
            this.txt_progresso.Name = "txt_progresso";
            this.txt_progresso.Size = new System.Drawing.Size(141, 20);
            this.txt_progresso.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(3, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Progresso:";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Ativo",
            "Concluído",
            "Cancelado"});
            this.cb_status.Location = new System.Drawing.Point(59, 157);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(128, 21);
            this.cb_status.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(9, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Status:";
            // 
            // dtp_dataInscricao
            // 
            this.dtp_dataInscricao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataInscricao.Location = new System.Drawing.Point(119, 133);
            this.dtp_dataInscricao.Name = "dtp_dataInscricao";
            this.dtp_dataInscricao.Size = new System.Drawing.Size(99, 20);
            this.dtp_dataInscricao.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(3, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Data de inscrição:";
            // 
            // txt_curso
            // 
            this.txt_curso.Location = new System.Drawing.Point(97, 106);
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(305, 20);
            this.txt_curso.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Curso inscrito:";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(68, 82);
            this.txt_telefone.Mask = "(99) 9 9999-9999";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(140, 20);
            this.txt_telefone.TabIndex = 32;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_pesquisar.Location = new System.Drawing.Point(10, 235);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(149, 26);
            this.btn_pesquisar.TabIndex = 3;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(69, 58);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(333, 20);
            this.txt_email.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(7, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "E-Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(3, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefone:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(69, 33);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(333, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(10, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(69, 9);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dg_consulta);
            this.tabPage2.Controls.Add(this.btn_pesquisar_consulta);
            this.tabPage2.Controls.Add(this.txt_nome_consulta);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dg_consulta
            // 
            this.dg_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_consulta.Location = new System.Drawing.Point(10, 36);
            this.dg_consulta.Name = "dg_consulta";
            this.dg_consulta.Size = new System.Drawing.Size(403, 253);
            this.dg_consulta.TabIndex = 8;
            // 
            // btn_pesquisar_consulta
            // 
            this.btn_pesquisar_consulta.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_pesquisar_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar_consulta.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar_consulta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_pesquisar_consulta.Location = new System.Drawing.Point(328, 8);
            this.btn_pesquisar_consulta.Name = "btn_pesquisar_consulta";
            this.btn_pesquisar_consulta.Size = new System.Drawing.Size(85, 22);
            this.btn_pesquisar_consulta.TabIndex = 7;
            this.btn_pesquisar_consulta.Text = "Pesquisar";
            this.btn_pesquisar_consulta.UseVisualStyleBackColor = false;
            // 
            // txt_nome_consulta
            // 
            this.txt_nome_consulta.Location = new System.Drawing.Point(61, 10);
            this.txt_nome_consulta.Name = "txt_nome_consulta";
            this.txt_nome_consulta.Size = new System.Drawing.Size(261, 20);
            this.txt_nome_consulta.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(6, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nome:";
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_editar.Location = new System.Drawing.Point(331, 429);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(90, 40);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_excluir.Location = new System.Drawing.Point(220, 429);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(90, 40);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_salvar.Location = new System.Drawing.Point(112, 429);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(90, 40);
            this.btn_salvar.TabIndex = 7;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_novo.Location = new System.Drawing.Point(7, 429);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(90, 40);
            this.btn_novo.TabIndex = 6;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 472);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.tab_clientes);
            this.Controls.Add(this.panel1);
            this.Name = "frmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCurso";
            this.Load += new System.EventHandler(this.frmCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_clientes.ResumeLayout(false);
            this.page_dadosPessoais.ResumeLayout(false);
            this.page_dadosPessoais.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_clientes;
        private System.Windows.Forms.TabPage page_dadosPessoais;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dg_consulta;
        private System.Windows.Forms.Button btn_pesquisar_consulta;
        private System.Windows.Forms.TextBox txt_nome_consulta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_dataInscricao;
        private System.Windows.Forms.ComboBox cb_certificado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_progresso;
        private System.Windows.Forms.Label label9;
    }
}