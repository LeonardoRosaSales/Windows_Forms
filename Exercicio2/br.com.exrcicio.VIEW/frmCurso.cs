using Exercicio2.br.com.exercicio.DAO;
using Exercicio2.br.com.exercicio.MODEL;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2.br.com.exrcicio.VIEW
{
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursos obj = new Cursos();

            //1º passo Recolher os dados
            obj.nome = txt_nome.Text;           
            obj.email = txt_email.Text;
            obj.telefone = txt_telefone.Text;
            obj.cursoInscrito = txt_curso.Text;
            obj.dataInscrito = dtp_dataInscricao.Text;
            obj.status = cb_status.Text;
            obj.progresso = txt_progresso.Text;
            obj.certificado = cb_certificado.Text;
            

            //2ºpasso Criar o Objeto e chamar o metodo
            CursosDAO dao = new CursosDAO();
            dao.cadastrarCliente(obj);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CursosDAO dao = new CursosDAO();

            dg_consulta.DataSource = dao.listarCLiente();
        }

        private void dg_consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados
            txt_codigo.Text = dg_consulta.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dg_consulta.CurrentRow.Cells[1].Value.ToString();
            txt_email.Text = dg_consulta.CurrentRow.Cells[2].Value.ToString();
            txt_telefone.Text = dg_consulta.CurrentRow.Cells[3].Value.ToString();
            txt_curso.Text = dg_consulta.CurrentRow.Cells[4].Value.ToString();
            dtp_dataInscricao.Text = dg_consulta.CurrentRow.Cells[5].Value.ToString();
            cb_status.Text = dg_consulta.CurrentRow.Cells[6].Value.ToString();
            txt_progresso.Text = dg_consulta.CurrentRow.Cells[7].Value.ToString();
            cb_certificado.Text = dg_consulta.CurrentRow.Cells[8].Value.ToString();

            //Alterar para guia Dados Pessoais
            tab_clientes.SelectedTab = page_dadosPessoais;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cursos obj = new Cursos();

            //1º passo Recolher os dados
            obj.nome = txt_nome.Text;
            obj.email = txt_email.Text;
            obj.telefone = txt_telefone.Text;
            obj.cursoInscrito = txt_curso.Text;
            obj.dataInscrito = dtp_dataInscricao.Text;
            obj.status = cb_status.Text;
            obj.progresso = txt_progresso.Text;
            obj.certificado = cb_certificado.Text;

            obj.codigo = int.Parse(txt_codigo.Text);

            //2ºpasso Criar o Objeto e chamar o metodo
            CursosDAO dao = new CursosDAO();
            dao.alterarCliente(obj);

            //Recarregar o DataGrid
            dg_consulta.DataSource = dao.listarCLiente();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Cursos obj = new Cursos();

            //1º passo Recolher os dados
            obj.codigo = int.Parse(txt_codigo.Text);

            //2ºpasso Criar o Objeto e chamar o metodo
            CursosDAO dao = new CursosDAO();
            dao.excluirCliente(obj);

            //Recarregar o DataGrid
            dg_consulta.DataSource = dao.listarCLiente();

            //Retorna para pesquisar
            tab_clientes.SelectedTab = tabPage2;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
