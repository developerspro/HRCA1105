using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCA1105
{
    class Pessoa
    {
        public string nome;
        public string email;
        public string telefone;
        public string cpf;
        public string dataNasc;
        // falar sobre retorno.
        public void mostraNome()
        {
            Console.WriteLine("nome:{0}",this.nome);
        }

    }
}
