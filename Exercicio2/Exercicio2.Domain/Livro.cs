using System;

namespace Exercicio2.Domain
{
    public class Livro : Produto, Imposto
    {
        //construtores
        public Livro():base()
        {
            this.Autor = "";
            this.Tema = "";
            this.Qpag = 0;
        }

        //sobrecarga
        public Livro(String nome, double preco, int qtd, String autor, String tema, int qpag) : base(nome, preco, qtd)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.Qpag = qpag;
        }

        //propriedades
        private String autor;
        public String Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        
        private String tema;
        public String Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        
        private int qpag;
        public int Qpag
        {
            get { return qpag; }
            set { qpag = value; }
        }

        //metodos
        //metodo comun a todos calculo de imposto
        //1. Se o livro for de tema = “educativo” não se deve cobrar imposto, retornar 0.
        //2. Caso seja de qualquer outro tema, calcular imposto de 10% sobre o preço do livro.
        public double CalculaImposto()
        {
            double imposto = 0;

            if(Tema != "Educativo")
                imposto = this.Preco + (0.1 * this.Preco);

            Console.WriteLine("O preço final do " + (this.Nome) + " com o imposto é de " + imposto + " reais");
            
            return imposto;
        }
    }
}