using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUA315025 {
    class LerDadosDeEntradaEndereco {
        public static void Executar() {

            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Digite o endereço: ");
            string endereco = Console.ReadLine();
            
            Console.WriteLine("Digite o CPF (Apenas números): ");
            ulong cpf = ulong.Parse(Console.ReadLine());
            
            Console.WriteLine($"{nome}, CPF: {cpf}, é morador do(a) {endereco}");
        }
    }
}