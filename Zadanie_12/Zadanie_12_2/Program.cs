namespace Zadanie_12_2
{
    class Program
    {
        /// <summary>
        /// Delegate for binary arithmetic operations.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Result of the operation.</returns>
        public delegate double Del(double a, double b);

        static void Main(string[] args)
        {
            // Create delegate instances for addition, subtraction, multiplication, and division
            Del Add = (a, b) => a + b;
            Del Sub = (a, b) => a - b;
            Del Mul = (a, b) => a * b;
            Del Div = (a, b) => b != 0 ? a / b : throw new DivideByZeroException();

            int a = 3;
            int b = 4;
            Console.WriteLine($"Сложение: {Add(a, b)}");
            Console.WriteLine($"Вычитание: {Sub(a, b)}");
            Console.WriteLine($"Умножение: {Mul(a, b)}");
            Console.WriteLine($"Деление: {Div(a, b):f4}");
        }
    }
}