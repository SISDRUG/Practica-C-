namespace Zadanie_20_3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 10 && number <= 99)
            {
                Task<int> calculateTask = CalculatePermutationAsync(number);

                await calculateTask.ContinueWith(task =>
                {
                    int result = task.Result;
                    Console.WriteLine($"Число после перестановки цифр: {result}");
                });
            }
            else
            {
                Console.WriteLine("Введите двузначное число.");
            }
        }

        static async Task<int> CalculatePermutationAsync(int n)
        {
            int a = n / 10;
            int b = n % 10;
            return b * 10 + a;
        }
    }
}
