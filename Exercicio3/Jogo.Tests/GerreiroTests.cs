using Jogo.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jogo.Tests
{
    [TestClass]
    public class GerreiroTests
    {
        [TestMethod]
        public void Dado_o_calculo_inteligencia_vezes_level_de_um_guerreiro_deve_retornar_o_valor_do_ataque()
        {
            var go = new Guerreiro();
            go.Nome = "Hak";
            go.Vida = 100;
            go.Mana = 70;
            go.XP = 206;
            go.Inteligencia = 90;
            go.Forca = 300;
            go.Level = 1;
            go.Habilidade = null;
            
            var ataque1 = go.attack(go.Forca, go.Level);

            //não dá para medir exatamente o quanto é um ataque, porque é somado com um numero aleatorio
            //mas sabe-se que é um numero maior ou igual a inteligencia multiplicada pelo nivel
            Assert.IsTrue(ataque1 >= 90);
        }

        [TestMethod] //LvUp
        public void Subir_de_nivel_quando_vencer_uma_batalha_seus_atributos_devem_aumentar()
        {
            var go = new Guerreiro();
            go.Nome = "Hak";
            go.Vida = 100; //aumenta
            go.Mana = 70;
            go.XP = 206;
            go.Inteligencia = 90;
            go.Forca = 300; //aumenta
            go.Level = 1; //aumenta
            go.Habilidade = null;

            int Vida = go.Vida;
            int Forca = go.Forca;
            int Level = go.Level;

            go.LvUp();

            Assert.IsTrue(Level < go.Level && Vida < go.Vida && Forca < go.Forca);
        }

        [TestMethod]
        public void Aprender_Habilidade_de_espada_seus_atributos_devem_aumentar()
        {
            var go = new Guerreiro();
            go.Nome = "Hak";
            go.Vida = 100;
            go.Mana = 70; //aumenta
            go.XP = 206; //aumenta
            go.Inteligencia = 90; //aumenta
            go.Forca = 300; //aumenta
            go.Level = 1; //aumenta

            float xp = go.XP;
            int level = go.Level;
            int inteligencia = go.Inteligencia;
            int mana = go.Mana;
            int forca = go.Forca;
            int elemento = 1;

            go.AprenderHabilidade(elemento);
            
            Assert.IsTrue(go.Level > level && mana < go.Mana && inteligencia < go.Inteligencia && xp < go.XP && forca < go.Forca);
        }

        [TestMethod]
        public void Aprender_Habilidade_de_lutar_seus_atributos_devem_aumentar()
        {
            var go = new Guerreiro();
            go.Nome = "Hak";
            go.Vida = 100;
            go.Mana = 70; //aumenta
            go.XP = 206; //aumenta
            go.Inteligencia = 90; //aumenta
            go.Forca = 300; //aumenta
            go.Level = 1; //aumenta

            float xp = go.XP;
            int level = go.Level;
            int inteligencia = go.Inteligencia;
            int mana = go.Mana;
            int forca = go.Forca;
            int elemento = 2;

            go.AprenderHabilidade(elemento);
            
            Assert.IsTrue(go.Level > level && mana < go.Mana && inteligencia < go.Inteligencia && xp < go.XP && forca < go.Forca);
        }

        [TestMethod]
        public void Aprender_Habilidade_de_arco_seus_atributos_devem_aumentar()
        {
            var go = new Guerreiro();
            go.Nome = "Hak";
            go.Vida = 100;
            go.Mana = 70; //aumenta
            go.XP = 206; //aumenta
            go.Inteligencia = 90; //aumenta
            go.Forca = 300; //aumenta
            go.Level = 1; //aumenta

            float xp = go.XP;
            int level = go.Level;
            int inteligencia = go.Inteligencia;
            int mana = go.Mana;
            int forca = go.Forca;
            int elemento = 3;

            go.AprenderHabilidade(elemento);
            
            Assert.IsTrue(go.Level > level && mana < go.Mana && inteligencia < go.Inteligencia && xp < go.XP && forca < go.Forca);
        }

        [TestMethod]
        public void Aprender_Habilidade_de_lanca_seus_atributos_devem_aumentar()
        {
            var go = new Guerreiro();
            go.Nome = "Hak";
            go.Vida = 100;
            go.Mana = 70; //aumenta
            go.XP = 206; //aumenta
            go.Inteligencia = 90; //aumenta
            go.Forca = 300; //aumenta
            go.Level = 1; //aumenta

            float xp = go.XP;
            int level = go.Level;
            int inteligencia = go.Inteligencia;
            int mana = go.Mana;
            int forca = go.Forca;
            int elemento = 4;

            go.AprenderHabilidade(elemento);
            
            Assert.IsTrue(go.Level > level && mana < go.Mana && inteligencia < go.Inteligencia && xp < go.XP && forca < go.Forca);
        }

        [TestMethod]
        public void Passar_um_valor_invalido_em_Aprender_Habilidade_seus_atributos_devem_pemanecer_igual()
        {
            var go = new Guerreiro();
            go.Nome = "Hak";
            go.Vida = 100;
            go.Mana = 70; //aumenta
            go.XP = 206; //aumenta
            go.Inteligencia = 90; //aumenta
            go.Forca = 300; //aumenta
            go.Level = 1; //aumenta

            float xp = go.XP;
            int level = go.Level;
            int inteligencia = go.Inteligencia;
            int mana = go.Mana;
            int forca = go.Forca;
            int elemento = 5;

            go.AprenderHabilidade(elemento);
            
            Assert.IsTrue(go.Level == level && mana == go.Mana && inteligencia == go.Inteligencia && xp == go.XP && forca == go.Forca);
        }
    }
}