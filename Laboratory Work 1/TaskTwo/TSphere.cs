using System;

namespace TaskTwo
{
    public class TSphere : TCircleF
    {
        protected double coefficient;

        public TSphere() : base()
        {
            coefficient = 0;
        }

        public TSphere(double radius, double coefficient) : base(radius)
        {
            this.coefficient = coefficient;
        }

        public TSphere(TSphere sphereToCopy) : base(sphereToCopy)
        {
            this.coefficient = sphereToCopy.coefficient;
        }

        public override string ToString()
        {
            return $"Sphere with a radius of {radius}";
        }

        new public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Sphere radius cannot be negative");
                }
                else
                {
                    radius = value;
                }
            }
        }

        public double Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }
        }

        public double CalculateSphereVolume()
        {
            return 4 * Math.PI * radius * radius * radius / 3;
        }

        //public static bool operator ==(TSphere sphere1, TSphere sphere2)
        //{
        //    if (sphere1.radius == sphere2.radius & sphere1.coefficient == sphere2.coefficient)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public static bool operator !=(TSphere sphere1, TSphere sphere2)
        //{
        //    if (sphere1.radius != sphere2.radius | sphere1.coefficient != sphere2.coefficient)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public static TSphere operator +(TSphere sphere1, TSphere sphere2)
        {
            return new TSphere(sphere1.radius + sphere2.radius, sphere1.coefficient + sphere2.coefficient);
        }

        public static TSphere operator -(TSphere sphere1, TSphere sphere2)
        {
            return new TSphere(Math.Abs(sphere1.radius - sphere2.radius), Math.Abs(sphere1.coefficient - sphere2.coefficient));
        }

        public static TSphere operator *(double coeff, TSphere sphere)
        {
            return new TSphere(coeff * sphere.radius, coeff * sphere.coefficient);
        }

        public static TSphere operator *(TSphere sphere, double coeff)
        {
            return new TSphere(coeff * sphere.radius, coeff * sphere.coefficient);
        }
    }
}
