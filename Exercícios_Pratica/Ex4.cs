/*
    Dado dois arrays de mesmo tamanho, retorne um novo vetor intercalando os
    elementos

    Exemplo:
    Vetor A: [1, 3, 5]
    Vetor B: [2, 4, 6]
    Saída: [1, 2, 3, 4, 5, 6]
*/

namespace Exercícios_Pratica
{
    public class Ex4
    {
        static Ex4()
        {
            int[] vetorA = { 1, 3, 5 };
            int[] vetorB = { 2, 4, 6 };

            List<int> listUnico = new List<int>();

            for (int i = 0; i < vetorA.Length; i++)
            {
                listUnico.Add(vetorA[i]);
                listUnico.Add(vetorB[i]);
            }

            int[] vetorUnico = listUnico.ToArray();
            Console.WriteLine(string.Join(", ", vetorUnico));
        }
    }
}
