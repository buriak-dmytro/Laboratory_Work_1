using System;
using System.Collections.Generic;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosen = int.Parse(Console.ReadLine());
            switch (chosen)
            {
                case 1:
                    Console.Write("Enter circle radius: ");
                    double circleRadius = double.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.Write("Enter sphere radius: ");
                    double sphereRadius = double.Parse(Console.ReadLine());
                    Console.Write("Enter sphere coefficient: ");
                    double sphereCoefficient = double.Parse(Console.ReadLine());

                    TCircle circle = new TCircle(circleRadius);
                    TSphere sphere = new TSphere(sphereRadius, sphereCoefficient);

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
                    break;

                case 2:
                    Console.WriteLine("----Block1----");
                    HashSet<TCircle> hashSet1 = new HashSet<TCircle>(1);
                    hashSet1.Add(new TCircle(14));
                    TCircle obj1 = new TCircle(14);
                    if (hashSet1.Contains(obj1)) Console.WriteLine("YES");
                    else Console.WriteLine("NO");

                    Console.WriteLine("----Block2----");
                    HashSet<TCircleF> hashSet2 = new HashSet<TCircleF>(1);
                    hashSet2.Add(new TCircleF(25));
                    TCircleF obj2 = new TCircleF(25);
                    if (hashSet2.Contains(obj2)) Console.WriteLine("YES");
                    else Console.WriteLine("NO");

                    Console.WriteLine("----Block3----");
                    HashSet<TSphere> hashSet3 = new HashSet<TSphere>(1);
                    hashSet3.Add(new TSphere(36, 3));
                    TSphere obj31 = new TSphere(36, 3);
                    if (hashSet3.Contains(obj31)) Console.WriteLine("YES");
                    else Console.WriteLine("NO");
                    TSphere obj32 = new TSphere(36, 4);
                    if (hashSet3.Contains(obj32)) Console.WriteLine("YES");
                    else Console.WriteLine("NO");

                    Console.WriteLine("----Block4----");
                    HashSet<TSphereF> hashSet4 = new HashSet<TSphereF>(1);
                    hashSet4.Add(new TSphereF(47, 4));
                    TSphereF obj41 = new TSphereF(47, 4);
                    if (hashSet4.Contains(obj41)) Console.WriteLine("YES");
                    else Console.WriteLine("NO");
                    TSphereF obj42 = new TSphereF(47, 5);
                    if (hashSet4.Contains(obj42)) Console.WriteLine("YES");
                    else Console.WriteLine("NO");

                    break;
                case 3:
                    // pass
                    break;
            }

            Console.ReadLine();
        }
    }
}
