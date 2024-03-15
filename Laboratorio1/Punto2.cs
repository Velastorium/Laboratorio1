//using System;
//class Punto2
//{
//    static double Dividir(int num1, int num2)
//    {
//        return num1 / num2 ;
//    }
//    static double Cubo(double lado)
//    {
//        return lado * 3;
//    }
//    static double IMC(double altura, int peso)
//    {
//        return peso / (altura * altura);
//    }
//    static void Main()
//    {
//        bool menu = true;
//        while(menu == true)
//        {
//            Console.WriteLine("----------Menú----------\n * a) Dividir.\r\n * b) Obtener cubo.\r\n * c) Cálculo de IMC (Índice de Masa Corporal).\r\n * d) Salir");
//            String opction = Console.ReadLine();
//            switch (opction)
//            {
//                case "a":
//                    Console.WriteLine("----------Dividir----------");
//                    Console.WriteLine("Ingrese un numero");
//                    int num1 = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Ingrese otro numero");
//                    int num2 = int.Parse(Console.ReadLine());
//                    Console.WriteLine($"El resultado de la division es: {Dividir(num1,num2)}");
//                    Console.ReadKey();
//                    break;
//                case "b":
//                    Console.WriteLine("----------Obtener Cubo----------");
//                    Console.WriteLine("Ingrese el lado del cubo: ");
//                    double lado = double.Parse(Console.ReadLine());;
//                    Console.WriteLine($"El volumen del cubo es: {Cubo(lado)}");
//                    break;
//                case "c":
//                    Console.WriteLine("----------Cálculo de IMC----------");
//                    Console.WriteLine("Ingrese su peso en Kg: ");
//                    int peso = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Ingrese su altura en M(Recuerde poner el punto): ");
//                    double altura = int.Parse(Console.ReadLine());
//                    Console.WriteLine($"Su Índice de Masa Corporal (IMC) es de: {IMC(altura,peso)}");
//                    break;
//                case "d":
//                    menu = false;
//                    break;
//                default: 
//                    Console.WriteLine("Esta opcion no existe");
//                    break;
//            } 
//        }
//    }
//}
///*2. Cree un programa que contenga el siguiente menú:
// * a) Dividir.
// * b) Obtener cubo.
// * c) Cálculo de IMC (Índice de Masa Corporal).
// * d) Salir
// Consideraciones:
// El menú debe permanecer disponible hasta que el usuario elija la opción d.
// Utilizar una función o procedimiento para cada opción.
// Para la opción d, utilice la fórmula: IMC = Peso[Kg] / Altura2[Metros]. */