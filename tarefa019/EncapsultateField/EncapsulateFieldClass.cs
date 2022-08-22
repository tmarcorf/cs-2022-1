using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsultateField
{
    public class EncapsulateFieldClass
    {
        private DateTime _dataNascimento = new DateTime(1996, 10, 07);
        private int _idade;

        public int ObtenhaIdade()
        {
            return _idade;
        }

        public void FazerAniversario(DateTime data)
        {
            if (data.Day == _dataNascimento.Day &&
                data.Month == _dataNascimento.Month)
            {
                _idade++;
            }
        }
    }
}
