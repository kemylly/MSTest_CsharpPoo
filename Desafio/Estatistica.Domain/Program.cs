using System;
using System.Linq;

namespace Estatistica.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando um array com numeros => sequencia
            int[] numeros = { 2, 0, 7, 3, 1, 9, 5 };

            Console.Write("Array usado: ");

            foreach (var item in numeros)
            {
                Console.Write(" {0} ", item);
            }
            
            Console.WriteLine(" ");

            Calculo c = new Calculo();

            c.Minimo(numeros);
            c.Maximo(numeros);
            c.ElementosNaSequencia(numeros);
            c.ValorMedio(numeros);
            c.Soma(numeros);
            c.Ultimo(numeros);
            c.Primeiro(numeros);
        }
    }
}
