using System;

namespace AlgoritmoCountingSort
{
    class Program
    {
        public static void Main()
        {
            int[] numeros = new int[10]
            {
             2, 5, -4, 11, 0, 8, 22, 67, 51, 6
            };

            Console.WriteLine("\n" + "Array Inicial :");
            foreach (int aa in numeros)
                Console.Write(aa + " ");

            int[] sortedArray = new int[numeros.Length];

            // find smallest and largest value
            int minVal = numeros[0];
            int maxVal = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < minVal) minVal = numeros[i];
                else if (numeros[i] > maxVal) maxVal = numeros[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < numeros.Length; i++)
            {
                counts[numeros[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[numeros[i] - minVal]--] = numeros[i];
            }

            Console.WriteLine("\n" + "Array Final :");
            foreach (int aa in sortedArray)
                Console.Write(aa + " ");
            Console.Write("\n");

        }
    }
}
