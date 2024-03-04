internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input number");
        string x = Console.ReadLine();
        if (x[x.Length - 1] == '7')
        {
            Console.WriteLine("Last is 7");
        }
        else {
            Console.WriteLine("last isn't 7");
        }
    }
}