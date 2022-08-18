using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUA315025 {
    class LerDadosDeEntrada {
        public static void Executar() {

            Console.WriteLine("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());
            
            int soma = (primeiroNumero + segundoNumero);
            
            Console.WriteLine("A some dos números digitados é: " + soma);
        }
    }
}