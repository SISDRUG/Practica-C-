internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("zadayte chislo");
        string x = Console.ReadLine();
        string res="";

        int indigit;

        foreach (char digit in x)
        {
            indigit = Convert.ToInt32(digit.ToString());
            if (indigit % 2 != 0)
            {
                res += digit;
            }

        }
        Console.WriteLine("chislo bez chetnix");
        Console.WriteLine(res);
    }
}