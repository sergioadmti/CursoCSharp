using System;
using System.Collections;
using System.Text;

namespace Curso_Gamma._01_Fundamentos {
    class VariaveisEconstantes {
        public static void Executar() {
            //Area de um circunferencia
            double raio = 2.0;
            const double PI = 3.14;
            double areaCircunferencia = (PI * raio * raio); //Existe funcao para elevar ao quadrado, mas sera abordado posteriormente.

            Console.WriteLine("A area desta superficie e igual a: " + areaCircunferencia);

            //Tipos internos de variaveis:

            bool eMaiorDeIdade = true;
            byte idade = 18;
            int saldoEmConta = -487;
            uint umaDuzia = 12;
            sbyte saldoDeGosls = -9;
            short salario = short.MaxValue;
            Console.WriteLine("O valor maxio da variavel short e: " + salario);
            long populacaoMundial = 7000000000;
            Console.WriteLine(populacaoMundial);
            float precoDoLitroDaGasolina = 5.89F;

            decimal umNumeroRealmenteGrande = decimal.MaxValue;
            Console.WriteLine("Valor do tipo decimal: " + umNumeroRealmenteGrande);





        }

    }

}