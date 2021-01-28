using System;

namespace Salario.Domain
{
    public class Vendedor : Funcionario
    {
        public override void Bonificacao()
        {
            this.Salario = this.Salario + 3000;
            Console.WriteLine("Salario: " + (this.Salario));
        }
    }
}