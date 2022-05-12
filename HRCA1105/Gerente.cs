using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCA1105
{
    class Gerente : Funcionario
    {
        public string setor;

        public void mostraSetor()
        {
            Console.WriteLine("Setor:"+this.setor);
        }

        public void CadastraSetor()
        {
            Console.Write("Setor:");
            this.setor = Console.ReadLine();
        }
    }
}
