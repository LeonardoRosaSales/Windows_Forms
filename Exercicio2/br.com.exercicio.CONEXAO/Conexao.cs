using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.br.com.exercicio.CONEXAO
{
    internal class Conexao
    {
        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdcursos"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
