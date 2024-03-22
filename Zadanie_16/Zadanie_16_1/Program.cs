class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("f.txt");
        var numbers = lines.Select(int.Parse).Where(n => n % 3 == 0);
        File.WriteAllLines("g.txt", numbers.Select(n => n.ToString()));
    }
}
