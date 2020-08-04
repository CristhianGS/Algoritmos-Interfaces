using System;
using System.Collections.Generic;
using System.Text;
using AlgoritmosOrdenacion;



namespace ProyectoInterfaz
{
    class ClaseInterfaz : Interfaz1
    {

        AlgoritmosOrd algoritmos = new AlgoritmosOrd();
        public Array Arreglo1(int num1, int num2, int num3, int num4, int num5, int num6)
        {
            int[] number = new int[7];
            number[0] = num1;
            number[1] = num2;
            number[2] = num3;
            number[3] = num4;
            number[4] = num5;
            number[5] = num6;

            return algoritmos.CountigSort(number);
        }

        public Array Arreglo2(int num1, int num2, int num3, int num4, int num5, int num6)
        {
            int[] number = new int[7];
            number[0] = num1;
            number[1] = num2;
            number[2] = num3;
            number[3] = num4;
            number[4] = num5;
            number[5] = num6;

            return algoritmos.Radix(number);
        }
    }
}
