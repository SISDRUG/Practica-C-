namespace Zadanie_20_1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 100 && number <= 999)
            {
                int a = number / 100;
                int b = (number / 10) % 10;
                int c = number % 10;

                int result = await CalculateResultAsync(a, b, c);

                Console.WriteLine($"Полученное число: {result}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите трехзначное число.");
            }
        }

        static async Task<int> CalculateResultAsync(int a, int b, int c)
        {
            await Task.Delay(1000);
            int result = c * 100 + a * 10 + b;
            return result;
        }
    }
}
