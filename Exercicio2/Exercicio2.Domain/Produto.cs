using System;

namespace Exercicio2.Domain
{
    public class Produto
    {
        //construtores
        public Produto()
        {
            this.Nome = "";
            this.Preco = 0;
            this.Qtd = 0;
        }

        //sobrecaraga
        public Produto(string nome, double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }

         //propriedades
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        private int qtd;
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
    }
}