internal class Program
{
    /// <summary>
    /// Represents a matrix of double values.
    /// </summary>
    public class Matr
    {
        double[,] matr;
        int row;
        int col;

        /// <summary>
        /// Initializes a new instance of the <see cref="Matr"/> class with no params.
        /// </summary>
        public Matr()
        {

        }

        /// <summary>
        /// Gets or sets the value of an element in the matrix at the specified indices.
        /// </summary>
        /// <param name="row">Row index.</param>
        /// <param name="col">Col index</param>
        /// <returns>The value of matrix element.</returns>
        public double this[int row, int col]
        {
            get => matr[row, col];
            set => matr[row, col] = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matr"/> class with specified dimensions.
        /// </summary>
        /// <param name="row">Number of rows.</param>
        /// <param name="col">Number of columns.</param>
        public Matr(int row,int col)
        {
            this.matr = new double[row,col];
            this.col = col;
            this.row = row;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matr"/> class as a copy of another matrix.
        /// </summary>
        /// <param name="c">Matrix to copy.</param>
        public Matr(Matr c)
        {
            this.matr = (double[,])c.matr.Clone();
            this.row = c.row;
            this.col = c.col;
        }

        /// <summary>
        /// Adds two matrices element-wise.
        /// </summary>
        /// <param name="f">First matrix.</param>
        /// <param name="s">Second matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static Matr operator + (Matr f, Matr s)
        {
            Matr r = new(f);
            for (int i = 0; i < f.row; i++)
            {
                for (int j = 0; j < f.col; j++)
                {
                    r[i, j] = f[i, j] + s[i,j];
                }
            }
            return r;
        }

        /// <summary>
        /// Determines if the first matrix is greater than the second matrix element-wise.
        /// </summary>
        /// <param name="f">First matrix.</param>
        /// <param name="s">Second matrix.</param>
        /// <returns>True if the first matrix is greater than the second matrix; otherwise, false.</returns>
        public static bool operator > (Matr f, Matr s)
        {
            if (f.row == s.row & f.col == s.col)
            {


                for (int i = 0; i < f.row; i++)
                {
                    for (int j = 0; j < f.col; j++)
                    {
                        if (f[i, j] < s[i, j])
                        {
                            return false;
                        }
                    }
                }

                return true;


            }

            return false;
            
        }

        /// <summary>
        /// Determines if the first matrix is less than the second matrix element-wise.
        /// </summary>
        /// <param name="f">First matrix.</param>
        /// <param name="s">Second matrix.</param>
        /// <returns>True if the first matrix is less than the second matrix; otherwise, false.</returns>
        public static bool operator <(Matr f, Matr s)
        {
            if (f.row == s.row & f.col == s.col)
            {


                for (int i = 0; i < f.row; i++)
                {
                    for (int j = 0; j < f.col; j++)
                    {
                        if (f[i, j] > s[i, j])
                        {
                            return false;
                        }
                    }
                }

                return true;


            }

            return false;

        }

        /// <summary>
        /// Prints the matrix.
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < this.row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.col; j++)
                {
                    Console.Write($"{this[i,j]} ");
                }
            }
        }
    }

    private static void Main(string[] args)
    {
        Matr a = new(2, 2);
        Matr b = new(2, 2);
        int s = 2;
        int c = 2;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                a[i, j] = 1;
                b[i, j] = 2;
            }
        }

        

        (a + b).Print();
        Console.WriteLine();
        a.Print();
        Console.WriteLine();
        a += b;
        a.Print();
        Console.WriteLine();

        Console.WriteLine(a<b);

    }
}