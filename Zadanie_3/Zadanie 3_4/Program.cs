internal class Program
{
    /// <summary>
    /// Represents a matrix of strings.
    /// </summary>
    public class StringMatr
    {
        private string[,] stmatr;
        private int row;
        private int col;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringMatr"/> class.
        /// </summary>
        public StringMatr()
        {
            
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="StringMatr"/> class with specified dimensions and cell values.
        /// </summary>
        /// <param name="row">Number of rows.</param>
        /// <param name="col">Number of columns.</param>
        /// <param name="stroke">A semicolon-separated string containing cell values.</param>
        public StringMatr(int row, int col, string stroke)
        {
            this.row = row;
            this.col = col;
            this.stmatr = new string[row, col];
            string[] cells = stroke.Split(';');
            int c = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    this.stmatr[i, j] = cells[c];
                    c++;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringMatr"/> class with user input for cell values.
        /// </summary>
        /// <param name="row">Number of rows.</param>
        /// <param name="col">Number of columns.</param>
        public StringMatr(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.stmatr = new string[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine($"Input cell [{i},{j}]");
                    this.stmatr[i, j] = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// Sets the size of the matrix.
        /// </summary>
        /// <param name="row">Number of rows.</param>
        /// <param name="col">Number of columns.</param>
        public void Size(int row, int col)
        {
            this.stmatr = new string[row, col];
            this.row = row;
            this.col = col;
        }


        /// <summary>
        /// Adds two matrices element-wise.
        /// </summary>
        /// <param name="f">First matrix.</param>
        /// <param name="s">Second matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static StringMatr operator +(StringMatr f, StringMatr s)
        {
            StringMatr result = new StringMatr();
            result.Size(f.row, f.col);
            for (int i = 0; i < f.row; i++)
            {
                for (int j = 0; j < f.col; j++)
                {
                    result.stmatr[i, j] = f.stmatr[i, j] + s.stmatr[i, j];
                }
            }
            return result;
        }

        /// <summary>
        /// Prints the matrix.
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    Console.Write($"{this.stmatr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    private static void Main(string[] args)
    {
        StringMatr stringMatr = new(3, 3,"a;a;a;b;b;b;c;c;c");
        StringMatr f = new(3, 3, "a;a;a;b;b;b;c;c;c");
        StringMatr s = new(3, 3, "b;b;b;c;c;c;a;a;a");
        StringMatr t = f + s;
        t.Print();
        (f + s).Print();
    }
}