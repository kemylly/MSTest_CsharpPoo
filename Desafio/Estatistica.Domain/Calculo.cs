using System;
using System.Linq;

namespace Estatistica.Domain
{
    public class Calculo
    {
        public int Minimo(int[] sequencia)
        {
            int min = sequencia.Min(); //traz o valor minimo

            Console.WriteLine("Valor minimo: {0}", min);
            
            return min;
        }

        public int Maximo(int[] sequencia)
        {
            int max = sequencia.Max(); //traz o valor maximo

            Console.WriteLine("valor maximo: {0}", max);

            return max;
        }

        public int ElementosNaSequencia(int[] sequencia)
        {
            int count = sequencia.Count(); //contar quantos tem no array

            Console.WriteLine("Há {0} elementos na sequencia", count);

            return count;
        }

        public float ValorMedio(int[] sequencia)
        {
            float sum = sequencia.Sum(); //soma os valores
            float count = sequencia.Count(); //conta quantos tem no array

            float resultado = sum / count;  //caluclando a media

            Console.WriteLine("Valor medio: {0}", resultado);

            return resultado;
        }

        public int Soma(int[] sequencia)
        {
            int sum = sequencia.Sum(); //soma os valores

            Console.WriteLine("Soma de todos os valores: {0}", sum);

            return sum;
        }

        public int Ultimo(int[] sequencia)
        {
            int last = sequencia.Last(); //pegar o ultimo valor

            Console.WriteLine("Ultimo valor da sequencia: {0}", last);

            return last;
        }

        public int Primeiro(int[] sequencia)
        {
            int first = sequencia.First(); //pegar o ultimo valor

            Console.WriteLine("Primeiro valor da sequencia: {0}", first);

            return first;
        }
    }
}