internal class Program
{
    public class A
    {
        protected int a;
        protected int b;
        public int C
        {
            get
            {
                do
                {
                    a -= b;
                } while (a>0);
                return a;
            }
        }

        public A()
        {
        }

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

    }

    public class B : A
    {
        int d;

        public B(int a, int b,int d) : base(a, b)
        {
            this.d = d;
        }

        public B()
        {
            a = 4;
            b = 3;
            d = 2;
        }

        public int C2
        {
            get
            {
                do
                {
                    a += b;
                    d--;
                } while (d > 0);
                return a;
            }
            
        }
        
    }
    private static void Main(string[] args)
    {
        A a = new A(4, 5);
        B b1 = new B(4, 5, 3);
        B b2 = new B();
        Console.WriteLine(a.C);
        Console.WriteLine(b1.C);
        Console.WriteLine(b2.C2);
    }
}