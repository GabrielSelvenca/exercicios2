/*
    Dado um array de caracteres, verifique se ele forma um palíndromo (lê-se da mesma
    forma de frente para trás e de trás para frente.

    Exemplo:
    Array: ['r', 'a', 'd', 'a', 'r']
    Saída: É um palíndromo.
*/

namespace Exercícios_Pratica
{
    public class Ex3
    {
        static Ex3()
        {
            char[] arrayPalindroma = { 'r', 'a', 'd', 'a', 'r' };
            char[] arrayErrada = { 'a', 'd', 'a', 'b', 'a' };

            for (int i = 0; i < arrayErrada.Length; i++)
            {
                if (arrayErrada[i] != arrayErrada[(arrayErrada.Length - 1) - i])
                {
                    Console.WriteLine("Não é um palíndromo.");
                    return;
                }
            }
            Console.WriteLine("É um palíndromo.");
        }
    }
}
