internal class Program
{
    public class A
    {
        int a;
        int b;

        public A()
        {

        }

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double sred()
        {
            return (a+b)/2.0;
        }

        public double usl()
        {
            return Math.Pow(b, 3) + Math.Sqrt(a);
        }
    }

    private static void Main(string[] args)
    {
        A a = new(4,5);
        Console.WriteLine(a.sred());
        Console.WriteLine(a.usl()) ;
    }
}