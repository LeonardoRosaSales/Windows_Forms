﻿using MySql.Data.MySqlClient;
using Mysqlx;
using Projeto_8.br.com.projeto.CONEXAO;
using Projeto_8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.DAO
{
    internal class FuncionarioDAO
    {
        #region Conexão
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            conexao = new Conexao().GetConnection();
        }
        #endregion

        #region Cadastrar
        public void cadastrarFuncionario(Funcionarios obj)
        {
            try
            {
                //1º passo - Definir comando SQL
                string sql = @"INSERT INTO tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                             VALUES(@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //2º Passo Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.rg);
                executarcmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executarcmd.Parameters.AddWithValue("@email", obj.email);
                executarcmd.Parameters.AddWithValue("@senha", obj.senha);
                executarcmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executarcmd.Parameters.AddWithValue(@"nivel_acesso", obj.nivel_acesso);
                executarcmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.celular);
                executarcmd.Parameters.AddWithValue("@cep", obj.cep);
                executarcmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executarcmd.Parameters.AddWithValue("@numero", obj.numero);
                executarcmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.estado);

                //3º Passo Abrir conexao e executar o comando SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário Cadastro com Sucesso!");

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
        public DataTable listarFuncionario()
        {
            try
            {
                //1º passo - Instanciar o DataTable
                DataTable tabelaFuncionario = new DataTable();

                //2º passo - Definir comando SQL
                string sql = @"SELECT * FROM tb_funcionarios";

                //3º passo - Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                //4º passo - Abrir conexao e executar o comando SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                //5º passo - Preenchemos os dados do DataTable
                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaFuncionario);

                //6º passo - Fechar Conexão
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }
        #endregion

        #region Alterar
        public void alterarFuncionario(Funcionarios obj)
        {
            try
            {
                //1º passo - Definir comando SQL
                string sql = @"UPDATE tb_funcionarios SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado WHERE id=@id";

                //2º Passo Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.rg);
                executarcmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executarcmd.Parameters.AddWithValue("@email", obj.email);
                executarcmd.Parameters.AddWithValue("@senha", obj.senha);
                executarcmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executarcmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executarcmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.celular);
                executarcmd.Parameters.AddWithValue("@cep", obj.cep);
                executarcmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executarcmd.Parameters.AddWithValue("@numero", obj.numero);
                executarcmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.estado);

                executarcmd.Parameters.AddWithValue("@id", obj.codigo);

                //3º Passo Abrir conexao e executar o comando SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário Alterado com Sucesso!");

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
        public void excluirFuncionario(Funcionarios obj)
        {
            try
            {
                //1º passo - Definir comando SQL
                string sql = @"DELETE FROM tb_funcionarios WHERE id=@id";

                //2º Passo Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@id", obj.codigo);

                //3º Passo Abrir conexao e executar o comando SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário Excluido com Sucesso!");

                //4º Passo Fechar Conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Efetuar Login
        public bool efetuarLogin(string email, string senha)
        {
            try
            {
                //1º passo - Definir comando SQL
                string sql = @"SELECT * FROM tb_funcionarios WHERE email=@email and senha=@senha";

                //2º Passo Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@email", email);
                executarcmd.Parameters.AddWithValue("@senha", senha);

                //3º Passo Abrir conexao e executar o comando SQL
                conexao.Open();
                MySqlDataReader reader = executarcmd.ExecuteReader();

                if(reader.Read())
                {
                    MessageBox.Show("Login relizado com sucesso!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos!");
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                return false;
            }
        }
        #endregion
    }
}
