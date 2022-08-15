using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Gamma._01_Fundamentos {
    class Conversoes {
        public static void Executar() {

            //Conversão implícita
            int numeroInteiro = 8;
            double numeroQuebrado = numeroInteiro;
            Console.WriteLine("A conversão implícita ficou assim: " + numeroQuebrado.ToString("F2"));

            //Conversão explícita
            double numeroDePontoFlutuante = 9.9;
            int numeroTruncado = (int) numeroDePontoFlutuante;
            Console.WriteLine("O número com uma conversão explícita (casting) ficou assim: " + numeroTruncado);

        }
    }
}