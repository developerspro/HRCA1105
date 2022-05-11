using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCA1105
{
    class Funcionario : Pessoa
    {
        public int registro;
        protected double salario;
        public double inss;
        protected double salarioLiquido;

        


        public void registraSalario(double valor)
        {
            this.salario = valor;
        }

        public void descontoInss()
        {
            this.inss = this.salario * 0.11;
           
        }
        public void mostraDescontoInss()
        {
            Console.WriteLine("Desconto:" + this.inss);
        }
        public void mostraEmail()
        {
            Console.WriteLine("E-mail:{0}",this.email);
        }

        public void mostraSalarioBruto()
        {
            Console.WriteLine("Salario:{0}", this.salario);
        }

        public void mostraSalarioLiquido()
        {
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
            this.mostraDescontoInss();
            this.mostraSalarioLiquido();
        }
    }
}
