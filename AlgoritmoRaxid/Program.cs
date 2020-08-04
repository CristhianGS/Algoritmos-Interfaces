using System;

namespace AlgoritmoRaxid
{
    class Program
    {

        static void Sort(int[] arr)
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
        }
        static void Main(string[] args)
        {

            int[] arrayNumeros = new int[] { 3, 17, 26, 90, 5, 79, -10, -78,94, -11, 10, 1, 222, 567, 51, 9,0 };
            Console.WriteLine("\nArray Inicial: ");
            foreach (var item in arrayNumeros)
            {
                Console.Write(" " + item);
            }

            Sort(arrayNumeros);
            Console.WriteLine("\nArray Final : ");
            foreach (var item in arrayNumeros)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");
        }
    }
}
