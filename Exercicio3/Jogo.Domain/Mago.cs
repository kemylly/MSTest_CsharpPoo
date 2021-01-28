using System;
using System.Collections.Generic;

namespace Jogo.Domain
{
    public class Mago : Personagem
    {
        //construtor
        public Mago():base()
        {
            Nome = "";
            Vida = 0;
            Mana = 0;
            XP = 0;
            Inteligencia =0;
            Forca = 0;
            Level = 0;
        }

        public Mago(String nome, int vida, int mana, float xp, int inteligencia, int forca, int level):base()
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            XP = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        //propriedade
        private List<String> magia;
        public List<String> Magia
        {
            get { return magia; }
            set { magia = value; }
        }

        //metodos
        public int attack(int Inteligencia, int Level)
        {
            int ataque1 = 0;
            Random r = new Random();
            int aux;

            aux = r.Next(300);

            ataque1 = Inteligencia * Level + aux; //calculando ataque

            Console.WriteLine("Numero Randomico : " + aux + " | Total do ataque: " + ataque1);

            //verificar de quem é o maior ataque
            return ataque1;
        }

        public override void LvUp() //aumenta de nivel quando ganha uma luta
        {
            //se mago vencer aumentar o nivel dele
            //atributos mana e inteligencia
            Level++;
            Random r3 = new Random();

            this.Mana = this.Mana + r3.Next(1, 50); //gerar mana aleatoria
            this.Inteligencia = this.Inteligencia + r3.Next(1, 50); //gerar inteligencia aleatoria

            Console.WriteLine("Parabéns Mestre Mago, você subiu de nivel");
            Console.WriteLine("Você recebeu " + Mana + " de mana. E " + Inteligencia + " de inteligencia");
            Console.WriteLine("E agora está no nivel " + Level);
        }

        public void AprenderMagia(int elemento)
        {
            if(elemento == 1) //agua
            {
                    XP = XP + 10;
                    Level = Level + 1;
                    Inteligencia = Inteligencia + 50;
                    Mana = Mana + 50;
                    Forca = Forca + 10;
            }
            else
            {
                if(elemento == 2) //fogo
                {
                    XP = XP + 15;
                    Level = Level + 1;
                    Inteligencia = Inteligencia + 80;
                    Mana = Mana + 40;
                    Forca = Forca + 20;
                }
                else
                {
                    if(elemento == 3) //vento
                    {
                        XP = XP + 15;
                        Level = Level + 1;
                        Inteligencia = Inteligencia + 30;
                        Mana = Mana + 50;
                        Forca = Forca + 20;
                    }
                    else
                    {
                        if(elemento == 4) //terra
                        {
                            XP = XP + 10;
                            Level = Level + 1;
                            Inteligencia = Inteligencia + 40;
                            Mana = Mana + 70;
                            Forca = Forca + 50;
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