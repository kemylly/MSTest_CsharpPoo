using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicio2.Domain;

namespace Exercicio2.Tests
{
    [TestClass]
    public class VideoGameTests
    {
        [TestMethod]
        public void Calcula_imposto_de_25_porcento_no_preco_em_um_video_game_usado()
        {
           var video = new VideoGame();
           video.Nome = "Playstation 4";
           video.Modelo = "Slim";
           video.Marca = "Sony";
           video.isUsado = true; //usado
           video.Preco = 800;
           video.Qtd = 2;

           var imposto = video.CalculaImposto();

           Assert.IsTrue(imposto == 1000);
        }

        [TestMethod]
        public void Calcula_imposto_de_45_porcento_no_preco_em_um_video_game_novo()
        {
           var video = new VideoGame();
           video.Nome = "Playstation 4";
           video.Modelo = "Slim";
           video.Marca = "Sony";
           video.isUsado = false; //nao usado
           video.Preco = 800;
           video.Qtd = 2;

           var imposto = video.CalculaImposto();

           Assert.IsTrue(imposto == 1160);
        }
    }
}