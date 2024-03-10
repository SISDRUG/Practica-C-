internal class Program
{
    static bool CheckForFreeSeats(bool[,] mass, int row)
    {
        for (int i = 0; i < 40; i++)
        {
            if (mass[row, i] == false)
            {
                return true;
            }
        }
        return false;
    }

    private static void Main(string[] args)
    {
        bool[,] mass = new bool[23, 40];
        for (int i = 0; i < 23; i++)
        {
            for (int j = 0; j < 40; j++)
            {
                mass[i, j] =Convert.ToBoolean(Random.Shared.Next(0,2));
            }
        }
        for (int i = 0; i < 23; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 40; j++)
            {
                Console.Write(Convert.ToInt32(mass[i,j]));
            }
        }
        Console.WriteLine();
        
        Console.WriteLine($"in first row {CheckForFreeSeats(mass,0)} free seats"); ;
    }
}