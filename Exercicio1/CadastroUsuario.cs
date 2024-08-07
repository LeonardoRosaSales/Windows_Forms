using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    static class CadastroUsuario
    {
        private static Restaurante[] usuario =
        {
            new Restaurante(){Usuario = "Cassio", Senha = "1234"},
            new Restaurante(){Usuario = "Leonardo", Senha = "2203"},
            new Restaurante(){Usuario = "Ana", Senha = "2309"},
            new Restaurante(){Usuario = "Yago", Senha = "2605"}
        };

        private static Restaurante _userLogado = null;

        public static Restaurante UsuarioLogado
        {
            get { return _userLogado; } 
            set { _userLogado = value;  }
        }

        public static bool Login(string nome, string senha)
        {
            foreach(Restaurante usuarios in usuario)
            {
                if(usuarios.Usuario == nome && usuarios.Senha == senha)
                {
                    UsuarioLogado = usuarios;
                    return true;
                }
            }
            return false;
        }
    }
}
