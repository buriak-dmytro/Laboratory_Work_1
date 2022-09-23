using System;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius: ");
            double circleRadius = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter sphere radius: ");
            double sphereRadius = double.Parse(Console.ReadLine());

            TCircle circle = new TCircle(circleRadius);
            TSphere sphere = new TSphere(sphereRadius);

            Console.WriteLine();

            Console.WriteLine("Circle info:");
            Console.WriteLine(circle.ToString());

            Console.WriteLine($"Circle length: {circle.CalculateCircleLength()}");
            Console.WriteLine($"Circle area: {circle.CalculateCircleArea()}");
            Console.Write("----- enter sector angle in radians: ");
            double sectorAngle = double.Parse(Console.ReadLine());
            Console.WriteLine($"Circle sector area: {circle.CalculateCircleSectorArea(sectorAngle)}");

            Console.WriteLine();

            Console.WriteLine("Sphere info:");
            Console.WriteLine(sphere.ToString());
            Console.WriteLine($"Sphere volume: {sphere.CalculateSphereVolume()}");

            Console.ReadLine();
        }
    }
}
