namespace Zadanie_12_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of random number generators
            Func<int>[] delegateArray = new Func<int>[]
            {
                () => new Random().Next(0, 9),
                () => new Random().Next(0, 9),
                () => new Random().Next(0, 9)
            };
            // Calculate the average of the random numbers
            Func<Func<int>[], double> averageCalculator = delegates =>
            {
                int sum = 0;
                foreach (var method in delegates)
                {
                    sum += method();
                }
                return (double)sum / delegates.Length;
            };

            Console.WriteLine($"Среднее арифметическое: {averageCalculator(delegateArray)}");
        }
    }
}