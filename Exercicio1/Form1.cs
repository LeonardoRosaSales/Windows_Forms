using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {

        List<Restaurante> restaurante;

        public Form1()
        {
            InitializeComponent();

            restaurante = new List<Restaurante>();

            comboBox_avaliacao.SelectedIndex = 0;

            dataGridView_lista.Columns.Add("Nome", "Nome");
            dataGridView_lista.Columns.Add("Telefone", "Telefone");
            dataGridView_lista.Columns.Add("Endereco", "Endereço");
            dataGridView_lista.Columns.Add("Email", "Email");
            dataGridView_lista.Columns.Add("Cpf", "CPF");
            dataGridView_lista.Columns.Add("DataVisita", "Data da Última Visita");
            dataGridView_lista.Columns.Add("Pratos", "Pratos Preferidos");
            dataGridView_lista.Columns.Add("Avaliacao", "Avaliações");
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (Restaurante cozinha in restaurante)
            {
                if (cozinha.Nome == textBox_nome.Text)
                {
                    index = restaurante.IndexOf(cozinha);
                }
            }

            if (textBox_nome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome!");
                textBox_nome.Focus();
                return;
            }

            if (maskedTextBox_telefone.Text == "(  )       -")
            {
                MessageBox.Show("Preencha o campo Telefone!");
                maskedTextBox_telefone.Focus();
                return;
            }

            Restaurante r = new Restaurante();

            r.Nome = textBox_nome.Text;
            r.Telefone = maskedTextBox_telefone.Text;
            r.Endereco = textBox_endereco.Text;
            r.Email = textBox_email.Text;
            r.Cpf = maskedTextBox_cpf.Text;
            r.DataVisita = dateTimePicker_data.Text;
            r.Pratos = textBox_prato.Text;
            r.Avaliacao = comboBox_avaliacao.SelectedItem.ToString();

            if (index < 0)
            {
                restaurante.Add(r);
            }
            else
            {
                restaurante[index] = r;
            }

            button_limpar_Click(button_limpar, EventArgs.Empty);

            Listar();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            int indices = dataGridView_lista.CurrentCell.RowIndex;

            restaurante.RemoveAt(indices);

            Listar();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_nome.Text = string.Empty;
            maskedTextBox_telefone.Text = string.Empty;
            textBox_endereco.Text = string.Empty;
            textBox_email.Text = string.Empty;
            maskedTextBox_cpf.Text = string.Empty;
            dateTimePicker_data.Value = DateTime.Now;
            textBox_prato.Text = string.Empty;
            comboBox_avaliacao.SelectedIndex = 0;

            textBox_nome.Focus();
        }
        private void Listar()
        {
            dataGridView_lista.Rows.Clear();

            foreach (Restaurante r in restaurante)
            {
                dataGridView_lista.Rows.Add(
                    r.Nome,
                    r.Telefone,
                    r.Endereco,
                    r.Email,
                    r.Cpf,
                    r.DataVisita,
                    r.Pratos,
                    r.Avaliacao
                    );
            }
        }

        private void dataGridView_lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            Restaurante r = restaurante[indice];

            textBox_nome.Text = r.Nome;
            maskedTextBox_telefone.Text = r.Telefone;
            textBox_endereco.Text = r.Endereco;
            textBox_email.Text = r.Email;
            maskedTextBox_cpf.Text = r.Cpf;
            dateTimePicker_data.Text = r.DataVisita;
            textBox_prato.Text = r.Pratos;
            comboBox_avaliacao.SelectedItem = r.Avaliacao;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            
            while(CadastroUsuario.UsuarioLogado == null)
            {
                Visible = false;
                f.ShowDialog();

                if (FormLogin.Cancelar)
                {
                    Application.Exit();
                    return;
                }
            }
            Visible = true;
        }
    }
}
