using System;
using System.Collections.Generic;

namespace AlgoritmosOrdenacion
{
    public class AlgoritmosOrd
    {

        //Algoritmo Radix
        public Array Radix(int[] arr)
        {
            int i, j;
            int[] numeros = new int[arr.Length];

            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool arreglar = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !arreglar : arreglar)
                        arr[i - j] = arr[i];
                    else
                        numeros[j++] = arr[i];
                }
                Array.Copy(numeros, 0, arr, arr.Length - j, j);
               
            }
            Console.WriteLine("Ordenado por el método Radix");
            foreach (int aray in arr)
            Console.Write(aray + " ");
            return arr;
        }


        //Algoritmo Counting Sort
        public Array CountigSort(int[] numeros)
        {

            int[] sortedArray = new int[numeros.Length];

            int minVal = numeros[0];
            int maxVal = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < minVal) minVal = numeros[i];
                else if (numeros[i] > maxVal) maxVal = numeros[i];
            }

            int[] counts = new int[maxVal - minVal + 1];

          
            for (int i = 0; i < numeros.Length; i++)
            {
                counts[numeros[i] - minVal]++;
            }


            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[numeros[i] - minVal]--] = numeros[i];
            }

            Console.WriteLine("Ordenado por el método Counting Sort");
            foreach (int aa in sortedArray)
            Console.Write(aa + " ");
            Console.Write("\n");
            return numeros;
        }
    }
}





















//static void Main(string[] args)
//{

//    int[] arrayNumeros = new int[] { 3, 17, 26, 90, 5, 79, -10, -78, 94, -11, 10, 1, 222, 567, 51, 9, 0 };
//    Console.WriteLine("\nArray Inicial: ");
//    foreach (var item in arrayNumeros)
//    {
//        Console.Write(" " + item);
//    }

//    Radix(arrayNumeros);
//    Console.WriteLine("\nArray Final : ");
//    foreach (var item in arrayNumeros)
//    {
//        Console.Write(" " + item);
//    }
//    Console.WriteLine("\n");
//}
