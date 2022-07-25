using System;
using System.Collections.Generic;

using Curso_Gamma._01_Fundamentos;

namespace Curso_Gamma {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaves e Constantes - Fundamentos", VariaveisEconstantes.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}