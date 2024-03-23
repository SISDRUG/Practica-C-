using Figure;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Treugolnik treugolnik = new(3, 4, 5);
        treugolnik.Info();
        Console.WriteLine(treugolnik.Perimetr());
        Console.WriteLine(treugolnik.Square());

    }
}