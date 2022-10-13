using System;

namespace TaskTwo
{
    class TSphereF : TSphere
    {
        public TSphereF() : base() { }

        public TSphereF(double radius, double coefficient) : base(radius, coefficient) { }

        public TSphereF(TSphereF sphereToCopy) : base(sphereToCopy) { }

        //public static bool operator ==(TSphereF sphere1, TSphereF sphere2)
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

        //public static bool operator !=(TSphereF sphere1, TSphereF sphere2)
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

        public static TSphere operator +(TSphereF sphere1, TSphereF sphere2)
        {
            return new TSphere(sphere1.radius + sphere2.radius, sphere1.coefficient + sphere2.coefficient);
        }

        public static TSphere operator -(TSphereF sphere1, TSphereF sphere2)
        {
            return new TSphere(Math.Abs(sphere1.radius - sphere2.radius), Math.Abs(sphere1.coefficient - sphere2.coefficient));
        }

        public static TSphere operator *(double coeff, TSphereF sphere)
        {
            return new TSphere(coeff * sphere.radius, coeff * sphere.coefficient);
        }

        public static TSphere operator *(TSphereF sphere, double coeff)
        {
            return new TSphere(coeff * sphere.radius, coeff * sphere.coefficient);
        }

        public override bool Equals(object obj)
        {
            TSphereF sphere = obj as TSphereF;

            if (sphere == null)
            {
                return false;
            }
            else
            {
                if (this.radius.Equals(sphere.radius) & this.coefficient.Equals(sphere.coefficient))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override int GetHashCode()
        {
            return radius.GetHashCode() * radius.GetHashCode() + coefficient.GetHashCode() * coefficient.GetHashCode();
        }
    }
}
