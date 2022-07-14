using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class LoginInvalidoException : Exception
    {
        public LoginInvalidoException(string mensagem) :
            base(mensagem)
        {
        }
    }
}
