class Program
{
    static void Main()
    {
        int n = 7;
        int[,] spiralArray = new int[n, n];
        int num = 1, top = 0, bottom = n - 1, left = 0, right = n - 1;

        while (num <= n * n)
        {
            for (int i = left; i <= right; i++)
                spiralArray[top, i] = num++;

            top++;

            for (int i = top; i <= bottom; i++)
                spiralArray[i, right] = num++;

            right--;

            for (int i = right; i >= left; i--)
                spiralArray[bottom, i] = num++;

            bottom--;

            for (int i = bottom; i >= top; i--)
                spiralArray[i, left] = num++;

            left++;
        }

        // Вывод массива
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            { 
                Console.Write($"{spiralArray[i, j],-3} ");
            }
            Console.WriteLine();
        }
    }
}
