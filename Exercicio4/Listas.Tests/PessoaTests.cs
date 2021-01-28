using System.Collections.Generic;
using Listas.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Listas.Tests
{
    [TestClass]
    public class PessoaTests
    {
        [TestMethod]
        public void Listar_passando_uma_lista_valida_deve_resultar_em_okay()
        {
            Pessoa p = new Pessoa("Joao", 15);
            Pessoa p1 = new Pessoa("Leandro", 21);
            Pessoa p2 = new Pessoa("Paulo", 17);
            Pessoa p3 = new Pessoa("Jessica", 18);

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(p);
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);

            var result = p.Listar(lista);

            Assert.IsTrue(result == "okay");
        }

        [TestMethod]
        public void Tentar_listar_passando_uma_lista_vazia_deve_resultar_erro()
        {
            Pessoa p = new Pessoa();

            var result = p.Listar(null);

            Assert.IsTrue(result == "erro");
        }

        [TestMethod]
        public void Encontrar_a_pessoa_mais_velha_deve_retornar_o_mais_velho()
        {
            Pessoa p = new Pessoa("Joao", 15);
            Pessoa p1 = new Pessoa("Leandro", 21);
            Pessoa p2 = new Pessoa("Paulo", 17);
            Pessoa p3 = new Pessoa("Jessica", 18);

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(p);
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);

            var result = p.PessoaMaisVelha(lista);

            Assert.IsTrue(result == "Leandro");
        }

        [TestMethod]
        public void Tentar_excluir_menores_de_idade_deve_retornar_apenas_dois_elemetos_na_lista()
        {
            Pessoa p = new Pessoa("Joao", 15);
            Pessoa p1 = new Pessoa("Leandro", 21);
            Pessoa p2 = new Pessoa("Paulo", 17);
            Pessoa p3 = new Pessoa("Jessica", 18);

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(p);
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);

            var result = p.ExcluirMenorDe18(lista);

            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void Verificar_se_existe_uma_jessica_na_lista_com_existe_deve_retornar_true()
        {
            Pessoa p = new Pessoa("Joao", 15);
            Pessoa p1 = new Pessoa("Leandro", 21);
            Pessoa p2 = new Pessoa("Paulo", 17);
            Pessoa p3 = new Pessoa("Jessica", 18);

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(p);
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);

            var result = p.JessicaExiste(lista);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Verificar_se_existe_uma_jessica_na_lista_como_nao_existe_deve_retornar_false()
        {
            Pessoa p = new Pessoa("Joao", 15);
            Pessoa p1 = new Pessoa("Leandro", 21);
            Pessoa p2 = new Pessoa("Paulo", 17);

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(p);
            lista.Add(p1);
            lista.Add(p2);

            var result = p.JessicaExiste(lista);

            Assert.IsTrue(result == false);
        }
    }
}
