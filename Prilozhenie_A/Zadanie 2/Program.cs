internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vvod shifrovanogo chisla");
        string a = Console.ReadLine();
        int length = a.Length;
        int b = Convert.ToInt32(a);
        Console.WriteLine("Zashofrovanoe slovo");
        Console.WriteLine(b % Convert.ToInt32(Math.Pow(10,length-1))*10+b / Convert.ToInt32(Math.Pow(10, length - 1)));
        Console.ReadLine();
        
        
        
        
    }
}