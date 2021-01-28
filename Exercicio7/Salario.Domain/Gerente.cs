using System;

namespace Salario.Domain
{
    public class Gerente : Funcionario
    {
        public override void Bonificacao()
        {
            this.Salario = this.Salario + 10000;
            Console.WriteLine("Salario: " + (this.Salario));
        } 
    }
}