namespace Zadanie_20_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, 12, 15, 68 };
            int sumThreshold = 59;
            int productThreshold = 1000;


            int sum = 0;
            Parallel.ForEach(numbers, (n, state) =>
            {

                
                if (sum + n > sumThreshold)
                {
                   state.Break();
                }
                else { sum += n; }
                 
            });
            
            Console.WriteLine("Сумма: " + sum);


            int product = 1;
            Parallel.ForEach(numbers, (n, state) =>
            {
                
                if (product*n > productThreshold)
                {
                    state.Break();
                }
                else
                {
                    product *= n;
                }
            });

            Console.WriteLine("Произведение: " + product);
        }
    }
}