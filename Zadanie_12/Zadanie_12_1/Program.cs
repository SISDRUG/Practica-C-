namespace Zadanie_12_1
{
    class Program
    {
        /// <summary>
        /// Delegate for calculating figure properties.
        /// </summary>
        /// <param name="R">Radius or dimension of the figure.</param>
        /// <returns>Calculated value based on the figure.</returns>
        public delegate double CalcFigure(double R);

        /// <summary>
        /// Provides methods to calculate properties of a circle.
        /// </summary>
        public static class CircleCalculations
        {
            /// <summary>
            /// Calculates the circumference (length) of a circle.
            /// </summary>
            /// <param name="R">Radius of the circle.</param>
            /// <returns>Circumference of the circle.</returns>
            public static double GetLength(double R)
            {
                double result = 2 * Math.PI * R;
                Console.WriteLine($"Circumference: {result:f4}");
                return result;
            }

            /// <summary>
            /// Calculates the area of a circle.
            /// </summary>
            /// <param name="R">Radius of the circle.</param>
            /// <returns>Area of the circle.</returns>
            public static double GetArea(double R)
            {
                double result = Math.PI * Math.Pow(R, 2);
                Console.WriteLine($"Area of the circle: {result:f4}");
                return result;
            }

            /// <summary>
            /// Calculates the volume of a sphere.
            /// </summary>
            /// <param name="R">Radius of the sphere.</param>
            /// <returns>Volume of the sphere.</returns>
            public static double GetVolume(double R)
            {
                double result = 4.0 / 3.0 * Math.PI * Math.Pow(R, 3);
                Console.WriteLine($"Volume of the sphere: {result:f4}");
                return result;
            }

            static void Main(string[] args)
            {
                double R = 3;
                CalcFigure CF = new CalcFigure(GetLength);
                CF += GetArea;
                CF += GetVolume;

                CF(R);
            }
        }
    }
}