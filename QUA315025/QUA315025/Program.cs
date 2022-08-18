using System;
using System.Collections.Generic;

using QUA315025;

namespace QUA315025 {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Ler Entrada de Dados - C# Senai", LerDadosDeEntrada.Executar},
                {"Ler Entrada de Dados Endereço - C# Senai", LerDadosDeEntradaEndereco.Executar},
                {"Função Math - C# Senai", ComparaDoisNumeros.Executar},
                         
            });

            central.SelecionarEExecutar();
        }
    }
}