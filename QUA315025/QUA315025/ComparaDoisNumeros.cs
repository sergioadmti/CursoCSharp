using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUA315025 {
    class ComparaDoisNumeros {
        public static void Executar(){
            Console.WriteLine("Digite um número inteiro qualquer: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número inteiro qualquer: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(primeiroNumero, segundoNumero) + " é o maior entre os dois números.");

        }
    }
}