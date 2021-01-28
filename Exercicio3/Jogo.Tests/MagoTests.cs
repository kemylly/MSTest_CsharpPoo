using Jogo.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jogo.Tests
{
    [TestClass]
    public class MagoTests
    {
        [TestMethod]
        public void Dado_uma_batalha_com_um_mago_deve_calcular_o_ataque_com_ineteligencia_level_e_um_randomico()
        {
            var mago = new Mago();
            mago.Nome = "Yona";
            mago.Vida = 100;
            mago.Mana = 80;
            mago.XP = 250;
            mago.Inteligencia = 110;
            mago.Forca = 300;
            mago.Level = 1;
            mago.Magia = null;

            int ataque = mago.attack(mago.Inteligencia, mago.Level);

            //não dá para medir exatamente o quanto é um ataque, porque é somado com um numero aleatorio
            //mas sabe-se que é um numero maior ou igual a inteligencia multiplicada pelo level
            Assert.IsTrue(ataque >= 110);
        }

        [TestMethod] //LvUp
        public void Subir_de_nivel_quando_vencer_uma_batalha_seus_atributos_devem_aumentar()
        {
            var mago = new Mago();
            mago.Nome = "Yona";
            mago.Vida = 100;
            mago.Mana = 80; //aumenta
            mago.XP = 250;
            mago.Inteligencia = 110; //aumenta
            mago.Forca = 300;
            mago.Level = 1;  //aumenta
            mago.Magia = null;

            int Mana = mago.Mana;
            int Inteligencia = mago.Inteligencia;
            int Level = mago.Level;

            mago.LvUp();

            Assert.IsTrue(Level < mago.Level && Mana < mago.Mana && Inteligencia < mago.Inteligencia);
        }

        [TestMethod]
        public void Aprender_Habilidade_de_agua_seus_atributos_devem_aumentar()
        {
            var mago = new Mago();
            mago.Nome = "Yona";
            mago.Vida = 100;
            mago.Mana = 80; //aumenta
            mago.XP = 250; //aumenta
            mago.Inteligencia = 110; //aumenta
            mago.Forca = 300; //aumenta
            mago.Level = 1;  //aumenta

            float xp = mago.XP;
            int level = mago.Level;
            int inteligencia = mago.Inteligencia;
            int mana = mago.Mana;
            int forca = mago.Forca;
            int elemento = 1;

            mago.AprenderMagia(elemento);

            Assert.IsTrue(level < mago.Level && mana < mago.Mana && inteligencia < mago.Inteligencia && xp < mago.XP && forca < mago.Forca);
        }

        [TestMethod]
        public void Aprender_Habilidade_de_fogo_seus_atributos_devem_aumentar()
        {
             var mago = new Mago();
            mago.Nome = "Yona";
            mago.Vida = 100;
            mago.Mana = 80; //aumenta
            mago.XP = 250;  //aumenta
            mago.Inteligencia = 110; //aumenta
            mago.Forca = 300; //aumenta
            mago.Level = 1;  //aumenta

            float xp = mago.XP;
            int level = mago.Level;
            int inteligencia = mago.Inteligencia;
            int mana = mago.Mana;
            int forca = mago.Forca;
            int elemento = 2;

            mago.AprenderMagia(elemento);

            Assert.IsTrue(level < mago.Level && mana < mago.Mana && inteligencia < mago.Inteligencia && xp < mago.XP && forca < mago.Forca);
        }

        [TestMethod]
        public void Aprender_Habilidade_de_vento_seus_atributos_devem_aumentar()
        {
            var mago = new Mago();
            mago.Nome = "Yona";
            mago.Vida = 100;
            mago.Mana = 80; //aumenta
            mago.XP = 250; //aumenta
            mago.Inteligencia = 110; //aumenta
            mago.Forca = 300; //aumenta
            mago.Level = 1;  //aumenta

            float xp = mago.XP;
            int level = mago.Level;
            int inteligencia = mago.Inteligencia;
            int mana = mago.Mana;
            int forca = mago.Forca;
            int elemento = 3;

            mago.AprenderMagia(elemento);

            Assert.IsTrue(level < mago.Level && mana < mago.Mana && inteligencia < mago.Inteligencia && xp < mago.XP && forca < mago.Forca);
        }

        [TestMethod]
        public void Aprender_Habilidade_de_terra_seus_atributos_devem_aumentar()
        {
             var mago = new Mago();
            mago.Nome = "Yona";
            mago.Vida = 100;
            mago.Mana = 80; //aumenta
            mago.XP = 250; //aumenta
            mago.Inteligencia = 110; //aumenta
            mago.Forca = 300; //aumenta
            mago.Level = 1;  //aumenta

            float xp = mago.XP;
            int level = mago.Level;
            int inteligencia = mago.Inteligencia;
            int mana = mago.Mana;
            int forca = mago.Forca;
            int elemento = 4;

            mago.AprenderMagia(elemento);

            Assert.IsTrue(level < mago.Level && mana < mago.Mana && inteligencia < mago.Inteligencia && xp < mago.XP && forca < mago.Forca);
        }

        [TestMethod]
        public void Passar_um_valor_invalido_em_Aprender_Magia_seus_atributos_devem_pemanecer_igual()
        {
            var mago = new Mago();
            mago.Nome = "Yona";
            mago.Vida = 100;
            mago.Mana = 80; //aumenta
            mago.XP = 250; //aumenta
            mago.Inteligencia = 110; //aumenta
            mago.Forca = 300; //aumenta
            mago.Level = 1;  //aumenta

            float xp = mago.XP;
            int level = mago.Level;
            int inteligencia = mago.Inteligencia;
            int mana = mago.Mana;
            int forca = mago.Forca;
            int elemento = 5;

            mago.AprenderMagia(elemento);

            Assert.IsTrue(level == mago.Level && mana == mago.Mana && inteligencia == mago.Inteligencia && xp == mago.XP && forca == mago.Forca);
        }
    }
}