using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCA1105
{
    class Cliente :Pessoa
    {
        private int codigo;


        public override void cadastrar()
        {
            Console.WriteLine("Digite o codigo");
            codigo = int.Parse(Console.ReadLine());
        }

        public void exibirCodigo()
        {
            Console.WriteLine("Codigo:"+this.codigo);
        }
    }
}
