using System.Threading.Tasks;

namespace Zadanie_20_2
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            int a = 4;
            Task[] t = new Task[2]
            {
                new Task(() => Console.WriteLine(Math.Sin(4 * a) / (1 + Math.Cos(4 * a))*Math.Cos(2*a)/(1+Math.Cos(2*a)))),
                new Task(() => Console.WriteLine(1/Math.Tan(3/2*Math.PI-a)))
            };

            foreach (var task in t)
            {
                task.Start();

            }
            //waiting for comlete
            Task.WaitAll(t);
            Task.WaitAny(t);
        }
    }
}