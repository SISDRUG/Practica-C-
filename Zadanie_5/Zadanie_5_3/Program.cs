internal class Program
{
    private static void Main(string[] args)
        {

        int n = Convert.ToInt32(Console.ReadLine());
        int[,] mass = { };
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mass[i, j] = Random.Shared.Next(-5,5);
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                Console.Write(mass[i,j]);
            }
        }
        Console.WriteLine("Hello, World!");
    }
}