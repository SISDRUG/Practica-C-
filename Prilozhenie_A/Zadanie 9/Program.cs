internal class Program
{
    private static void Main(string[] args)
    {
		
		Console.WriteLine("Vvod r");
		int r = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"v = {0.75 * Math.PI * Math.Pow(r,3)}");
		Console.WriteLine($"s = {4 * Math.PI *Math.Pow(r,2)}");
		Console.ReadLine();
	}
}