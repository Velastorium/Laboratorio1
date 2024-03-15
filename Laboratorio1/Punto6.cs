using System;

class Program
{
        static void CalcularSerie()
        {
            Console.WriteLine("Ingrese el valor de 'n' para calcular la serie:");
            int n = Convert.ToInt32(Console.ReadLine());
            double resultado = 0.0;
            for (int i = 1; i <= n; i++)
            {
                double termino = i / Math.Pow(2, i);
                if (i % 2 == 0)
                {
                    resultado -= termino;
                }
                else
                {
                    resultado += termino;
                }
            }
            Console.WriteLine($"El resultado de la serie para n = {n} es: " + resultado);
        }
    static void Main()
    {
        CalcularSerie();
    }
}
/*Desarrolle un programa en C# haciendo uso de un procedimiento para determinar el resultado 
 * de la siguiente serie:  1/2 - 2/2 potencia de 2 + 3/2 potencia de 3 - ... + n/2 potencia de n. */