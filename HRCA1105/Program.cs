﻿using System;
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
         
            Funcionario f = new Funcionario();
            f.cadastrarFuncionario();
            f.exibirFuncionario();
            Console.WriteLine("--- fim Funcionario ---");
            Console.ReadKey();
            Coordenador c = new Coordenador();
            c.nome = "prof. Pardal";
            c.registraSalario(1295);
            c.calculaDescontoInss();
            c.exibirFuncionario();
            Console.WriteLine("--- fim Coordenador ---");
            Console.ReadKey();

        }
    }
}
