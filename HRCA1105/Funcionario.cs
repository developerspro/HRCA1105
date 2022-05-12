using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCA1105
{
    class Funcionario : Pessoa
    {
        protected int registro;
        protected double salario;
        protected double inss;
        protected double salarioLiquido;


        public void cadastrarFuncionario()
        {
            this.cadastrar();
            Console.Write("Digite o registro:");
            this.registro = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Salario");
            registraSalario(double.Parse(Console.ReadLine()));

        }

        public void registraSalario(double valor)
        {
            if (valor < 0)
            {
                this.salario = 0;
            } else
            {
                this.salario = valor;
            }
        }

        public void calculaDescontoInss()
        {
            this.inss = this.salario * 0.11;
           
        }
        public void mostraDescontoInss()
        {
            Console.WriteLine("Desconto:" + this.inss);
        }

        public void mostraSalarioBruto()
        {
            Console.WriteLine("Salario:{0}", this.salario);
        }

        public void mostraSalarioLiquido()
        {
            this.calculaDescontoInss();
            this.mostraDescontoInss();
            this.salarioLiquido = this.salario - this.inss;

            Console.WriteLine("Salario Liquido:{0}", this.salarioLiquido);
        }

       
        public void mostraRegistro()
        {
            Console.WriteLine("Registro:{0}", this.registro);
        }

        public void exibirFuncionario()
        {
            this.mostraNome();
            this.mostraSalarioBruto();
            //this.mostraDescontoInss();
            this.mostraSalarioLiquido();
        }
    }
}
