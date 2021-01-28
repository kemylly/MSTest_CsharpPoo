using System;
using System.Collections.Generic;

namespace Jogo.Domain
{
    public class Guerreiro : Personagem
    {
        public Guerreiro():base()
        {
            Nome = "";
            Vida = 0;
            Mana = 0;
            XP = 0;
            Inteligencia =0;
            Forca = 0;
            Level = 0;
        }

        public Guerreiro(String nome, int vida, int mana, float xp, int inteligencia, int forca, int level):base()
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            XP = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        private List<String> habilidade;
        public List<String> Habilidade
        {
            get { return habilidade; }
            set { habilidade = value; }
        }

        //metodos
        public int attack(int Forca, int Level)
        {
            int ataque1 = 0;
            int aux;

            //Calculando numero randomico e ataque
            Random r = new Random();
            aux = r.Next(300);
            ataque1 = Forca * Level + aux;

           Console.WriteLine("Numero Randomico : " + aux + " | Total do ataque: " + ataque1);

            //verificar de quem é o maior ataque
            return ataque1;
        }

        public override void LvUp() //aumenta de nivel quando ganha uma luta
        {
            //se guerreiro vencer aumentar o nivel dele
            //atributos vida e forca
            Level++;

            Random r3 = new Random();

            Vida = Vida + r3.Next(50); //gerara vida aleatoria
            Forca = Forca + r3.Next(50);  //gerar forca aleatoria

            Console.WriteLine("Parabens grande Guerreiro, você subiu de nivel");
            Console.WriteLine("Você recebeu " + Vida + " de vida. E " + Forca + " de força");
            Console.WriteLine("E agora está no nivel " + Level);
        }

        public void AprenderHabilidade(int elemento)
        {
            if (elemento == 1) //espada
            {
                XP = XP + 10;
                Level = Level + 1;
                Inteligencia = Inteligencia + 50;
                Mana = Mana + 50;
                Forca = Forca + 10;
            }
            else
            {
                if (elemento == 2) //lutar
                {
                    XP = XP + 15;
                    Level = Level + 1;
                    Inteligencia = Inteligencia + 40;
                    Mana = Mana + 40;
                    Forca = Forca + 60;
                }
                else
                {
                    if (elemento == 3) //arco
                    {
                        XP = XP + 15;
                        Level = Level + 1;
                        Inteligencia = Inteligencia + 80;
                        Mana = Mana + 50;
                        Forca = Forca + 40;
                    }
                    else
                    {
                        if (elemento == 4) //lanca
                        {
                            XP = XP + 10;
                            Level = Level + 1;
                            Inteligencia = Inteligencia + 30;
                            Mana = Mana + 60;
                            Forca = Forca + 70;
                        }
                        else
                        {
                            Console.WriteLine("Valor invalido");
                        }
                    }
                }
            }
        }
    }
}