internal class Program
{
    abstract class Avto
    {
        string name;


        public Avto(string name)
        {
            this.name = name;
        }

        public abstract double M();
    }

    #region Poyasnenie
    /*
     * 2 zadanie v odnom 
     * zabil sohranit pervoe
     */
    #endregion

    class Legkovoy :Avto
    {
        int v;

        public Legkovoy(string name, int v) : base(name)
        {
            this.v = v;
        }

        public override double M()
        {
            return 2.5 * v;
        }
    }

    class Gruzovoy:Avto
    {
        int p;

        public Gruzovoy(string name, int p) : base(name)
        {
            this.p = p;
        }

        public override double M()
        {
            return Math.Sqrt(p)*100;
        }
    }

    private static void Main(string[] args)
    {
        Avto[] avtos = new Avto[]
        {
            new Legkovoy("BMW",3400),
            new Legkovoy("Benz", 2500),
            new Gruzovoy("Benz",6),
            new Gruzovoy("WV",9)
        };

        double sum = 0;

        foreach (var avto in avtos)
        {
            sum += avto.M();
        }
        Console.WriteLine($"sum topliva = {sum}");
    }
}