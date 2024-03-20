using System.Diagnostics;
class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(SumNumbers);
        Thread thread2 = new Thread(SumNumbers);

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        thread1.Start();
        thread1.Join();
        stopwatch.Stop();

        Console.WriteLine("Время первого потока: " + stopwatch.ElapsedMilliseconds + " мс");

        stopwatch.Reset();

        stopwatch.Start();
        thread2.Start();
        thread2.Join();
        stopwatch.Stop();

        Console.WriteLine("Время второго потока: " + stopwatch.ElapsedMilliseconds + " мс");
    }

    static void SumNumbers()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Console.WriteLine("Сумма: " + sum);
    }
}
