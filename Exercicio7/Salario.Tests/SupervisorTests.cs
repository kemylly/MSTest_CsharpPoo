using Microsoft.VisualStudio.TestTools.UnitTesting;
using Salario.Domain;

namespace Salario.Tests
{
    [TestClass]
    public class SupervisorTests
    {
        [TestMethod]
        public void Surpervisor()
        {
            Funcionario s = new Supervisor();

            s.Nome = "Melissa";
            s.Idade = 28;
            s.Salario = 800;

            s.Bonificacao();  //deve adicionar 5000

            Assert.IsTrue(s.Salario == 5800);
        }
    }
}