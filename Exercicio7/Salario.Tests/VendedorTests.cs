using Microsoft.VisualStudio.TestTools.UnitTesting;
using Salario.Domain;

namespace Salario.Tests
{
    [TestClass]
    public class VendedorTests
    {
        [TestMethod]
        public void Dado_salario_de_um_vendedor_adicionar_sua_bonificacao()
        {
            Funcionario v = new Vendedor();

            v.Nome = "Beatrix";
            v.Idade = 20;
            v.Salario = 500;

            v.Bonificacao(); //deve adicionar 3000

            Assert.IsTrue(v.Salario == 3500);
        }
    }
}