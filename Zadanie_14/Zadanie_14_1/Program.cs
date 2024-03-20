class Program
{
    static AutoResetEvent autoEvent1 = new AutoResetEvent(false);
    static AutoResetEvent autoEvent2 = new AutoResetEvent(false);
    static AutoResetEvent autoEvent3 = new AutoResetEvent(false);

    static void Main()
    {
        Thread t1 = new Thread(FirstThread);
        Thread t2 = new Thread(SecondThread);
        Thread t3 = new Thread(ThirdThread);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
    }

    static void FirstThread()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(100);
            autoEvent1.Set();
            autoEvent3.WaitOne();
        }
    }

    static void SecondThread()
    {
        for (int i = 10; i < 20; i++)
        {
            autoEvent1.WaitOne();
            Console.WriteLine(i);
            Thread.Sleep(100);
            autoEvent2.Set();
        }
    }

    static void ThirdThread()
    {
        for (int i = 20; i < 30; i++)
        {
            autoEvent2.WaitOne();
            Console.WriteLine(i);
            Thread.Sleep(100);
            autoEvent3.Set();
        }
    }
}
