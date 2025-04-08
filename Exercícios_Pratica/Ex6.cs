/*
    Dado um array de números e um valor, retorne dois números do vetor cuja soma
    seja igual ao número, ou 0 caso não exista.

    Exemplo:
    Vetor: [3, 2, 4]
    Número: [6]
    Saída: [2, 4]
*/

namespace Exercícios_Pratica
{
    public class Ex6
    {
        static Ex6()
        {
            int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int numero = 5;

            for (int i = 0; i < vetor.Length; i++)
            {
                int n1 = vetor[i];
                if (n1 + vetor[i + 1] == numero)
                {
                    Console.WriteLine(n1 + ", " + vetor[i + 1]);
                    return;
                }
            }
            Console.WriteLine("0");
        }
    }
}
