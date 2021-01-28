using Estatistica.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Estatistica.Tests
{
    [TestClass]
    public class CalculoTests
    {
        [TestMethod]
        public void Dado_um_array_encontrar_o_valor_minimo()
        {
            int[] sequencia = { 78, 2, 45, 10, 11, 9, 5 };

            Calculo c = new Calculo();

            var retorno = c.Minimo(sequencia);

            Assert.IsTrue(retorno == 2);
        }

        [TestMethod]
        public void Dado_um_array_encontrar_o_valor_maximo()
        {
            int[] sequencia = { 78, 2, 45, 10, 11, 9, 5 };

            Calculo c = new Calculo();

            var retorno = c.Maximo(sequencia);

            Assert.IsTrue(retorno == 78);
        }

        [TestMethod]
        public void Dado_um_array_encontrar_o_valor_medio()
        {
            int[] sequencia = { 5, 3, 2, 10, 1, 9, 14, 4 };  //48 dividido por 8

            Calculo c = new Calculo();

            float retorno = c.ValorMedio(sequencia);

            Assert.IsTrue(retorno == 6);
        }

        [TestMethod]
        public void Dado_um_array_encontrar_a_quatidade_de_posicoes_na_sequencia()
        {
            int[] sequencia = { 78, 2, 45, 10, 11, 9, 5 };

            Calculo c = new Calculo();

            var retorno = c.ElementosNaSequencia(sequencia);

            Assert.IsTrue(retorno == 7);
        }

        [TestMethod]
        public void Dado_um_array_encontrar_a_soma_de_todo_os_valores_na_sequencia()
        {
            int[] sequencia = { 78, 2, 45, 10, 11, 9, 5 };

            Calculo c = new Calculo();

            var retorno = c.Soma(sequencia);

            Assert.IsTrue(retorno == 160);
        }

        [TestMethod]
        public void Dado_um_array_encontrar_o_ultimo_valor_da_sequencia()
        {
            int[] sequencia = { 78, 2, 45, 10, 11, 9, 5 };

            Calculo c = new Calculo();

            var retorno = c.Ultimo(sequencia);

            Assert.IsTrue(retorno == 5);
        }

        [TestMethod]
        public void Dado_um_array_encontrar_o_primeiro_valor_da_sequencia()
        {
            int[] sequencia = { 78, 2, 45, 10, 11, 9, 5 };

            Calculo c = new Calculo();

            var retorno = c.Primeiro(sequencia);

            Assert.IsTrue(retorno == 78);
        }
    }
}