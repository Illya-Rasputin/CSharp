using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{

    abstract class Shape
    {
        protected int GetPerimeter()
        {
            return 0;
        }
        protected int GetArea()
        {
            return 0;
        }
    }

    class Circle : Shape
    {
        private int _rad;
        public int rad
        {
            get => _rad;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(rad), "Value must be non-negative.");
                _rad = value;
            }
        }
        public Circle(int radius)
        {
            this.rad = radius;
        }
        public new int GetPerimeter()
        {
            return (int)(2 * 3.14 * rad);
        }
        public new int GetArea()
        {
            return (int)(3.14 * rad * rad);
        }
        public override string ToString()
        {
            return $"Circle(radius={rad}, perimeter={GetPerimeter()}, area={GetArea()})";
        }
    }

    class Rectangle : Shape
    {
        private int _len;
        private int _wid;
        public int len
        {
            get => _len;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(len), "Value must be non-negative.");
                _len = value;
            }
        }
        public int wid
        {
            get => _wid;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(wid), "Value must be non-negative.");
                _wid = value;
            }
        }
        public Rectangle(int length, int width)
        {
            this.len = length;
            this.wid = width;
        }
        public new int GetPerimeter()
        {
            return 2 * (len + wid);
        }
        public new int GetArea()
        {
            return len * wid;
        }
        public override string ToString()
        {
            return $"Square(sides={len},{wid}, perimeter={GetPerimeter()}, area={GetArea()})";
        }
    }
    class Square : Shape
    {
        private int _side;
        public int side
        {
            get => _side;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(side), "Value must be non-negative.");
                _side = value;
            }
        }
        public Square(int side)
        {
            this.side = side;
        }
        public new int GetPerimeter()
        {
            return 4 * side;
        }
        public new int GetArea()
        {
            return side * side;
        }
        public override string ToString()
        {
            return $"Square(side={side}, perimeter={GetPerimeter()}, area={GetArea()})";
        }
    }

    class Triangle : Shape
    {
        private int _side1;
        private int _side2;
        private int _side3;
        public int side1
        {
            get => _side1;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(side1), "Value must be non-negative.");
                _side1 = value;
            }
        }
        public int side2
        {
            get => _side2;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(side2), "Value must be non-negative.");
                _side2 = value;
            }
        }
        public int side3
        {
            get => _side3;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(side3), "Value must be non-negative.");
                _side3 = value;
            }
        }
        public Triangle(int s1, int s2, int s3)
        {
            this.side1 = s1;
            this.side2 = s2;
            this.side3 = s3;
        }
        public new int GetPerimeter()
        {
            return side1 + side2 + side3;
        }
        public new int GetArea()
        {
            int s = (side1 + side2 + side3) / 2;
            return (int)Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
        public override string ToString()
        {
            return $"Triangle(sides={side1},{side2},{side3}, perimeter={GetPerimeter()}, area={GetArea()})";
        }
    }

    class Rhombus : Shape
    {
        private int _diag1;
        private int _diag2;
        public int diag1
        {
            get => _diag1;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(diag1), "Value must be non-negative.");
                _diag1 = value;
            }
        }
        public int diag2
        {
            get => _diag2;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(diag2), "Value must be non-negative.");
                _diag2 = value;
            }
        }
        public Rhombus(int d1, int d2)
        {
            this.diag1 = d1;
            this.diag2 = d2;
        }
        public new int GetPerimeter()
        {
            return 4 * (int)Math.Sqrt((diag1 * diag1 + diag2 * diag2) / 4);
        }
        public new int GetArea()
        {
            return (diag1 * diag2) / 2;
        }
        public override string ToString()
        {
            return $"Rhombus(diagonals={diag1},{diag2}, perimeter={GetPerimeter()}, area={GetArea()})";
        }
    }
    class Parallelogram : Shape
    {
        private int _baseLen;
        private int _height;
        public int baseLen
        {
            get => _baseLen;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(baseLen), "Value must be non-negative.");
                _baseLen = value;
            }
        }
        public int height
        {
            get => _height;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(height), "Value must be non-negative.");
                _height = value;
            }
        }
        public Parallelogram(int b, int h)
        {
            this.baseLen = b;
            this.height = h;
        }
        public new int GetPerimeter()
        {
            return 2 * (baseLen + height);
        }
        public new int GetArea()
        {
            return baseLen * height;
        }
        public override string ToString()
        {
            return $"Parallelogram(base={baseLen}, height={height}, perimeter={GetPerimeter()}, area={GetArea()})";
        }
    }
    class Trapezoid : Shape
    {
        private int _base1;
        private int _base2;
        private int _height;
        public int base1
        {
            get => _base1;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(base1), "Value must be non-negative.");
                _base1 = value;
            }
        }
        public int base2
        {
            get => _base2;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(base2), "Value must be non-negative.");
                _base2 = value;
            }
        }
        public int height
        {
            get => _height;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(height), "Value must be non-negative.");
                _height = value;
            }
        }
        public Trapezoid(int b1, int b2, int h)
        {
            this.base1 = b1;
            this.base2 = b2;
            this.height = h;
        }
        public new int GetPerimeter()
        {
            return base1 + base2 + (int)Math.Sqrt((base2 - base1) * (base2 - base1) + height * height) + (int)Math.Sqrt((base2 - base1) * (base2 - base1) + height * height);
        }
        public new int GetArea()
        {
            return (base1 + base2) * height / 2;
        }
        public override string ToString()
        {
            return $"Trapezoid(bases={base1},{base2}, height={height}, perimeter={GetPerimeter()}, area={GetArea()})";
        }
    }
    class Ellipse : Shape
    {
        private int _majorAxis;
        private int _minorAxis;
        public int majorAxis
        {
            get => _majorAxis;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(majorAxis), "Value must be non-negative.");
                _majorAxis = value;
            }
        }
        public int minorAxis
        {
            get => _minorAxis;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(minorAxis), "Value must be non-negative.");
                _minorAxis = value;
            }
        }
        public Ellipse(int a, int b)
        {
            this.majorAxis = a;
            this.minorAxis = b;
        }
        public new int GetPerimeter()
        {
            return (int)(3.14 * (3 * (majorAxis + minorAxis) - Math.Sqrt((3 * majorAxis + minorAxis) * (majorAxis + 3 * minorAxis))));
        }
        public new int GetArea()
        {
            return (int)(3.14 * majorAxis * minorAxis);
        }
        public override string ToString()
        {
            return $"Ellipse(majorAxis={majorAxis}, minorAxis={minorAxis}, perimeter={GetPerimeter()}, area={GetArea()})";
        }
    }

    class CpmlxShape: Shape
    {
        Shape[] components;
        public CpmlxShape(params Shape[] components)
        {
            this.components = components;
        }
        public override string ToString()
        {
            if (components == null || components.Length == 0)
                return "Complex Shape: (empty)";

            var result = "Complex Shape consists of:\n";

            for (int i = 0; i < components.Length; i++)
            {
                result += $"{i + 1}. {components[i]}\n";
            }

            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CpmlxShape complexShape = new CpmlxShape(
                new Circle(5),
                new Rectangle(4, 6),
                new Square(3),
                new Triangle(3, 4, 5),
                new Rhombus(4, 5),
                new Parallelogram(4, 6),
                new Trapezoid(3, 5, 4),
                new Ellipse(5, 3)
            );
            Console.WriteLine(complexShape);
        }
    }
}
