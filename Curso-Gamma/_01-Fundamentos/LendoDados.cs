using System;
using System.Globalization;

namespace Curso_Gamma._01_Fundamentos {
    class LendoDados {
        
        public static void Executar() {
            Console.WriteLine("Digite o nome de usuário: ");
            string nomeDeUsuario = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
               
            Console.WriteLine("");
            Console.WriteLine("O nome do usuário é: " + nomeDeUsuario);
            Console.WriteLine("A idade é: " + idade);
            Console.WriteLine("O salário é de R$ " + salario);
        }
    }
}