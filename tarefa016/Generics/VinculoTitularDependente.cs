using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class VinculoTitularDependente
    {
        private static VinculoTitularDependente _instancia;

        public static VinculoTitularDependente Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new VinculoTitularDependente();
            }

            return _instancia;
        }

        public void Vincule(Titular titular, List<Dependente> ListaDeDependentes)
        {
            ListaDeDependentes.ForEach(dependente =>
            {
                dependente.IdTitular = titular.Id;
            });
        }
    }
}
