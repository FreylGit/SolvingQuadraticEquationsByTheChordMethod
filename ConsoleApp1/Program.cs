
namespace ConsoleApp;


//Решение квадратных уравнений методом хорд
class Program
{
    private static double k1, k2, k3;
    private static double a, b;
    private static int n;
    public static double e = 0.001;
    static void Main(string[] args)
    {

        /*Console.Write("a:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c:");
        c = Convert.ToDouble(Console.ReadLine());
        Console.Write("xn:");
        xn = Convert.ToDouble(Console.ReadLine());
        Console.Write("xk:");
        xk = Convert.ToDouble(Console.ReadLine());
        Console.Write("n:");
        n = Convert.ToInt32(Console.ReadLine());*/
        k1 = 3;
        k2 = 7;
        k3 = -10;
        n = 10;
        a = -4;
        b = 2;

        double x = a;
        double step = (b - a) / n;
        List<double> arrayFX = ShapingValuesBySteps();

        for (int i = 0; i < n - 1; i++)
        {
            if (Check(arrayFX[i], DF2()) != Check(arrayFX[i + 1], DF2()))
            {

                a = x;
                b = x + step;
                x = b;

                while (H1(x) > e)
                {

                    x = x - H1(x);
                    break;
                }
                Console.WriteLine("Ответ:" + x);

            }
            x += step;

        }
    }

    public static List<double> ShapingValuesBySteps()
    {
        List<double> arrayFX = new List<double>();
        double step = (b - a) / n;
        double x = a;

        for (int i = 0; i < n; i++)
        {
            arrayFX.Add(F(x));
            x += step;
        }
        return arrayFX;

    }
    public static double F(double x)
    {
        return k1 * Math.Pow(x, 2) + k2 * x + k3;
    }
    public static double DF2()
    {
        return 2 * k1;
    }

    public static double H1(double xi)
    {
        return (F(xi) * (xi - a)) / (F(xi) - F(a));
    }

    public static bool Check(double f1, double f2)
    {
        if (f1 * f2 > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}