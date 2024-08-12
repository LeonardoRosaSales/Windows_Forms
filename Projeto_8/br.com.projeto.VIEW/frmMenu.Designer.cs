namespace Projeto_8.br.com.projeto.VIEW
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_funcionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_clientes_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_clientes_consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_funcionarios_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_funcionarios_consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_configuracao = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_configuracao_trocar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_configuracao_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_usuario_logado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_clientes,
            this.menu_funcionarios,
            this.menu_fornecedores,
            this.menu_produtos,
            this.menu_configuracao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_clientes
            // 
            this.menu_clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_clientes_cadastro,
            this.menu_clientes_consulta});
            this.menu_clientes.Image = global::Projeto_8.Properties.Resources.Clientes;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(77, 20);
            this.menu_clientes.Text = "Clientes";
            // 
            // menu_funcionarios
            // 
            this.menu_funcionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_funcionarios_cadastro,
            this.menu_funcionarios_consulta});
            this.menu_funcionarios.Image = global::Projeto_8.Properties.Resources.Funcionarios;
            this.menu_funcionarios.Name = "menu_funcionarios";
            this.menu_funcionarios.Size = new System.Drawing.Size(103, 20);
            this.menu_funcionarios.Text = "Funcionários";
            // 
            // menu_clientes_cadastro
            // 
            this.menu_clientes_cadastro.Name = "menu_clientes_cadastro";
            this.menu_clientes_cadastro.Size = new System.Drawing.Size(182, 22);
            this.menu_clientes_cadastro.Text = "Cadastro de Clientes";
            // 
            // menu_clientes_consulta
            // 
            this.menu_clientes_consulta.Name = "menu_clientes_consulta";
            this.menu_clientes_consulta.Size = new System.Drawing.Size(182, 22);
            this.menu_clientes_consulta.Text = "Consulta de Clientes";
            // 
            // menu_funcionarios_cadastro
            // 
            this.menu_funcionarios_cadastro.Name = "menu_funcionarios_cadastro";
            this.menu_funcionarios_cadastro.Size = new System.Drawing.Size(208, 22);
            this.menu_funcionarios_cadastro.Text = "Cadastro de Funcionários";
            // 
            // menu_funcionarios_consulta
            // 
            this.menu_funcionarios_consulta.Name = "menu_funcionarios_consulta";
            this.menu_funcionarios_consulta.Size = new System.Drawing.Size(208, 22);
            this.menu_funcionarios_consulta.Text = "Consulta de Funcionários";
            // 
            // menu_fornecedores
            // 
            this.menu_fornecedores.Image = global::Projeto_8.Properties.Resources.Fornecedores;
            this.menu_fornecedores.Name = "menu_fornecedores";
            this.menu_fornecedores.Size = new System.Drawing.Size(106, 20);
            this.menu_fornecedores.Text = "Fornecedores";
            // 
            // menu_produtos
            // 
            this.menu_produtos.Image = global::Projeto_8.Properties.Resources.Produtos;
            this.menu_produtos.Name = "menu_produtos";
            this.menu_produtos.Size = new System.Drawing.Size(83, 20);
            this.menu_produtos.Text = "Produtos";
            // 
            // menu_configuracao
            // 
            this.menu_configuracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_configuracao_trocar,
            this.menu_configuracao_sair});
            this.menu_configuracao.Image = global::Projeto_8.Properties.Resources.Configuracao;
            this.menu_configuracao.Name = "menu_configuracao";
            this.menu_configuracao.Size = new System.Drawing.Size(107, 20);
            this.menu_configuracao.Text = "Configuração";
            // 
            // menu_configuracao_trocar
            // 
            this.menu_configuracao_trocar.Name = "menu_configuracao_trocar";
            this.menu_configuracao_trocar.Size = new System.Drawing.Size(180, 22);
            this.menu_configuracao_trocar.Text = "Trocar Usuário";
            // 
            // menu_configuracao_sair
            // 
            this.menu_configuracao_sair.Name = "menu_configuracao_sair";
            this.menu_configuracao_sair.Size = new System.Drawing.Size(180, 22);
            this.menu_configuracao_sair.Text = "Sair";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txt_data,
            this.toolStripStatusLabel5,
            this.txt_hora,
            this.toolStripStatusLabel4,
            this.txt_usuario_logado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 113);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Data Atual:";
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(73, 17);
            this.txt_data.Text = "12/08/2024";
            // 
            // txt_hora
            // 
            this.txt_hora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(38, 17);
            this.txt_hora.Text = "14:30";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel4.Text = "Usuário Logado:";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel5.Text = "Horário:";
            // 
            // txt_usuario_logado
            // 
            this.txt_usuario_logado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_usuario_logado.Name = "txt_usuario_logado";
            this.txt_usuario_logado.Size = new System.Drawing.Size(59, 17);
            this.txt_usuario_logado.Text = "Leonardo";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 135);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_clientes;
        private System.Windows.Forms.ToolStripMenuItem menu_clientes_cadastro;
        private System.Windows.Forms.ToolStripMenuItem menu_clientes_consulta;
        private System.Windows.Forms.ToolStripMenuItem menu_funcionarios;
        private System.Windows.Forms.ToolStripMenuItem menu_funcionarios_cadastro;
        private System.Windows.Forms.ToolStripMenuItem menu_funcionarios_consulta;
        private System.Windows.Forms.ToolStripMenuItem menu_fornecedores;
        private System.Windows.Forms.ToolStripMenuItem menu_produtos;
        private System.Windows.Forms.ToolStripMenuItem menu_configuracao;
        private System.Windows.Forms.ToolStripMenuItem menu_configuracao_trocar;
        private System.Windows.Forms.ToolStripMenuItem menu_configuracao_sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt_data;
        private System.Windows.Forms.ToolStripStatusLabel txt_hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel txt_usuario_logado;
    }
}