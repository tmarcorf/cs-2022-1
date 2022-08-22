using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extrair_Subclasse
{
    public abstract class Colaborador
    {
        public int Matricula { get; set; }

        public DateTime TempoDeCasa { get; set; }

        public decimal Salario { get; set; }
    }
}
