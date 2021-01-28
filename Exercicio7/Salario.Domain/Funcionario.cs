using System;

namespace Salario.Domain
{
    public class Funcionario
    {
        //construtor
        public Funcionario()
        {
            this.Nome = "";
            this.Idade = 0;
            this.Salario = 0;
        }

        public Funcionario(string nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }

        //atributos
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private double salario;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public virtual void Bonificacao()
        {
            //metodo principal
            //return Salario;
        }
    }
}