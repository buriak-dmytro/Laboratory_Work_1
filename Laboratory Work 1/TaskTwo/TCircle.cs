using System;

namespace TaskTwo
{
    public class TCircle
    {
        protected double radius;

        public TCircle()
        {
            this.radius = 0;
        }

        public TCircle(double radius)
        {
            if (radius < 0)
            {
                throw new Exception("Circle radius cannot be negative");
            }
            else
            {
                this.radius = radius;
            }
        }

        public TCircle(TCircle circleToCopy)
        {
            this.radius = circleToCopy.radius;
        }

        public override string ToString()
        {
            return $"Circle with a radius of {radius}";
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Circle radius cannot be negative");
                }
                else
                {
                    radius = value;
                }
            }
        }

        public double CalculateCircleArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculateCircleSectorArea(double angle) // C.I. - radians
        {
            if (angle >= -2 * Math.PI & angle <= 2 * Math.PI)
            {
                return radius * radius * Math.Abs(angle) / 2;
            }
            else
            {
                throw new Exception("Incorrect angle specified");
            }
        }

        public double CalculateCircleLength()
        {
            return 2 * Math.PI * radius;
        }

        public static bool operator ==(TCircle circle1, TCircle circle2)
        {
            if (circle1.Radius == circle2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(TCircle circle1, TCircle circle2)
        {
            if (circle1.Radius != circle2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static TCircle operator +(TCircle circle1, TCircle circle2)
        {
            return new TCircle(circle1.Radius + circle2.Radius);
        }

        public static TCircle operator -(TCircle circle1, TCircle circle2)
        {
            return new TCircle(Math.Abs(circle1.Radius + circle2.Radius));
        }

        public static TCircle operator *(double coeff, TCircle circle)
        {
            return new TCircle(coeff * circle.Radius);
        }

        public static TCircle operator *(TCircle circle, double coeff)
        {
            return new TCircle(coeff * circle.Radius);
        }
    }
}
