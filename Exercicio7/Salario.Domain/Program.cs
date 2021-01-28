using System;
using Salario.Domain;

namespace SalarioDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando os objetos
            Funcionario g = new Gerente();
            Funcionario v = new Vendedor();
            Funcionario s = new Supervisor();


            //cadastro de informações

            //gerente
            g.Nome = "Ana";
            g.Idade = 37;
            g.Salario = 2000;

            //vendedor
            v.Nome = "Luis";
            v.Idade = 20;
            v.Salario = 1000;

            //supervisor
            s.Nome = "Alex";
            s.Idade = 28;
            s.Salario = 3000;


            //apresentacao do resultado
            Console.WriteLine("Gerente: " + g.Nome);
            Console.WriteLine("Idade: " + g.Idade);
            g.Bonificacao();   //chamando o metodo de bonificacao
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Vendedor: " + v.Nome);
            Console.WriteLine("Idade: " + v.Idade);
            v.Bonificacao();
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Supervisor: " + s.Nome);
            Console.WriteLine("Idade: " + s.Idade);
            s.Bonificacao();
            Console.WriteLine("-----------------------------");

            Console.ReadKey();
        }
    }
}
