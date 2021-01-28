using System;
using System.Collections.Generic;

namespace Listas.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Joao", 15);
            Pessoa p1 = new Pessoa("Leandro", 21);
            Pessoa p2 = new Pessoa("Paulo", 17);
            Pessoa p3 = new Pessoa("Jessica", 18);

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(p);
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);

            p.Listar(lista);
            
            Console.WriteLine(" ");

            p.PessoaMaisVelha(lista);

            Console.WriteLine(" ");

            p.ExcluirMenorDe18(lista);

            Console.WriteLine(" ");

            p.JessicaExiste(lista);

            Console.ReadKey();
        }
    }
}
