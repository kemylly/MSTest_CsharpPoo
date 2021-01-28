using System.Collections.Generic;
using Exercicio2.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicio2.Tests
{
    [TestClass]
    public class LojaTests
    {
        [TestMethod]
        public void Listar_Livros_adicionados_a_uma_loja() //teste feliz => retorno 1
        {
            Livro l1 = new Livro("garoto 21", 40, 50, "Matthew Quick", "Fantasia", 300);

            List<Livro> l = new List<Livro>();
            l.Add(l1);
            
            Loja americanas = new Loja("Americanas", "12345678", null, null);
            americanas.Livro = l;

            int teste = americanas.Listalivros();

            Assert.IsTrue(teste == 1);
        }

        [TestMethod]
        public void Dado_uma_lista_vazia_deve_informar_que_não_tem_livros_e_retornar_3()
        {
            Loja americanas = new Loja("Americanas", "12345678", null, null);

            int teste = americanas.Listalivros();

            Assert.IsTrue(teste == 3);
        }

        [TestMethod]
        public void Listar_VideoGame_adicionados_a_uma_loja() //teste feliz => retorno 1
        {
            VideoGame PS4 = new VideoGame("PS4", 1800, 90, "Sony", "Slim", false); 

            List<VideoGame> vg = new List<VideoGame>();
            vg.Add(PS4);

            Loja americanas = new Loja("Americanas", "12345678", null, null);
            americanas.VideoGame = vg;

            int teste = americanas.Listavideogame();

            Assert.IsTrue(teste == 1);
        }

        [TestMethod]
        public void Dado_uma_lista_vazia_deve_informar_que_não_tem_videogame_e_retornar_3()
        {
            Loja americanas = new Loja("Americanas", "12345678", null, null);

            int teste = americanas.Listavideogame();

            Assert.IsTrue(teste == 3);
        }

        [TestMethod]
        public void Calculo_Patriomonio_com_livros_e_video_game() //teste feliz => retorno da soma dos preços do livro+videogame
        {
            Livro l1 = new Livro("garoto 21", 40, 50, "Matthew Quick", "Fantasia", 300);
            List<Livro> l = new List<Livro>();
            l.Add(l1);

            VideoGame PS4 = new VideoGame("PS4", 1800, 90, "Sony", "Slim", false); 
            List<VideoGame> vg = new List<VideoGame>();
            vg.Add(PS4);

            Loja americanas = new Loja("Americanas", "12345678", null, null);
            americanas.Livro = l;
            americanas.VideoGame = vg;
            
            double patrimonio = americanas.CalculaPatrimonio();

            Assert.IsTrue(patrimonio == 1840);
        }

        [TestMethod]
        public void Calcula_Patriomonio_apenas_com_os_livros()
        {
            Livro l1 = new Livro("garoto 21", 40, 50, "Matthew Quick", "Fantasia", 300);
            List<Livro> l = new List<Livro>();
            l.Add(l1);

            Loja americanas = new Loja("Americanas", "12345678", null, null);
            americanas.Livro = l;
            
            double patrimonio = americanas.CalculaPatrimonio();

            Assert.IsTrue(patrimonio == 40);
        }

        [TestMethod]
        public void Calcula_Patriomonio_apenas_com_videogame()
        {
            VideoGame PS4 = new VideoGame("PS4", 1800, 90, "Sony", "Slim", false); 
            List<VideoGame> vg = new List<VideoGame>();
            vg.Add(PS4);

            Loja americanas = new Loja("Americanas", "12345678", null, null);
            americanas.VideoGame = vg;
            
            double patrimonio = americanas.CalculaPatrimonio();

            Assert.IsTrue(patrimonio == 1800);
        }

        [TestMethod]
        public void Calcular_Patriomonio_vazio_que_não_tem_livros_nem_videogame_adicionado_deve_retornar_0()
        {
            Loja americanas = new Loja("Americanas", "12345678", null, null);
            
            double patrimonio = americanas.CalculaPatrimonio();

            Assert.IsTrue(patrimonio == 0);
        }
    }
}