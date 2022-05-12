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

        public void cadastrar()
        {
            Console.WriteLine("Digite o nome");
            nome = Console.ReadLine();
            Console.WriteLine("Dgite o email");
             email = Console.ReadLine();
            Console.WriteLine("Digite o telefone");
             telefone = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            cpf = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento");
            dataNasc = Console.ReadLine();

        }

        public void mostraNome()
        {
            Console.WriteLine("nome:{0}",this.nome);
        }

        public void mostraEmail()
        {
            Console.WriteLine("Email:{0}", this.email);
        }

        public void mostraTelefone()
        {
            Console.WriteLine("Telefone:{0}", this.telefone);
        }

        public void mostraCpf()
        {
            Console.WriteLine("CPF:{0}", this.cpf);
        }

        public void mostraDataNasc()
        {
            Console.WriteLine("Data Nascimento:{0}", this.dataNasc);
        }

    }
}
