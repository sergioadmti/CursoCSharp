using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Gamma._01_Fundamentos {
    class Comentarios {
        public static void Executar() {
            Console.WriteLine("Manter sempre o codigo limpo, evitando comentarios desnecessarios");

            Console.WriteLine("Comentario de linha unica");
            //Texto de comentario, nao aparecera.

            Console.WriteLine("Comentario de multiplas linhas:");
            /*
              * Comentario
              * de multiplas linhas.
             */

            ///
            Console.WriteLine("Comentario do tipo XML Comments:");
            /// <summary>
            /// 
            /// </summary>
            /// 

            Console.WriteLine("Comentario tambem e utilizado para suprimir execucao de parte do codigo:");
            //Console.WriteLine("Não executar esta parte código.");
            //Console.WriteLine("Nem executar esta outra parte.");
        }
    }
}
