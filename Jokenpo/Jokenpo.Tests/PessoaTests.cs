using Jokenpo.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jokenpo.Tests
{
    [TestClass]
    public class PessoaTests
    {
        //jogadas com pedra => eu == jogador => selecionando pedra
        [TestMethod]
        public void Jogar_pedra_e_o_oponenete_jogar_aleatorio_deve_dar_empate_pedra_ou_papel()
        {
            var pessoa = new Pessoa();
            pessoa.Nome = "Yona";
            pessoa.Jogada = "Pedra";

            var resultado = pessoa.Jogar(pessoa.Nome, pessoa.Jogada);

            Assert.IsTrue(resultado == "empate" || resultado == "pedra" || resultado == "papel"); //pedra x pedra
        } 

        //jogadas com papel => eu == jogador => selecionando ppapel
        [TestMethod]
        public void Jogar_papel_e_o_oponenete_jogar_aleatorio_deve_dar_empate_papel_ou_tesoura()
        {
            var pessoa = new Pessoa();
            pessoa.Nome = "Yona";
            pessoa.Jogada = "Papel";

            var resultado = pessoa.Jogar(pessoa.Nome, pessoa.Jogada);

            Assert.IsTrue(resultado == "empate" || resultado == "papel" || resultado == "tesoura");
        }

        //jogadas com tesoura => eu == jogador => selecionando tesoura
        [TestMethod]
        public void Jogar_tesoura_e_o_oponenete_jogar_aleatorio_deve_dar_empate_tesoura_ou_pedra()
        {
            var pessoa = new Pessoa();
            pessoa.Nome = "Yona";
            pessoa.Jogada = "Tesoura";

            var resultado = pessoa.Jogar(pessoa.Nome, pessoa.Jogada);

            Assert.IsTrue(resultado == "empate" || resultado == "tesoura" || resultado == "pedra");
        }

        [TestMethod]
        public void Jogar_vazio_e_o_oponenete_jogar_aleatorio_deve_dar_erro()
        {
            var pessoa = new Pessoa();
            pessoa.Nome = "Yona";
            pessoa.Jogada = "";

            var resultado = pessoa.Jogar(pessoa.Nome, pessoa.Jogada);

            Assert.IsTrue(resultado == "erro");
        }
    }
}
