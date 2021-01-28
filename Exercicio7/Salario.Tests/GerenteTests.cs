using Microsoft.VisualStudio.TestTools.UnitTesting;
using Salario.Domain;

namespace Salario.Tests
{
    [TestClass]
    public class GerenteTests
    {
        [TestMethod]
        public void Bonificacao_do_gerente()
        {
            Funcionario g = new Gerente();
            g.Nome = "Kemylly";
            g.Idade = 27;
            g.Salario = 1000;

            g.Bonificacao(); //deve adicionar 10000

            Assert.IsTrue(g.Salario == 11000);
        }
    }
}