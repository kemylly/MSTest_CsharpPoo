using System;
using System.Collections.Generic;

namespace Listas.Domain
{
    public class Pessoa
    {
       //contrutor
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }

        //sobrecarga
        public Pessoa(String nome, int idade)
         {
             this.Nome = nome;
             this.Idade = idade;
         }

        //propriedades
        private String nome;
        public String Nome
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

        //metodos
        public string Listar(List<Pessoa> lista)
        {
            try{
                for (int i = 0; i < lista.Count; i++)  //listando primeira vez
                {
                    Console.WriteLine(lista[i].Nome + " | " + lista[i].Idade);
                }
                return "okay";
            }catch{
                return "erro";
            }
        }
        public string PessoaMaisVelha(List<Pessoa> lista)
        {
            String aux = "";
            int max = 0;
            for (int a = 0; a < lista.Count; a++)  //achando pessoa mais velha da lista passada
            {
                Pessoa ps = lista[a];

                if (ps.Idade > max)
                {
                    aux = ps.Nome;
                    max = ps.Idade;
                }
            }

            Console.WriteLine("Mais velho: " + aux);

            return aux;
        }

        public List<Pessoa> ExcluirMenorDe18(List<Pessoa> lista)
        {
            
            for (int e = 0; e < lista.Count; e++) //excluindo menores de 18
            {
                Pessoa ps = lista[e];

                if (ps.Idade < 18)
                {
                    lista.Remove(ps);
                }
            }

            Console.WriteLine("Maiores de idade: ");

            for (int i = 0; i < lista.Count; i++) //apresentar depois da exclusao
            {
                Console.WriteLine(lista[i].Nome + " | " + lista[i].Idade);
            }

            return lista;
        }

        public bool JessicaExiste(List<Pessoa> lista)
        {
            bool existe = false;
            int idade = 0;
            foreach (var item in lista)
            {
                if(item.Nome == "Jessica")
                {
                    //verificando de jessica existe
                    idade = item.Idade;
                    existe = true;
                }  
            }
            
            if (existe == true)
            { 
                Console.WriteLine("Existe");
                Console.WriteLine("Idade: " + idade); //mostrando a idade se ela existir
                return true;
            }
            else
            {
                Console.WriteLine("Não existe");
                return false;
            }
             
        }
    }
}