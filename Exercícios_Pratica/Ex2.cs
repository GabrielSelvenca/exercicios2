/*
    Dado um array de caracteres, inverta os caracteres.

    Exemplo:
    Array: ['d', 'i', 'a']
    Saída: ['a', 'i', 'd']
*/

namespace Exercícios_Pratica
{
    public class Ex2
    {
        static Ex2()
        {
            int[] array = { 1, 2, 3, 4 };
            List<int> list = new List<int>();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                list.Add(array[i]);
            }

            Console.WriteLine(string.Join(", ", list.ToArray()));
        }
    }
}
