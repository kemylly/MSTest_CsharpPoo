using System;
using System.Collections.Generic;

namespace Jogo.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            //adicionando coisas ao mago
            Mago m1 = new Mago("Kemylly", 100, 80, 250, 100, 300, 5);
            Mago m2 = new Mago("Patolino", 100, 80, 250, 100, 300, 5);
            Mago m3 = new Mago("Soon", 100, 80, 250, 100, 300, 5);
            
            //adicionando coisas a guerreiro
            Guerreiro g1 = new Guerreiro("Vinycius", 100, 70, 260, 90, 350, 5);
            Guerreiro g2 = new Guerreiro("Hak", 90, 70, 260, 90, 350, 5);
            Guerreiro g3 = new Guerreiro("Yona", 110, 70, 260, 90, 350, 5);
           
            Personagem m = new Mago();
            Personagem g = new Guerreiro();


            Mago mago = new Mago();
            Guerreiro guerreiro = new Guerreiro();

            List<Mago> magos = new List<Mago>();
            magos.Add(m1);
            magos.Add(m2);
            magos.Add(m3);

            List<Guerreiro> guerreiros = new List<Guerreiro>();
            guerreiros.Add(g1);
            guerreiros.Add(g2);
            guerreiros.Add(g3);

            
            String perso = "";
            int resp = 0;
            int escolha = 0;

            while(resp != 5)
            {
                resp = Inicio();
                if (resp == 1) //lista personagens
                {
                    Console.WriteLine("1 - Mago");
                    Console.WriteLine("2 - Guerreiro");
                    Console.Write("Digite o numero da sua escolha: ");
                    escolha = Convert.ToInt32(Console.ReadLine());

                    if(escolha == 1)  // MAGO
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(" NOME   |  VIDA | MANA | INTELIGENCIA | FORCA | LEVEL ");
                        Console.WriteLine(" " + m1.Nome + " |  " + m1.Vida + "  |  " + m1.Mana + "  |  " + m1.Inteligencia + "  |  " + m1.Forca + "  |  " + m1.Level + "  | ");
                        Console.WriteLine(" " + m2.Nome + " |  " + m2.Vida + "  |  " + m2.Mana + "  |  " + m2.Inteligencia + "  |  " + m2.Forca + "  |  " + m2.Level + "  | ");
                        Console.WriteLine(" " + m3.Nome + " |  " + m3.Vida + "  |  " + m3.Mana + "  |  " + m3.Inteligencia + "  |  " + m3.Forca + "  |  " + m3.Level + "  | ");

                        Console.WriteLine(" ");
                        Console.Write("Digite o nome do personagem que deseja: ");
                        perso = Console.ReadLine();

                        if(perso.ToLower() == m1.Nome.ToLower() || perso.ToLower() == m2.Nome.ToLower() || perso.ToLower() == m3.Nome.ToLower())
                        {
                                //escolheu um personagem valido
                        }
                        else
                        {
                            Console.WriteLine("Personagem invalido");
                        }
                    }
                    else
                    {
                        if(escolha == 2)  // GUERREIRO
                        {
                            Console.WriteLine(" NOME   |  VIDA | MANA | INTELIGENCIA | FORCA | LEVEL ");
                            Console.WriteLine(" " + g1.Nome + " |  " + g1.Vida + "  |  " + g1.Mana + "  |  " + g1.Inteligencia + "  |  " + g1.Forca + "  |  " + g1.Level + "  |  ");
                            Console.WriteLine(" " + g2.Nome + " |  " + g2.Vida + "  |  " + g2.Mana + "  |  " + g2.Inteligencia + "  |  " + g2.Forca + "  |  " + g2.Level + "  |  ");
                            Console.WriteLine(" " + g3.Nome + " |  " + g3.Vida + "  |  " + g3.Mana + "  |  " + g3.Inteligencia + "  |  " + g3.Forca + "  |  " + g3.Level + "  |  ");

                            Console.WriteLine(" ");
                            Console.Write("Digite o nome do personagem que deseja: ");
                            perso = Console.ReadLine();

                            if(perso.ToLower() == g1.Nome.ToLower() || perso.ToLower() == g2.Nome.ToLower() || perso.ToLower() == g3.Nome.ToLower())
                            {
                                //escolehu um personagem valido
                            }
                            else
                            {
                                Console.WriteLine("Personagem invalido");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Resposta invalida");
                        }
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                //fim da lista de personagens

                else
                {
                    if(resp == 2) //lista magias
                    {
                        ///tenho que pegar o personagem do jogador
                        if(escolha == 1)
                        {
                            for (int s = 0; s < magos.Count; s++)
                            {
                                Mago ma = magos[s];
                               
                                if (perso.ToLower() == ma.Nome.ToLower())
                                {
                                    Console.WriteLine("Digite o numero da magia que deseja aprender: ");

                                    List<String> Magia = new List<String>();
                                    Magia.Add("Agua");
                                    Magia.Add("Fogo");
                                    Magia.Add("Vento");
                                    Magia.Add("Terra");

                                    int num = 1;
                                    for (int i = 0; i < Magia.Count; i++)
                                    {
                                        Console.WriteLine(num + " - Magia de " + Magia[i]);
                                        num++;
                                    }

                                    Console.Write("Resposta: ");
                                    int elemento = Convert.ToInt32(Console.ReadLine());

                                    ma.AprenderMagia(elemento);

                                    Console.WriteLine("Poderes atuais: ");
                                    Console.WriteLine("  NOME   |  XP  | MANA | INTELIGENCIA | FORCA | LEVEL ");
                                    Console.WriteLine("-> " + ma.Nome + " |  " + ma.XP + "  |  " + ma.Mana + "  |  " + ma.Inteligencia + "  |  " + ma.Forca + "  |  " + ma.Level + "  | ");
                                }
                            }
                        }
                        else
                        {
                            if(escolha == 2)
                            {
                                Console.WriteLine("Você escolheu um personagem Guerreiro. Ele não consegue aprender magia.");
                                Console.WriteLine("Vá em Listar Habilidades e escolha alguma!");
                            }
                            else
                            {
                                Console.WriteLine("Parece que voce não escolheu um personagem ainda.");
                                Console.WriteLine("Vá em Listar personagens e escolha algum!");
                            }
                        }
                        
                        Console.ReadKey();
                        Console.Clear();
                    }
                    //fim do aprender magias

                    else
                    {
                        if(resp == 3) //listar habilidades
                        {
                            if (escolha == 1)
                            {
                                Console.WriteLine("Você escolheu um personagem Mago. Ele não consgue aprender Habilidades.");
                                Console.WriteLine("Vá em Listar Magias e escolha alguma!");
                            }
                            else
                            {
                                if (escolha == 2) //listar habilidades
                                {
                                    for (int s = 0; s < guerreiros.Count; s++)
                                    {
                                        Guerreiro gr = guerreiros[s];
                                        
                                        if (perso.ToLower() == gr.Nome.ToLower())
                                        {
                                            Console.WriteLine("Digite o numero da habilidade que deseja aprender: ");

                                            List<String> Habilidade = new List<String>(); //lista das habilidades
                                            Habilidade.Add("Espada");
                                            Habilidade.Add("Lutar");
                                            Habilidade.Add("Arco");
                                            Habilidade.Add("Lança");

                                            int num = 1;
                                            for (int h = 0; h < Habilidade.Count; h++)
                                            {
                                                Console.WriteLine(num + " - Habilidade: " + Habilidade[h]);
                                                num++;
                                            }

                                            Console.Write("Resposta: ");
                                            int elemento = Convert.ToInt32(Console.ReadLine());

                                            gr.AprenderHabilidade(elemento);

                                            Console.WriteLine("Poderes atuais: ");
                                            Console.WriteLine("  NOME   |  XP  | MANA | INTELIGENCIA | FORCA | LEVEL ");
                                            Console.WriteLine("-> " + gr.Nome + " |  " + gr.XP + "  |  " + gr.Mana + "  |  " + gr.Inteligencia + "  |  " + gr.Forca + "  |  " + gr.Level + "  | ");
                                        }
                                    }
                                   
                                }
                                else
                                {
                                    Console.WriteLine("Parece que voce não escolheu um personagem ainda!");
                                    Console.WriteLine("Vá em Listar personagens e escolha algum!");
                                }
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        //fim do listar habilidades

                        else
                        {
                            if(resp == 4) //luta - batalha
                            {
                                //gerar dinamicamente o personagem o pc
                                //pegar o personagem do player
                                Personagem p = new Personagem();
                                
                                if (escolha == 1) //personagem MAGO
                                {
                                    //gerar jogador aleatorio para o pc
                                    Random r1 = new Random(); //inteligencia aleatoria
                                    Random r2 = new Random(); //level aleatorio

                                    int Inteligencia1 = r1.Next(100);
                                    int Level1 = r2.Next(5);

                                    String Nome1 = "Pro-player";

                                    Console.WriteLine("** Jogador 1 **");
                                    Console.WriteLine("Nome: " + Nome1 + " | Inteligencia: " + Inteligencia1 + " | Nivel: " + Level1);
                                    int ataque2 = mago.attack(Inteligencia1, Level1);

                                    for (int s = 0; s < magos.Count; s++)
                                    {
                                        Mago mo = magos[s];
                                        
                                        if (perso.ToLower() == mo.Nome.ToLower())
                                        {
                                            Console.WriteLine("\n** Jogador 2 **");
                                            Console.WriteLine("Nome: " + mo.Nome + " | Inteligencia: " + mo.Inteligencia + " | Nivel: " + mo.Level);
                                            int ataque1 = mo.attack(mo.Inteligencia, mo.Level);

                                            //contabilizacao do vencedor
                                            //chamar level up para contabilizar o vencedor
                                            if(ataque1 > ataque2)
                                            {
                                                Console.WriteLine("\nVocê venceu!\n");
                                                mo.LvUp();
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nVocê perdeu!\n");
                                            }
                                        }
                                    }
                                }

                                else
                                {
                                    if(escolha == 2) //personagem GUERREIRO
                                    {
                                        //gerar jogador aleatorio para o pc
                                        Random r1 = new Random(); //inteligencia aleatoria
                                        Random r2 = new Random(); //level aleatorio

                                        int Forca1 = r1.Next(100);
                                        int Level1 = r2.Next(5);

                                        String Nome1 = "Pro-player";

                                        Console.WriteLine("** Jogador 1 **");
                                        Console.WriteLine("Nome: " + Nome1 + " | Inteligencia: " + Forca1 + " | Nivel: " + Level1);
                                        int ataque2 = mago.attack(Forca1, Level1);

                                        for (int s = 0; s < guerreiros.Count; s++)
                                        {
                                            Guerreiro go = guerreiros[s];
                                        
                                            if (perso.ToLower() == go.Nome.ToLower())
                                            {
                                                Console.WriteLine("\n** Jogador 2 **");
                                                Console.WriteLine("Nome: " + go.Nome + " | Inteligencia: " + go.Forca + " | Nivel: " + go.Level);
                                                int ataque1 = go.attack(go.Forca, go.Level);

                                                //contabilizacao do vencedor
                                                //chamar level up para contabilizar o vencedor
                                                if(ataque1 > ataque2)
                                                {
                                                    Console.WriteLine("\nVocê venceu!\n");
                                                    go.LvUp();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nVocê perdeu!\n");
                                                }
                                            }
                                        } 
                                    }
                                    else
                                    {
                                        Console.WriteLine("Parece que você não escolheu um personagem ainda!");
                                        Console.WriteLine("Vá em Listar personagens e escolha algum!");
                                    }
                                }

                                Console.ReadKey();
                                Console.Clear();
                            }
                            //fim da luta

                            else
                            {
                                //fecha o programa
                            }
                        }
                    }
                }
            }
            static int Inicio()//menu
            {
                Console.WriteLine("**Bem vindo aos Gurreiros vs Magos**");
                Console.WriteLine("1 - Listar personagens");
                Console.WriteLine("2 - Listar Magias ");
                Console.WriteLine("3 - Listar Habilidades ");
                Console.WriteLine("4 - Lutar ");
                Console.WriteLine("5 - Sair ");
                Console.Write("Resposta: ");
                int resp = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                return resp;
            }
        }
    }
}
