internal class Program
{
    private static void Main(string[] args)
    {
        int n = 10;
        int[] mass = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            mass[i] = mass[i] + rnd.Next(-5,5);
        }
        Console.WriteLine("Input k");

        int k = Convert.ToInt32(Console.ReadLine());
        Array.Sort(mass);
        Console.WriteLine($"Summ = {mass.Where(s => s > 0).Sum()}");
        Console.WriteLine($"Otr = {mass.Where(s => s < 0).Count()}");
        Console.WriteLine($"Null = {mass.Where(s => s == 0).Count()}");
        Console.WriteLine($"Otr = {mass.Where(s => s < 0).Count()}");
    }
}