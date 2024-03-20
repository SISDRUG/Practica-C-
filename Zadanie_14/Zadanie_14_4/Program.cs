class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int numThreads = a.Count() / 2 - 1;
        long[] partialSums = new long[numThreads];
        Thread[] threads = new Thread[numThreads];
        for (int i = 0; i < numThreads; i++)
        {
            int threadIndex = i;
            threads[i] = new Thread(() =>
                {
                    long sum = 0;
                    for (int j = threadIndex; j < a.Length; j += numThreads)
                    {
                        if (a[j] % 2 == 0)
                            sum += a[j];
                    }
                    partialSums[threadIndex] = sum;
                });
            threads[i].Start();
        }

        foreach (var thread in threads)
            thread.Join();

        long totalSum = 0;
        foreach (var sum in partialSums)
            totalSum += sum;

        Console.WriteLine($"Общая сумма четных чисел: {totalSum}");
    }
}