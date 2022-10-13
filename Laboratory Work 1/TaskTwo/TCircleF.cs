using System;

namespace TaskTwo
{
    public class TCircleF : TCircle
    {
        public TCircleF() : base() { }

        public TCircleF(double radius) : base(radius) { }

        public TCircleF(TCircleF circleToCopy) : base(circleToCopy) { }

        //public static bool operator ==(TCircleF circle1, TCircleF circle2)
        //{
        //    if (circle1.radius == circle2.radius)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public static bool operator !=(TCircleF circle1, TCircleF circle2)
        //{
        //    if (circle1.radius != circle2.radius)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public static TCircleF operator +(TCircleF circle1, TCircleF circle2)
        {
            return new TCircleF(circle1.radius + circle2.radius);
        }

        public static TCircleF operator -(TCircleF circle1, TCircleF circle2)
        {
            return new TCircleF(Math.Abs(circle1.radius - circle2.radius));
        }

        public static TCircleF operator *(double coeff, TCircleF circle)
        {
            return new TCircleF(coeff * circle.radius);
        }

        public static TCircleF operator *(TCircleF circle, double coeff)
        {
            return new TCircleF(coeff * circle.radius);
        }

        public override bool Equals(object obj)
        {
            TCircleF circle = obj as TCircleF;

            if (circle == null)
            {
                return false;
            }
            else
            {
                if (this.radius.Equals(circle.radius))
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
            return radius.GetHashCode();
        }
    }
}
