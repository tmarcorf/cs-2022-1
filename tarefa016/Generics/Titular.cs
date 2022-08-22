using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Titular : PessoaBase
    {
        private List<Dependente> _listaDeDependentes { get; set; }

        public Titular(int id, string nome) : 
            base(id, nome)
        {
        }

        public void AdicioneDependentes(List<Dependente> listaDeDependente)
        {
            if (listaDeDependente != null && listaDeDependente.Count > 0)
            {
                _listaDeDependentes = listaDeDependente;
                VinculoTitularDependente.Instancia().Vincule(this, listaDeDependente);
            }
            else
            {
                throw new ArgumentNullException("O dependente não foi informado.");
            }
        }

        public void ListarDependentes()
        {
            if (_listaDeDependentes != null && _listaDeDependentes.Count > 0)
            {
                Console.WriteLine("=== Lista de Dependentes ===");

                _listaDeDependentes.ForEach(dependente =>
                {
                    Console.WriteLine("Id: {0} | Nome: {1}", dependente.Id, dependente.Nome);
                });
            }
        }

        public List<Dependente> ObtenhaListaDeDependentes()
        {
            return _listaDeDependentes;
        }
    }
}
