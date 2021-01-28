using System;
using System.Collections.Generic;

namespace Exercicio2.Domain
{
    public class Loja
    {
         //construtor
        public Loja()
        {
            this.Nome = "";
            this.Cnpj = "";
        }

        //sobrecarga, puxa list livro
        public Loja(String nome, String cnpj, List<Livro> livro, List<VideoGame> videogame)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
        }

        private List<Livro> livro;
        public List<Livro> Livro
        {
            get { return livro; }
            set { livro = value; }
        }

        private List<VideoGame> videogame;
        public List<VideoGame> VideoGame
        {
            get { return videogame; }
            set { videogame = value; }
        }

        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String cnpj;
        public String Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        //metodos
        public int Listalivros() //lista todos os livros que uma loja tem
        {
            int teste = 0;
            if(Livro != null) //verificando a dispoibilidade e depois listando
            {
                try{
                    foreach (var item in this.Livro)
                    {
                        var livro = item;
                        Console.WriteLine("Livro: " + item.Nome + ", " + item.Preco + " reais e tem " + item.Qtd + " em estoque");
                    }
                    return teste = 1;
                }catch{
                    Console.WriteLine("Houve algum erro na hora de retornar os livros");
                    return teste = 2;
                }
            }
            else
            {
                Console.WriteLine("A loja não tem livros no seu estoque.");
                return teste = 3;
            }
        }

        public int Listavideogame()  //lista todos os vídeo games que uma loja
        {
            int teste = 0;
            if(VideoGame != null) 
            {
                try{
                    foreach(var game in this.VideoGame)
                    {
                        var video = game;
                        Console.WriteLine("Video-game: "+ game.Modelo + ", " + game.Preco + " cada e " + game.Qtd + " de estoque");
                    }
                    return teste = 1;
                }catch{
                    Console.WriteLine("Houve algum erro na hora de retornar os video games");
                    return teste = 2;
                }
            }
            else
            {
                Console.WriteLine("A loja não tem video-games no seu estoque.");
                return teste = 3;
            }
        }

        //calculo de patrimonio
        public double CalculaPatrimonio()
        {
            double patrimonio = 0; 

            if(Livro != null)
            {
                for (int p = 0; p < Livro.Count; p++)
                {
                    patrimonio = Livro[p].Preco + patrimonio; 
                }
            }
            
            if(VideoGame != null)
            {
                for (int p = 0; p < VideoGame.Count; p++)
                {
                    patrimonio = VideoGame[p].Preco + patrimonio; 
                }
            }

            
            Console.WriteLine("O valor do patrimonio fica "+ patrimonio + " reais");
            
            return patrimonio;
        }
    }
}