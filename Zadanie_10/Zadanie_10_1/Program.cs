internal class Program
{
    public class Pole
    {
        string name;
        int r;

        public Pole(string name, int r)
        {
            this.name = name;
            this.r = r;
        }

        public string Name
        {
            get { return name; }
        }
        public int R
        {
            get { return r; }
        }

        public virtual int InSquare(int k)
        {
            return k * r;
        }
    }

    public class PotatoPole: Pole
    {
        int s;

        public int S
        {
            get { return s; }
        }

        public PotatoPole(string name, int r, int s) : base(name, r)
        {
            this.s = s;
        }

        public override int InSquare(int k)
        {
            return base.InSquare(k) * s;
        }
    }
    private static void Main(string[] args)
    {
        Pole pole = new Pole("bip",400);
        Console.WriteLine(pole.InSquare(4));
        PotatoPole potato = new PotatoPole("bull", 1000, 1000);
        Console.WriteLine(potato.Name);
        Console.WriteLine(potato.InSquare(100));
        Console.WriteLine(potato.InSquare(4));
    }
}