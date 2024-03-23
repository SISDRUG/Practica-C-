using System;
namespace Figure
{
    public class Treugolnik
    {
        int a;
        int b;
        int c;
        string type;

        public Treugolnik(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Unreal treugolnik");
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;

                this.type = "Unfound";

                if (a == b || b == c || a == c)
                {
                    this.type = "Isosceles";
                }
                if (a == b & b == c)
                {
                    this.type = "Equilateral";
                }
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                {
                    this.type = "Rectangular";
                }
            }
        }

        public void Info()
        {
            Console.WriteLine("A side " + a);
            Console.WriteLine("B side " + b);
            Console.WriteLine("C side " + c);
            Console.WriteLine("Type " + type);
        }

        public int Perimetr()
        {
            return a + b + c;
        }

        public double Square()
        {
            double s;
            int p = this.Perimetr() / 2;
            s = Math.Sqrt(p) * (p - a) * (p - b) * (p - c);
            return s;
        }

        public class Rectangle
        {
            int w, h;

            public Rectangle(int w, int h)
            {
                this.w = w;
                this.h = h;
            }

            public int Perimetr()
            {
                return (w + h) * 2;
            }

            public int Square()
            {
                return w * h;
            }
        } 
    }
}

