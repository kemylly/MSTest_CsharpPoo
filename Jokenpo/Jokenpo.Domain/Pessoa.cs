using System;

namespace Jokenpo.Domain
{
    public class Pessoa
    {
        public Pessoa()
        {
            Nome = "";    
            Jogada = "";
        }
        public Pessoa(string nome, string jogada)
        {
            Nome = nome;    
            Jogada = jogada;
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private string jogada;
        public string Jogada
        {
            get { return jogada; }
            set { jogada = value; }
        }

        //metodo para fazer a partida
        public string Jogar(string nome, string jogada)
        {
            //deixando a jogada minusculo / padrao
            jogada = jogada.ToLower();

            //criando opções de jogo
            string pedra = "pedra"; //1
            string papel = "papel";  //2
            string tesoura = "tesoura";  //3
            string empate = "empate";

            //gerar opnenete aleatorio
            Random p = new Random(); 
            int escolha = p.Next(1, 4);
            string oponente = "Patolino";
            
            //oponente X jogador
            if(jogada == pedra)
            {
                //vendo quem venceu
                if(escolha == 1) //pedra X pedra
                {
                    //empate
                    Console.Clear();
                    Console.WriteLine("\n    JOGO:          \n");
                    Console.WriteLine("=>  " + oponente + " X " + nome);
                    Console.WriteLine("=>  " + pedra + " X " + jogada);
                    Console.WriteLine("\nResultado: Empate :o");

                    return empate;
                }
                else
                {
                    if(escolha == 3) //tesoura X pedra
                    {
                        //jogador venceu
                        Console.Clear();
                        Console.WriteLine("\n    JOGO:          \n");
                        Console.WriteLine("=>  " + oponente + " X " + nome);
                        Console.WriteLine("=>  " + tesoura + " X " + jogada);
                        Console.WriteLine("\nResultado: Você venceu :)");

                        return pedra;  //retora o valor de que venceu quem venceu
                    }
                    else 
                    {
                        if(escolha == 2) //papel X pedra
                        {
                            //jogador perdeu
                            Console.Clear();
                            Console.WriteLine("\n    JOGO:          \n");
                            Console.WriteLine("=>  " + oponente + " X " + nome);
                            Console.WriteLine("=>  " + papel + " X " + jogada);
                            Console.WriteLine("\nResultado: Você perdeu :(");

                            return papel; //retora o valor de que venceu quem venceu
                        }
                        else
                        {
                            Console.WriteLine("Ele sorteia 4??? -_-");
                            return "erro";
                        }
                    }
                }
            }
            else
            {
                if(jogada == papel)
                {
                   //vendo quem venceu
                    if(escolha == 2) //papel X papel
                    {
                        //empate
                        Console.Clear();
                        Console.WriteLine("\n      JOGO:          \n");
                        Console.WriteLine("=>  " + oponente + " X " + nome);
                        Console.WriteLine("=>  " + papel + " X " + jogada);
                        Console.WriteLine("\nResultado: Empate :o");

                        return empate;
                    }
                    else
                    {
                        if(escolha == 1) //pedra X papel
                        {
                            //jogador ganhou
                            Console.Clear();
                            Console.WriteLine("\n    JOGO:          \n");
                            Console.WriteLine("=>  " + oponente + " X " + nome);
                            Console.WriteLine("=>  " + pedra + " X " + jogada);
                            Console.WriteLine("\nResultado: Você venceu :)");

                            return papel;
                        }
                        else
                        {
                            if(escolha == 3)  //tesoura X papel
                            {
                                //jogador perdeu
                                Console.Clear();
                                Console.WriteLine("\n    JOGO:          \n");
                                Console.WriteLine("=>  " + oponente + " X " + nome);
                                Console.WriteLine("=>  " + tesoura + " X " + jogada);
                                Console.WriteLine("\nResultado: Você perdeu :(");

                                return tesoura;
                            }
                            else{
                                //????
                                return "erro";
                            }
                        }
                    }
                }
                else
                {
                    if(jogada == tesoura)
                    {
                        //vendo quem venceu
                        if(escolha == 3) //tesoura X tesoura
                        {
                            //empate
                            Console.Clear();
                            Console.WriteLine("\n    JOGO:          \n");
                            Console.WriteLine("=>  " + oponente + " X " + nome);
                            Console.WriteLine("=>  " + tesoura + " X " + jogada);
                            Console.WriteLine("\nResultado: Empate :o");

                            return empate;
                        }
                        else
                        {
                            if(escolha == 2) //papel X tesoura
                            {
                                //jogador venceu
                                Console.Clear();
                                Console.WriteLine("\n    JOGO:\n");
                                Console.WriteLine("=>  " + oponente + " X " + nome);
                                Console.WriteLine("=>  " + papel + " X " + jogada);
                                Console.WriteLine("\nResultado: Você venceu");

                                return tesoura;
                            }
                            else  
                            {
                                if(escolha == 1) //pedra X tesoura
                                {
                                    Console.Clear();
                                    //jogador perdeu
                                    Console.WriteLine("\n    JOGO: \n");
                                    Console.WriteLine("=>  " + oponente + " X " + nome);
                                    Console.WriteLine("=>  " + pedra + " X " + jogada);
                                    Console.WriteLine("\nResultado: Você perdeu");

                                    return pedra;
                                }
                                else{
                                    //erro
                                    return "erro";
                                }
                            }
                        }
                    }
                    else
                    {
                        //algo deu errado :(
                        Console.WriteLine("Algo deu errado :( ");
                        return "erro";
                    }
                }
            }
        }
    }
}