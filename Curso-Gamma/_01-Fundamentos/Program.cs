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
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Conversão Segura - Fundamentos", ConversaoSegura.Executar},
                {"Exemplos Aritmeticos - Fundamentos", ExemplosAritmeticos.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}