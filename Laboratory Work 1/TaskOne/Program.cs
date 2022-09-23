using System;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a b c: ");
            string[] abc = Console.ReadLine().Split();
            int a = int.Parse(abc[0]);
            int b = int.Parse(abc[1]);
            int c = int.Parse(abc[2]);

            QuadraticEquation eq1 = new QuadraticEquation(a, b, c);
            eq1.SolveEquation();

            eq1.ShowSolutions();

            Console.WriteLine($"First solution: {eq1[0]}");
            Console.WriteLine($"Second solution: {eq1[1]}");

            Console.ReadLine();
        }
    }
}
