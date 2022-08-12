using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Gamma._01_Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            /*
             * Programa converte para maiusculo(ToUpper);
             * Depois insere String na posicao {3};
             * Depois substitui (Replace) World por Mundo.
             */
            var saudacao = "olá".ToUpper().Insert(3, ", World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);
            Console.WriteLine(saudacao.Length);

            String valorImportante = null;
            //Console.WriteLine(valorImportante.Length);
            /*
             * Utilizar notacao ponto em um objeto nao instanciado (valor null), pode gerar erro.
             * Contorna-se utilizado uma interrogacao. E chamada "navegacao segura".
             */
            Console.WriteLine(valorImportante?.Length);

        }


    }
}
