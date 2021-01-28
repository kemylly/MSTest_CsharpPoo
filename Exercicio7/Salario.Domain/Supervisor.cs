using System;

namespace Salario.Domain
{
    public class Supervisor : Funcionario
    {
        public override void Bonificacao()
        {
            this.Salario = this.Salario + 5000;
            Console.WriteLine("Salario: " + (this.Salario));
        }
    }
}