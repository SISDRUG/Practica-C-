class Program
{
    static void Main()
    {
        Console.Write("Введите значение A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Thread thread1 = new Thread(() => Sum(A, N));
        Thread thread2 = new Thread(() => Sum(A, N));
        Thread thread3 = new Thread(() => Multiply(A, N));

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        thread3.Start();
        thread3.Join();
    }

    static void Sum(int A, int N)
    {
        double sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += Math.Pow(A, i);
        }
        Console.WriteLine("Сумма: " + sum);
    }

    static void Multiply(int A, int N)
    {
        double product = 1;
        for (int i = 1; i <= N; i++)
        {
            product *= Math.Pow(A, i);
        }
        Console.WriteLine("Произведение: " + product);
    }
}
