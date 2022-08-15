using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Gamma._01_Fundamentos {
    class ConversaoSegura {

        public static void Executar() {
            /*
            Console.WriteLine("Digite um número: ");
            string recebendoComoTexto = Console.ReadLine();
            int.TryParse(recebendoComoTexto, out int numeroInteiroQualquer);
            Console.WriteLine(numeroInteiroQualquer);
            */

            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int numeroInteiroQualquer);
            Console.WriteLine($"O número digitado foi: {numeroInteiroQualquer}");

        }

    }
}
