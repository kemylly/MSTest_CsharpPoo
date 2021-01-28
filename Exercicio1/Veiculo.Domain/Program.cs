using System;
//using veiculo1;
using veiculoDomain;

namespace VeiculoDomain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Veiculo v = new Veiculo();

            int inicio = 0;

            while(inicio != 7)
            {
                v.Status();

                Console.WriteLine(" 1 - Acelerar");
                Console.WriteLine(" 2 - Abastecer");
                Console.WriteLine(" 3 - Frear");
                Console.WriteLine(" 4 - Pintar");
                Console.WriteLine(" 5 - Ligar");
                Console.WriteLine(" 6 - Desligar");
                Console.WriteLine(" 7 - Sair");

                Console.WriteLine(" ");
                Console.Write("Digite o numero do que deseja: ");
                inicio = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");

                if (inicio == 1)
                {
                    v.Acelerar();
                    Console.ReadKey();
                }
                else
                {
                    if(inicio == 2)
                    {
                        Console.Write("Digite a quantidade de combustivel que será adicionada: ");
                        int Combustivel = Convert.ToInt32(Console.ReadLine());
                        v.Abastecer(Combustivel);
                        Console.ReadKey();
                    }
                    else
                    {
                        if(inicio == 3)
                        {
                            v.Frear();
                            Console.ReadKey();
                        }
                        else
                        {
                            if(inicio == 4)
                            {
                                Console.Write("Digite uma cor: ");
                                string cor = Console.ReadLine();
                                v.Pintar(cor);
                                Console.ReadKey();
                            }
                            else
                            {
                                if(inicio == 5)
                                {
                                    v.Ligar();
                                    Console.ReadKey();
                                }
                                else
                                {
                                    if(inicio == 6)
                                    {
                                        v.Desligar();
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saindo");
                                    }
                                }
                            }
                        }
                    }
                }
               

                Console.Clear();
            }
        }
    }
}
