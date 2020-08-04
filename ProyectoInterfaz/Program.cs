using System;


namespace ProyectoInterfaz 
{
    class Program 
    {
        static void Main()
        {
            Console.WriteLine("Ingrese 6 numeros enteros:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());
            var num3 = Convert.ToInt32(Console.ReadLine());
            var num4 = Convert.ToInt32(Console.ReadLine());
            var num5 = Convert.ToInt32(Console.ReadLine());
            var num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0},{1},{2},{3},{4},{5}", num1, num2, num3, num4, num5, num6);

            ClaseInterfaz programa = new ClaseInterfaz();

            programa.Arreglo1(num1, num2, num3, num4, num5, num6);
            programa.Arreglo2(num1, num2, num3, num4, num5, num6);





        }
    }
}


