internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        int[] digitCount = new int[10];

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                digitCount[c - '0']++;
            }
        }

        int maxCount = 0;
        int mostFrequentDigit = -1;

        for (int i = 0; i < 10; i++)
        {
            if (digitCount[i] > maxCount)
            {
                maxCount = digitCount[i];
                mostFrequentDigit = i;
            }
        }

        if (mostFrequentDigit != -1)
        {
            Console.WriteLine($"Самая часто встречающаяся цифра: {mostFrequentDigit}");
        }
        else
        {
            Console.WriteLine("В строке нет цифр.");
        }
    }
}