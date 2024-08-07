using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_7
{
    static class CadastroUsuario
    {
        private static Usuario[] usuario =
        {
            new Usuario(){Nome = "Cassio", Senha = "1234"},
            new Usuario(){Nome = "Leonardo", Senha = "2203"},
            new Usuario(){Nome = "Ana", Senha = "2309"},
            new Usuario(){Nome = "Yago", Senha = "2605"}
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach(Usuario usuario in usuario)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
