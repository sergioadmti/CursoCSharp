using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Gamma._01_Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {

            double valor = 10984.868;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("F2"));
            Console.WriteLine(valor.ToString("C"));

            int numeroACompletar = 187;
            Console.WriteLine(numeroACompletar.ToString("D11"));

        }
    }
}
