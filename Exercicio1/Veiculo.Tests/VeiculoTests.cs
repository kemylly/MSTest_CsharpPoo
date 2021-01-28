using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VeiculoDomain;


namespace Veiculo.Tests
{
    [TestClass]
    public class VeiculoTests
    {
        [TestMethod]
        public void Acelerar_1_vez_dentro_da_velocidade_permitida_com_o_veiculo_ligado_e_combustivel()
        {
            //testanto se está acelerando - Teste feliz
            var veiculo = new veiculoDomain.Veiculo();
            int aceleracaoAntiga = veiculo.Velocidade;
            veiculo.litrosCombustivel = 10;
            veiculo.isLigado = true;

            veiculo.Acelerar();

            Assert.IsTrue(veiculo.Velocidade > aceleracaoAntiga);
        }

        [TestMethod]
        public void Acelerar_estando_em_160_de_velocidade_ele_nao_deve_acelerar()
        {
            //tentar acelerar quando o veiculo estiver 160 de velocidade => maximo permitido
            var veiculo = new veiculoDomain.Veiculo();
            veiculo.Velocidade = 160;
            veiculo.isLigado = true;
            veiculo.litrosCombustivel = 10;

            veiculo.Acelerar();

            Assert.IsTrue(veiculo.Velocidade == 160);
        }

        [TestMethod]
        public void Acelerar_com_o_veiculo_desligado_ele_nao_deve_acelerar()
        {
            //testanto se está acelerando, quando veiculo está false => deligado
            var veiculo = new veiculoDomain.Veiculo();
            int aceleracaoAntiga = veiculo.Velocidade;

            veiculo.Acelerar();

            Assert.IsTrue(veiculo.Velocidade == aceleracaoAntiga);
        }

        [TestMethod]
        public void Acelerar_com_o_veiculo_com_a_gasolina_0_ele_nao_deve_acelerar()
        {
            //testanto se está acelerando, quando veiculo está false => deligado
            var veiculo = new veiculoDomain.Veiculo();
            int aceleracaoAntiga = veiculo.Velocidade;
            veiculo.litrosCombustivel = 0;
            veiculo.isLigado = true;

            veiculo.Acelerar();

            Assert.IsTrue(veiculo.Velocidade == aceleracaoAntiga);
        }

        [TestMethod]
        public void Abastecer_o_valor_de_10_litros_com_o_tanque_vazio_e_desligado_ele_deve_aumentar_a_quantidade_de_combustivel()
        {
            //testando um valor valido para abastecer | Teste Feliz
            var veiculo = new veiculoDomain.Veiculo();

            veiculo.Abastecer(10);

            Assert.IsTrue(veiculo.litrosCombustivel == 10);
        }

        [TestMethod]
        public void Abastecer_com_o_veiculo_ligado_ele_nao_deve_aumentar_a_quantidade_de_combustivel()
        {
            //testando um valor valido para abastecer com um veiculo desligado
            var veiculo = new veiculoDomain.Veiculo();
            veiculo.isLigado = true;

            veiculo.Abastecer(10);

            Assert.IsTrue(veiculo.litrosCombustivel == 0);
        }

        [TestMethod]
        public void Abastecer_o_valor_de_70_litros_ele_nao_deve_aumentar_a_quantidade_de_combustivel()
        {
            //testando um valor maior que o permitido no tanque ele não deve deixar abastecer
            var veiculo = new veiculoDomain.Veiculo();
            veiculo.isLigado = false;

            veiculo.Abastecer(70);

            Assert.IsTrue(veiculo.litrosCombustivel == 0);
        }

        [TestMethod]
        public void Abastecer_um_valor_que_somado_com_o_que_já_tem_ultrapsse_o_permitido_ele_nao_deve_aumentar_a_quantidade_de_combustivel()
        {
            //testando um valor valido para abastecer | Teste Feliz
            var veiculo = new veiculoDomain.Veiculo();
            veiculo.litrosCombustivel = 60;
            veiculo.isLigado = false;
            veiculo.Abastecer(10);

            Assert.IsTrue(veiculo.litrosCombustivel == 60);
        }

        [TestMethod]
        public void Frear_com_40_de_velocidade_ele_deve_diminuir()
        {
            //verificando se está freando | Teste feliz
            var veiculo = new veiculoDomain.Veiculo();
            veiculo.Velocidade = 40;
            int velocidadeAntiga = veiculo.Velocidade;

            veiculo.Frear();

            Assert.IsTrue(veiculo.Velocidade < velocidadeAntiga);
        }

        [TestMethod]
        public void Frear_com_20_de_velocidade_ele_deve_ficar_parado()
        {
            //verificando se está freando estando a 20 km ele está parando => 0
            var veiculo = new veiculoDomain.Veiculo();
            veiculo.Velocidade = 20;

            veiculo.Frear();

            Assert.IsTrue(veiculo.Velocidade == 0);
        }

        [TestMethod]
        public void Frear_com_o_veiculo_parado_ele_nao_deve_alterar_a_velocidade()
        {
            //verificando se está freando estando com o viculo já parado
            var veiculo = new veiculoDomain.Veiculo();

            veiculo.Frear();

            Assert.IsTrue(veiculo.Velocidade == 0);
        }

        [TestMethod]
        public void Pintar_o_carro_de_rosa()
        {
            var veiculo = new veiculoDomain.Veiculo();

            veiculo.Pintar("Rosa");

            Assert.IsTrue(veiculo.Cor == "Rosa");
        }

        [TestMethod]
        public void Ligar_um_veiculo_desligado()
        {
            //tentar ligar um veiculo, ele estando false => desligado | Teste feliz
            var veiculo = new veiculoDomain.Veiculo();

            veiculo.Ligar();

            Assert.IsTrue(veiculo.isLigado);
        }

        [TestMethod]
        public void Ligar_um_veiculo_que_ja_esta_ligado()
        {
            //tentar ligar um veiculo ele estando true => ligado
            var veiculo = new veiculoDomain.Veiculo();
            veiculo.isLigado = true;

            veiculo.Ligar();

            Assert.IsTrue(veiculo.isLigado);
        }

        [TestMethod]
        public void Desligar_um_veiculo_que_esta_ligado_e_parado()
        {
            //tentar desligar um veiculo que está true => ligado | Teste feliz
            //e tambem está com a velicidade em 0 => parado

            var veiculo = new veiculoDomain.Veiculo();
            veiculo.isLigado = true;

            veiculo.Desligar();

            Assert.IsTrue(veiculo.isLigado == false);
        }

        [TestMethod]
        public void Desligar_um_veiculo_que_esta_com_velocidade_nao_deve_deixar_desligar()
        {
            //tentar desligar um veiculo que está com umva velocidade diferente de zero

            var veiculo = new veiculoDomain.Veiculo();
            veiculo.isLigado = true;
            veiculo.Velocidade = 20;

            veiculo.Desligar();

            Assert.IsTrue(veiculo.isLigado == true);
        }

        [TestMethod]
        public void Desligar_um_veiculo_que_esta_deligado_nao_deve_mudar_nada()
        {
            //tentar desligar um veiculo que está desligado

            var veiculo = new veiculoDomain.Veiculo();

            veiculo.Desligar();

            Assert.IsTrue(veiculo.isLigado == false);
        }
    }
}
