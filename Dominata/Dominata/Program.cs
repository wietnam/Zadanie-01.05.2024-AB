using System;
using System.Collections.Generic;

namespace DominantaListy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar listy:");
            int n = int.Parse(Console.ReadLine());

            List<int> lista = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                lista.Add(rand.Next(-99, 100));
            }

            Console.WriteLine("Lista:");
            foreach (var num in lista)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int dominanta = lista[0];
            int maxCount = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                int currentCount = 0;
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[j] == lista[i])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    dominanta = lista[i];
                }
            }

            Console.WriteLine($"Najczęściej występująca wartość (dominanta): {dominanta}");
            Console.WriteLine($"Liczba wystąpień dominanty: {maxCount}");
        }
    }
}
