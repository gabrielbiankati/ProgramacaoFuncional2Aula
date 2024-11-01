using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoFuncional2Aula
{
    // Classe com funções auxiliares
    public class Utilities
    {
        // Func<T, R> = O método Compose retornará uma função que recebe algo do TIPO "T" e retorna algo do TIPO "R"

        // <T, U ,R> = T: Tipo de entrada da função resultante ( e da primeira função da composição)
        // U: Tipo intermediário, que é a saída da primeira função e a entrada de segunda função

        // R: Tipo de saída da função resultante(e da segunda função na composição)
        public static Func<T, R> Compose<T, U, R>(Func<T, U> f, Func<U, R> g)
        {
            // EX: Func<int, double> f = x => x * 2.5;
            // EX: Func<double, string> g = y => $"O resultado é {y}";

            return x => g(f(x));
        }

        // Sobrecarga da função Compose para funções que retornam void (Action)
        public static Action<T> Compose <T, U>(Func<T, U> f, Action<U> g)
        {
            return x => g(f(x));
        }

        // Funções de alta ordem (recebem e/ou retornam metodos)
        // Composição de funções (Combinação de 2)
        // Imutabilidade: Não há alteração de estado
        // Abstração genérica: Usa de parametros e tipo para criar funções independentes (voce nao diz explicitamente o tipo do dado)
        // Expressãõ lambda: Definição concisa de funções anonimas
        // Encapsulamento: Agrupamento da lógica reutilizavel
    }
}
