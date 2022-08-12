using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Gamma._01_Fundamentos {
    class Interpolacao {
        public static void Executar () {
            String tipoDoProduto = "Notebook";
            String fabricante = "Apple";
            String modelo = "MacBook Pro de 13 pol";
            double valorDoProduto = 13299.00;

            //O recurso de interpolação serve para substituir a concatenação.
            Console.WriteLine("O {0} {1}, modelo {2}, está saindo a R$ {3}.", tipoDoProduto, fabricante, modelo, valorDoProduto);
            Console.WriteLine($"O {tipoDoProduto} {fabricante}, modelo {modelo}, está saindo a R$ {valorDoProduto}."  );

        }
    }
}
