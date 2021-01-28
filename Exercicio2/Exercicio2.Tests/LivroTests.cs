using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicio2.Domain;

namespace Exercicio2.Tests
{
    [TestClass]
    public class LivroTests
    {

        [TestMethod]
        public void Dado_um_livro_educativo_o_preco_nao_deve_aumentar_e_o_calculo_do_imposto_deve_retornar_0()
        {
            var livro = new Livro();
            livro.Nome = "A terra";
            livro.Preco = 10;
            livro.Qpag = 200;
            livro.Qtd = 20;
            livro.Tema= "Educativo";
            livro.Autor = "Nova escola";

            var imposto = livro.CalculaImposto();

            Assert.IsTrue(imposto == 0);
        }

        [TestMethod]
        public void Dado_um_livro_de_um_tema_qualquer_deve_aumentar_10_procento_no_preco_como_imposto()
        {
            var livro = new Livro();
            livro.Nome = "Depois de voce";
            livro.Preco = 20;
            livro.Qpag = 300;
            livro.Qtd = 10;
            livro.Tema= "Romance";
            livro.Autor = "Intriseca";

            var imposto = livro.CalculaImposto();

            Assert.IsTrue(imposto == 22);
        }
    }
}