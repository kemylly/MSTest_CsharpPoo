using System;
using System.Collections.Generic;

namespace Exercicio2.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            //nome, perco, quantide de estoque, autor, tema, quantidade de pagina
            Livro l1 = new Livro("garoto 21", 40, 50, "Matthew Quick", "Fantasia", 300); //garoto 21
            Livro l2 = new Livro("A jornada", 60, 30, "Erin e Moulton", "educativo", 500); //a jornada
            Livro l3 = new Livro("Sing", 20, 50, "Vivi Greene", "Romance", 500); //sing

            //Nome, preco, qtd, marca, modelo, isusuario
            VideoGame PS4 = new VideoGame("PS4", 1800, 90, "Sony", "Slim", false); 
            VideoGame PS4usado = new VideoGame("PS3", 1500, 100, "Sony", "Slim", true); 
            VideoGame XBOX = new VideoGame("PS5", 2000, 10, "Sony", "Slim", false); 

            var l = new List<Livro>();
            l.Add(l1);
            l.Add(l2);
            l.Add(l3);

            var vg = new List<VideoGame>();
            vg.Add(PS4);
            vg.Add(PS4usado);
            vg.Add(XBOX);

            Loja americanas = new Loja("Americanas", "12345678", null, null);
            americanas.Livro = l;
            americanas.VideoGame = vg;

            l1.CalculaImposto();
            l2.CalculaImposto();
            l3.CalculaImposto();

            Console.WriteLine(" ");

            PS4usado.CalculaImposto();
            PS4.CalculaImposto();
            XBOX.CalculaImposto();

            Console.WriteLine(" ");

            americanas.Listalivros();
            Console.WriteLine(" ");
            americanas.Listavideogame();
            Console.WriteLine(" ");
            americanas.CalculaPatrimonio();
        }
    }
}
