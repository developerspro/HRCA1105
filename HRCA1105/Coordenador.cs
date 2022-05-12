using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCA1105
{
    class Coordenador :Funcionario
    {
        public string equipe;

       public override void cadastrar()
        {
            base.cadastrar();
            Console.WriteLine("Digite a equpe");
            equipe = Console.ReadLine();
        }
    }
}
