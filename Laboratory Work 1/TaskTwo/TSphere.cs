using System;

namespace TaskTwo
{
    class TSphere : TCircle
    {
        public TSphere() : base() { }

        public TSphere(double radius) : base(radius) { }

        public TSphere(TSphere sphereToCopy) : base(sphereToCopy) { }

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

        public double CalculateSphereVolume()
        {
            return 4 * Math.PI * radius * radius * radius / 3;
        }

        public static bool operator ==(TSphere sphere1, TSphere sphere2)
        {
            if (sphere1.Radius == sphere2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(TSphere sphere1, TSphere sphere2)
        {
            if (sphere1.Radius != sphere2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static TSphere operator +(TSphere sphere1, TSphere sphere2)
        {
            return new TSphere(sphere1.Radius + sphere2.Radius);
        }

        public static TSphere operator -(TSphere sphere1, TSphere sphere2)
        {
            return new TSphere(Math.Abs(sphere1.Radius + sphere2.Radius));
        }

        public static TSphere operator *(double coeff, TSphere sphere)
        {
            return new TSphere(coeff * sphere.Radius);
        }

        public static TSphere operator *(TSphere sphere, double coeff)
        {
            return new TSphere(coeff * sphere.Radius);
        }
    }
}
