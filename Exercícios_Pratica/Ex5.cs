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
        static Ex5()
        {
            int[] vetorA = { 1, 2, 2, 1 };
            int[] vetorB = { 2, 2 };

            List<int> list = new List<int>();

            foreach (int i in vetorA)
            {
                if (vetorB.Contains(i))
                {
                    list.Add(i);
                }
            }

            int[] vetorIntercalado = list.ToArray();
            Console.WriteLine(string.Join(", ", vetorIntercalado));
        }
    }
}
