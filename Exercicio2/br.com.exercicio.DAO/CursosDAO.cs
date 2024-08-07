using Exercicio2.br.com.exercicio.CONEXAO;
using Exercicio2.br.com.exercicio.MODEL;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicio2.br.com.exercicio.DAO
{
    internal class CursosDAO
    {
        #region Conexão
        private MySqlConnection conexao;

        public CursosDAO()
        {
            conexao = new Conexao().GetConnection();
        }
        #endregion

        #region Cadastrar
        public void cadastrarCliente(Cursos obj)
        {
            try
            {
                //1º passo - Definir comando SQL
                string sql = @"INSERT INTO alunos (nome, email, telefone, curso, data_inscricao, statusS, progresso, certificado)
                             VALUES (@nome, @email, @telefone, @curso, @data_inscricao, @statusS, @progresso, @certificado)";

                //2º Passo Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.nome);
                executarcmd.Parameters.AddWithValue("@email", obj.email);
                executarcmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executarcmd.Parameters.AddWithValue("@curso", obj.cursoInscrito);
                executarcmd.Parameters.AddWithValue("@data_inscricao", obj.dataInscrito);
                executarcmd.Parameters.AddWithValue("@statusS", obj.status);
                executarcmd.Parameters.AddWithValue("@progresso", obj.progresso);
                executarcmd.Parameters.AddWithValue("@certificado", obj.certificado);

                //3º Passo Abrir conexao e executar o comando SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastro com Sucesso!");

                //4º Passo Fechar Conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Listar
        public DataTable listarCLiente()
        {
            try
            {
                //1º passo - Instanciar o DataTable
                DataTable tabelaCliente = new DataTable();

                //2º passo - Definir comando SQL
                string sql = @"SELECT * FROM tb_clientes";

                //3º passo - Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                //4º passo - Abrir conexao e executar o comando SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                //5º passo - Preenchemos os dados do DataTable
                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaCliente);

                //6º passo - Fechar Conexão
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }
        #endregion

        #region Alterar
        public void alterarCliente(Cursos obj)
        {
            try
            {
                //1º passo - Definir comando SQL
                string sql = @"UPDATE alunos SET nome=@nome, email=@email, telefone=@telefone, curso=@curso, data_inscricao=@data_inscricao, statusS=@statusS, progresso=@progresso, certificado=@certificado WHERE id=@id";

                //2º Passo Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.nome);
                executarcmd.Parameters.AddWithValue("@email", obj.email);
                executarcmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executarcmd.Parameters.AddWithValue("@curso", obj.cursoInscrito);
                executarcmd.Parameters.AddWithValue("@data_inscricao", obj.dataInscrito);
                executarcmd.Parameters.AddWithValue("@statusS", obj.status);
                executarcmd.Parameters.AddWithValue("@progresso", obj.progresso);
                executarcmd.Parameters.AddWithValue("@certificado", obj.certificado);

                executarcmd.Parameters.AddWithValue("@id", obj.codigo);

                //3º Passo Abrir conexao e executar o comando SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Alterado com Sucesso!");

                //4º Passo Fechar Conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Excluir
        public void excluirCliente(Cursos obj)
        {
            try
            {
                //1º passo - Definir comando SQL
                string sql = @"DELETE FROM tb_clientes WHERE id=@id";

                //2º Passo Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@id", obj.codigo);

                //3º Passo Abrir conexao e executar o comando SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com Sucesso!");

                //4º Passo Fechar Conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion
    }
}
