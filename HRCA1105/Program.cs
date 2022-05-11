using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCA1105
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.nome = "Donald";
            p.mostraNome();
            Funcionario f = new Funcionario();
            f.nome = "Tio Patinhas";
            f.registraSalario(1000);
            f.descontoInss();
            f.exibirFuncionario();
            Console.WriteLine("--- fim Funcionario ---");
            Console.ReadKey();
            Coordenador c = new Coordenador();
            c.nome = "prof. Pardal";
            c.registraSalario(1295);
            c.descontoInss();
            c.exibirFuncionario();
            Console.WriteLine("--- fim Coordenador ---");
            Console.ReadKey();

        }
    }
}
