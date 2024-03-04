internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("zadayte chislo");
        string x = Console.ReadLine();
        int max = 0;
        int min = 10;
        int indigit;

        foreach (char digit in x)
        {
            indigit = Convert.ToInt32(digit.ToString());
            if (max < indigit)
            {
                max = indigit;
            }
            if (min > indigit)
            {
                min = indigit;
            }
        }

        Console.WriteLine($"max {max}");
        Console.WriteLine($"min {min}");
    }
}