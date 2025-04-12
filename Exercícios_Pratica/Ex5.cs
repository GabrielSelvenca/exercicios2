/*
    Dado dois arrays, retorne a intercalação entre eles (os elementos em comum entre
    os dois arrays, em qualquer ordem):

    Exemplo:
    Vetor A: [1, 2, 2, 1]
    Vetor B: [2, 2]
    Saída: [2, 2]
*/

namespace Exercícios_Pratica
{
    public class Ex5
    {
        static void Ex5()
        {
            int[] vetorA = { 1, 2, 2, 1 };
            int[] vetorB = { 2, 2 };
        
            int[] resultado = new int[Math.Min(vetorA.Length, vetorB.Length)]; // Pegando valor mínimo entre A e B
            int count = 0;
        
            bool[] usados = new bool[vetorB.Length];
        
            for (int i = 0; i < vetorA.Length; i++)
            {
                for (int j = 0; j < vetorB.Length; j++)
                {
                    if (vetorA[i] == vetorB[j] && usados[j] == false)
                    {
                        resultado[count] = vetorA[i];
                        count++;
                        usados[j] = true;
                        break;
                    }
                }
            }
        
            if (count == 0)
            {
                Console.WriteLine("Nenhum número em comum.");
            }
            else
            {
                for (int i = 0; i < usados; i++)
                {
                    Console.Write(resultado[i]);
                    if (i < count - 1)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
        }
    }
}
