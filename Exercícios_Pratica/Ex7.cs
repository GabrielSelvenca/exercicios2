/*
    Dado um array ordenado, encontre a mediana dos elementos
    Exemplo:
    Vetor: [1, 2, 3, 4, 5, 6]
    Saída: 3.5
*/

using System.Globalization;

namespace Exercícios_Pratica
{
    public class Ex7
    {
        static Ex7()
        {
            int[] array = { 1, 2, 3, 4, 5};

            int meio = array.Length / 2;
            double mediana;

            if (meio %  2 == 0)
            {
                mediana = (array[meio -1] + array[meio]) / 2.0;
            }
            else
            {
                mediana = array[meio];
            }

            Console.WriteLine($"Mediana: {mediana.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}
