using System;

namespace TaskOne
{
    class QuadraticEquation
    {
        private double coeffA;
        private double coeffB;
        private double coeffC;

        private bool infiniteNumberOfSolutions;
        private bool emptySetOfSolutions;
        private bool oneSolution;
        private bool twoSolutions;

        private double[] solutions;

        public QuadraticEquation()
        {
            coeffA = 0;
            coeffB = 0;
            coeffC = 0;

            SolveEquation();
        }

        public QuadraticEquation(double coeffA, double coeffB, double coeffC)
        {
            this.coeffA = coeffA;
            this.coeffB = coeffB;
            this.coeffC = coeffC;

            SolveEquation();
        }

        public double CoeffA
        {
            get { return coeffA; }
            set { coeffA = value; SolveEquation(); }
        }

        public double CoeffB
        {
            get { return coeffB; }
            set { coeffB = value; SolveEquation(); }
        }

        public double CoeffC
        {
            get { return coeffC; }
            set { coeffC = value; SolveEquation(); }
        }

        public bool InfiniteNumberOfSolutions { get { return infiniteNumberOfSolutions; } }
        public bool EmptySetOfSolutions { get { return emptySetOfSolutions; } }
        public bool OneSolution { get { return oneSolution; } }
        public bool TwoSolutions { get { return twoSolutions; } }

        public void ShowSolutions()
        {
            if (infiniteNumberOfSolutions)
            {
                Console.WriteLine("There are infinite number of solutions of current quadratic equation");
            }
            else if (emptySetOfSolutions)
            {
                Console.WriteLine("There are no solutions of current quadratic equation");
            }
            else if (oneSolution)
            {
                Console.WriteLine($"There is one solution of current quadratic equation: {solutions[0]}");
            }
            else if (twoSolutions)
            {
                Console.WriteLine($"There are two solutions of current quadratic equation: {solutions[0]} {solutions[1]}");
            }
            else
            {
                Console.WriteLine("There is no information about solutions of current quadratic equation");
            }
        }

        public void SolveEquation()
        {
            if (coeffA == 0)
            {
                if (coeffB == 0)
                {
                    if (coeffC == 0)
                    {
                        ResetSolutions();
                        infiniteNumberOfSolutions = true;
                    }
                    else
                    {
                        ResetSolutions();
                        emptySetOfSolutions = true;
                    }
                }
                else
                {
                    if (coeffC == 0)
                    {
                        ResetSolutions();
                        oneSolution = true;
                        solutions[0] = solutions[1] = 0;
                    }
                    else
                    {
                        ResetSolutions();
                        oneSolution = true;
                        solutions[0] = solutions[1] = -1 * (coeffC / coeffB);
                    }
                }
            }
            else
            {
                if (coeffB == 0)
                {
                    if (coeffC == 0)
                    {
                        ResetSolutions();
                        oneSolution = true;
                        solutions[0] = solutions[1] = 0;
                    }
                    else
                    {
                        if (-1 * (coeffC / coeffA) > 0)
                        {
                            ResetSolutions();
                            twoSolutions = true;
                            solutions[0] = -1 * Math.Sqrt(-1 * (coeffC / coeffA));
                            solutions[1] = Math.Sqrt(-1 * (coeffC / coeffA));
                        }
                        else
                        {
                            ResetSolutions();
                            emptySetOfSolutions = true;
                        }
                    }
                }
                else
                {
                    if (coeffC == 0)
                    {
                        ResetSolutions();
                        twoSolutions = true;
                        solutions[0] = 0;
                        solutions[1] = -1 * (coeffB / coeffA);
                    }
                    else
                    {
                        if (CalculateDiscriminator() < 0)
                        {
                            ResetSolutions();
                            emptySetOfSolutions = true;
                        }
                        else if (CalculateDiscriminator() == 0)
                        {
                            ResetSolutions();
                            oneSolution = true;
                            solutions[0] = solutions[1] = -1 * (coeffB / (2 * coeffA));
                        }
                        else
                        {
                            ResetSolutions();
                            twoSolutions = true;
                            solutions[0] = (-1 * coeffB + CalculateDiscriminator()) / (2 * coeffA);
                            solutions[1] = (-1 * coeffB - CalculateDiscriminator()) / (2 * coeffA);
                        }
                    }
                }
            }
        }
        
        private double CalculateDiscriminator()
        {
            return coeffB * coeffB - 4 * coeffA * coeffC;
        }

        public void ResetSolutions()
        {
            solutions = null;

            infiniteNumberOfSolutions = false;
            emptySetOfSolutions = false;
            oneSolution = false;
            twoSolutions = false;
        }

        public double this[int i]
        {
            get
            {
                if (i == 0 || i == 1)
                {
                    if (infiniteNumberOfSolutions)
                    {
                        throw new Exception("There are infinite number of solutions of current quadratic equation");
                    }
                    else if (emptySetOfSolutions)
                    {
                        throw new Exception("There are no solutions of current quadratic equation");
                    }
                    else if (oneSolution)
                    {
                        Console.WriteLine("There is one solution of current quadratic equation");
                        return solutions[0];
                    }
                    else if (twoSolutions)
                    {
                        Console.WriteLine("There are two solutions of current quadratic equation");
                        return solutions[i];
                    }
                    else
                    {
                        throw new Exception("There is no information about solutions of current quadratic equation");
                    }
                }
                else
                {
                    throw new Exception("There are at most two solutions of quadratic equation");
                }
            }
        }
    }
}
