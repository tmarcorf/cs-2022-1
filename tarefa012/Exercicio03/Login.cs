using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Login
    {
        public string Usuario { get; set; }

        public string Senha { get; set; }

        public Login(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }

        public bool FazerLogin(string usuario, string senha)
        {
            return 
                this.Usuario.Equals(usuario) && 
                this.Senha.Equals(senha);
        }
    }
}
