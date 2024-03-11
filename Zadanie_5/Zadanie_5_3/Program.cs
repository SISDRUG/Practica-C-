internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("size");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("d");
        int d = Convert.ToInt32(Console.ReadLine());
        int[,] mass = new int[n, n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mass[i, j] = Random.Shared.Next(-5, 5);
            }
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-3} ", mass[i, j]);
            }
            
        }
        Console.WriteLine();
        int sum = 0;
        int underd = 0;
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n; i++)
            {
                sum += mass[i, j];
                if (mass[i,j]<d)
                {
                    underd += 1;
                }
            }

            Console.WriteLine($"j{j}={sum/n}");
            sum = 0;
        }
        Console.WriteLine($"Smaller then {d}: {underd} elements");
    }
}