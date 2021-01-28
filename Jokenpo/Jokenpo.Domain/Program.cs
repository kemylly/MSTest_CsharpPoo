using System;

namespace Jokenpo.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp = 0;

            while(resp != 3)
            {
                resp = Inicio();

                if(resp == 1)  //começa o jogo
                {
                    Pessoa pessoa = new Pessoa();

                    Console.WriteLine("Vamos começar o jogo! ");

                    Console.Write("\nDigite seu nome: ");
                    pessoa.Nome = Console.ReadLine();

                    Console.WriteLine("\nVocê pode escolher entre: ");
                    Console.WriteLine("Pedra"); //1
                    Console.WriteLine("Papel");  //2
                    Console.WriteLine("Tesoura"); //3

                    Console.Write("Digite qual será sua jogada: ");
                    pessoa.Jogada = Console.ReadLine();

                    string pedra = "pedra";
                    string papel = "papel";
                    string tesoura = "tesoura";

                    if(pessoa.Jogada.ToLower() == pedra || pessoa.Jogada.ToLower() == papel || pessoa.Jogada.ToLower() == tesoura)
                    {
                        pessoa.Jogar(pessoa.Nome, pessoa.Jogada);
                    }
                    else{
                        Console.WriteLine("Opção invalida");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                else{
                    if(resp == 2)
                    {
                        Console.WriteLine("Regras do Jokenpo: ");
                        Console.WriteLine("O jogo precisa de dois jogadores.");
                        Console.WriteLine("\nE ele é composto por pelas opções Pedra, Papel ou Tesoura. \n");
                        Console.WriteLine(">>> Pedra empata com Pedra e ganha de Tesoura");
                        Console.WriteLine(">>> Tesoura empata com Tesoura e ganha de Papel");
                        Console.WriteLine(">>> Papel empata com Papel e ganha de Pedra");

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else{
                        //fechar o programa
                    }
                }
            }

            static int Inicio()//menu
            {
                Console.WriteLine("**Bem vindo ao jogo de JOKENPO**");
                Console.WriteLine("1 - Jogar");
                Console.WriteLine("2 - Regras ");
                Console.WriteLine("3 - Sair ");
        
                Console.Write("Resposta: ");
                int resp = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                return resp;
            }
        }
    }
}
