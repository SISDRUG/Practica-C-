internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Chose (m/w)");
        string x = Console.ReadLine();
        string[] mans = {"Mihail","Maksim","Andrey"};
        string[] girls = { "Jana", "Anna", "Lena" };
        Console.WriteLine($"all {x} names");
        if (x == "m" || x == "M")
        {
            foreach (string name in mans) { Console.WriteLine(name); }
        } else if(x=="w" || x == "W")
        {
            foreach (string name in girls) { Console.WriteLine(name); }
        }
    }
}