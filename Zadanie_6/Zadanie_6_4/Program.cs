internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите фамилию, имя и отчество пользователя: ");
        string s = Console.ReadLine();

        s = s.ToUpper();

        int sum = 0;

        foreach (char letter in s)
        {
            if (char.IsLetter(letter))
            {
                int letterNumber = letter - 'A' + 1;
                sum += letterNumber;
            }
        }

        while (sum >= 10)
        {
            int nsum = 0;
            while (sum > 0)
            {
                nsum += sum % 10;
                sum /= 10;
            }
            sum = nsum;
        }

        Console.WriteLine($"Код личности: {sum}");
    }
}
