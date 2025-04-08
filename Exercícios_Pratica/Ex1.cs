//Dado um array de números, coloque o array em ordem crescente.

namespace Exercícios_Pratica
{
    public class Ex1
    {
        static Ex1()
        {
            int[] array = { 8, 4, 6, 23, 72, 1, 7, 10, 15 };
            
            List<int> lista = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                int menor = int.MaxValue;
                foreach (int num in array)
                {
                    if (num < menor && !lista.Contains(num))
                    {
                        menor = num;
                    }
                }
                lista.Add(menor);
            }

            int[] arrayOrdenada = lista.ToArray();
            Console.WriteLine($"Array em ordem crescente: \n{string.Join(", ", arrayOrdenada)}");
        }
    }
}
