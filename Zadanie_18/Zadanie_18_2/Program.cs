internal class Program
{
    static void Main(string[] args)
    {
        string filePath = "f.txt";
        string fileContent = File.ReadAllText(filePath);

        Queue<char> nonDigits = new Queue<char>();
        Queue<char> digits = new Queue<char>();

        foreach (char c in fileContent)
        {
            if (char.IsDigit(c))
                digits.Enqueue(c);
            else
                nonDigits.Enqueue(c);
        }

        Console.WriteLine("letters:");
        while (nonDigits.Count > 0)
        {
            Console.Write(nonDigits.Dequeue());
        }

        Console.WriteLine("\ndigits:");
        while (digits.Count > 0)
        {
            Console.Write(digits.Dequeue());
        }
    }
}