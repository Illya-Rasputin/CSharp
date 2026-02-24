using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    class SquareC
    {
        

        public int a { get; set; }
        public SquareC() : this(0) { }
        public SquareC(int x)
        {
            if (x < 0)
                throw new ArgumentException("Side length cannot be negative.");

            
            this.a = x;
        }
        public override string ToString()
        {
            return $"Squares side = {a}.";
        }
        public override bool Equals(object obj)
        {
            return obj is SquareC point &&
                   a == point.a;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(a);
        }
        public static SquareC operator ++(SquareC s)
        {
            return new SquareC(s.a + 1);
        }
        public static SquareC operator --(SquareC s)
        {
            return new SquareC(s.a - 1);
        }
        public static SquareC operator +(SquareC s1, SquareC s2)
        {
            return new SquareC(s1.a + s2.a);
        }
        public static SquareC operator -(SquareC s1, SquareC s2)
        {
            if (s1.a < s2.a)
            {
                throw new InvalidOperationException("Resulting square cannot have a negative side length.");
            }
            else
            {
                return new SquareC(s1.a - s2.a);
            }
        }
        public static SquareC operator *(SquareC s1, SquareC s2)
        {
            return new SquareC(s1.a * s2.a);
        }
        public static SquareC operator /(SquareC s1, SquareC s2)
        {
            if (s2.a == 0)
            {
                throw new DivideByZeroException("Cannot divide by a square with side length of zero.");
            }
            else
            {
                return new SquareC(s1.a / s2.a);
            }
        }
        public static bool operator !=(SquareC s1, SquareC s2)
        {
            return !s1.Equals(s2);
        }
        public static bool operator ==(SquareC s1, SquareC s2)
        {
            return s1.Equals(s2);
        }
        public static bool operator >(SquareC s1, SquareC s2)
        {
            return s1.a > s2.a;
        }
        public static bool operator <(SquareC s1, SquareC s2)
        {
            return s1.a < s2.a;
        }
        public static bool operator >=(SquareC s1, SquareC s2)
        {
            return s1.a >= s2.a;
        }
        public static bool operator <=(SquareC s1, SquareC s2)
        {
            return s1.a <= s2.a;
        }
        public static bool operator true(SquareC s)
        {
            return s.a > 0;
        }
        public static bool operator false(SquareC s)
        {
            return s.a == 0;
        }
        public static implicit operator int(SquareC s)
        {
            return (s.a * s.a);
        }
        public static implicit operator Rectangle(SquareC s)
        {
            return new Rectangle(s.a, s.a);
        }
    }




    class Rectangle
    {
        public int w { get; set; }
        public int h { get; set; }

        public Rectangle(int width, int height)
        {
            if (width < 0 || height < 0)
                throw new ArgumentException("Sides cannot be negative.");

            w = width;
            h = height;
        }

        public override string ToString()
        {
            return $"{w} x {h}";

        }
        public override bool Equals(object obj)
        {
            return obj is Rectangle other &&
                   w == other.w &&
                   h == other.h;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(w, h);
        }

        

        public static Rectangle operator ++(Rectangle r)
        {
            return new Rectangle(r.w + 1, r.h + 1);
        }

        

        public static Rectangle operator --(Rectangle r)
        {
            if (r.w - 1 < 0 || r.h - 1 < 0)
                throw new InvalidOperationException("Sides cannot be negative.");

            return new Rectangle(r.w - 1, r.h - 1);
        }

        
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(
                r1.w + r2.w,
                r1.h + r2.h
            );
        }

        
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            int newW = r1.w - r2.w;
            int newH = r1.h - r2.h;

            if (newW < 0 || newH < 0)
                throw new InvalidOperationException("Resulting rectangle cannot have negative sides.");

            return new Rectangle(newW, newH);
        }

        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(
                r1.w * r2.w,
                r1.h * r2.h
            );
        }

        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            if (r2.w == 0 || r2.h == 0)
                throw new DivideByZeroException("Cannot divide by a rectangle with zero width or height.");
            return new Rectangle(
                r1.w / r2.w,
                r1.h / r2.h
            );
        }

        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            if (ReferenceEquals(r1, r2))
                return true;

            if (r1 is null || r2 is null)
                return false;

            return r1.w == r2.w &&
                   r1.h == r2.h;
        }

        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1 == r2);
        }

        
        public static bool operator >(Rectangle r1, Rectangle r2)
        {
            return (r1.w * r1.h) >
                   (r2.w * r2.h);
        }

        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return (r1.w * r1.h) <
                   (r2.w * r2.h);
        }

        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return (r1.w * r1.h) >=
                   (r2.w * r2.h);
        }

        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return (r1.w * r1.h) <=
                   (r2.w * r2.h);
        }
        public static explicit operator int(Rectangle r)
        {
            return r.w * r.h;
        }
        public static explicit operator SquareC(Rectangle r)
        {
            if (r.w != r.h)
                throw new InvalidOperationException("Cannot convert rectangle to square unless sides are equal.");

            return new SquareC(r.w);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(4, 5);
            Rectangle r2 = new Rectangle(2, 3);

            Console.WriteLine($"r1 = {r1}");
            Console.WriteLine($"r1 = {r2}");

            
            Rectangle rAdd = r1 + r2;
            Console.WriteLine($"r1 + r2 = {rAdd}");

            
            Rectangle rMin = r1 - r2;
            Console.WriteLine($"r1 - r2 = {rMin}");

            
            Rectangle rMul = r1 * r2;
            Console.WriteLine($"r1 * r2 = {rMul}");

            Rectangle rDiv = r1 / r2;
            Console.WriteLine($"r1 / r2 = {rDiv}");

            
            r1++;
            Console.WriteLine($"r1++ = {r1}");

            r1--;
            Console.WriteLine($"r1-- = {r1}");

            
            Console.WriteLine($"r1 == r2 : {r1 == r2}");
            Console.WriteLine($"r1 != r2 : {r1 != r2}");
            Console.WriteLine($"r1 > r2  : {r1 > r2}");
            Console.WriteLine($"r1 < r2  : {r1 < r2}");
            Console.WriteLine($"r1 >= r2 : {r1 >= r2}");
            Console.WriteLine($"r1 <= r2 : {r1 <= r2}");

            

            SquareC s1 = new SquareC(5);
            SquareC s2 = new SquareC(3);

            Console.WriteLine($"s1 = {s1}");
            Console.WriteLine($"s2 = {s2}");

            SquareC sAdd = s1 + s2;
            Console.WriteLine($"s1 + s2 = {sAdd}");

            SquareC sSub = s1 - s2;
            Console.WriteLine($"s1 - s2 = {sSub}");

            s1++;
            Console.WriteLine($"s1++ = {s1}");

            s1--;
            Console.WriteLine($"s1-- = {s1}");

            Console.WriteLine($"s1 == s2 : {s1 == s2}");
            Console.WriteLine($"s1 > s2  : {s1 > s2}");


            Rectangle toS = s1;
            Console.WriteLine($"Rectangle from Square: {toS}");

            
            Rectangle equalRect = new Rectangle(6, 6);
            SquareC fromRect = (SquareC)equalRect;
            Console.WriteLine($"Square from Rectangle: {fromRect}");

            
            int sqr = s1;
            Console.WriteLine($"Square to int: {sqr}");

            
            int rect = (int)r1;
            Console.WriteLine($"Rectangle to int: {rect}");

            
        }
    }
}
