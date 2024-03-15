//using System;
//class Punto3
//{
//    static (double,double) CoordndRectangular(double radio,double angulo)
//    {
//        angulo = angulo * Math.PI / 180.0;
//        double x = radio * Math.Cos(angulo);
//        double y = radio * Math.Sin(angulo);
//        return (x,y);
//    }
//    static void Main()
//    {
//        Console.WriteLine("Ingrese el radio de la coordenada polar: ");
//        double radio = double.Parse(Console.ReadLine());
//        Console.WriteLine("Ingrese el angulo de la coordenada polar: ");
//        double angulo = double.Parse(Console.ReadLine());
//        Console.WriteLine($"Coordenadas polares: r:{radio} 0:{angulo}");
//        (double x, double y) = CoordndRectangular((double)radio, (double)angulo);
//        Console.WriteLine($"Coordenadas rectangulares: x:{x}, y:{y}");
//    }
//}
///*3. Desarrollar un programa que implemente una función para convertir coordenadas polares
// * a rectangulares. Debe tener en cuenta lo siguiente:
// * x = rcos(θ); y = rsen(θ) 
// Radio y angulo*/