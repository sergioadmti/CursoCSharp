using System;


namespace Curso_Gamma._01_Fundamentos {
    class ExemplosAritmeticos {
        public static void Executar() {
            //Console.WriteLine("Nada ainda...");
            //Calculo do IMC
            double peso = 96.1;
            double altura = 1.93;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC: {imc.ToString("F1")}");//.ToString("F1") == Uma (1) casa decimal.
        }
    }
}