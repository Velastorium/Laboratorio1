//using System;

//class Punto5
//{
//    static int Fibonacci(int num)
//    {
//        if (num <= 1)
//        {
//            return num;
//        }
//        else
//        {
//            return Fibonacci(num - 1) + Fibonacci(num - 2);
//        }
//    }
//    static void Main()
//    {
//        Console.WriteLine("Ingrese el numero limite de la serie de fibonacci: ");
//        int limite = int.Parse(Console.ReadLine());

//        Console.WriteLine("Serie de Fibonacci hasta el límite {0}:", limite);
//        int i = 0;
//        while (Fibonacci(i) <= limite)
//        {
//            Console.WriteLine(Fibonacci(i));
//            i++;
//        }
//    }
//}
///*Aplicando recursividad: investigar en qué consiste la serie Fibonacci y desarrollar una
//aplicación para determinar el resultado de la misma. El usuario debe ingresar desde teclado
//el límite de la serie. */