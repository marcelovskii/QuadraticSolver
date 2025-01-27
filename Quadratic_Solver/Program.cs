namespace Quadratic_Solver
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
        }
    }

    public class QuadraticSolver
    {
        public static (int, double?, double?) Solve(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("To nie jest równanie kwadratowe!");
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return (0, null, null);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return (1, x, null);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return (2, x1, x2);
            }
        }
    }
}
