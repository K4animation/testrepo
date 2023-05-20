using System;

public class Pierwiastki
{
    public static (double x1, double x2) ObliczPierwiastki(double a, double b, double c)
    {       
        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Pierwiastki równania to: x1 = {0}, x2 = {1}", x1, x2);
            return (x1, x2);
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Równanie ma jeden pierwiastek podwójny: x = {0}", x);
            return (x, double.NaN);
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
            return (double.NaN, double.NaN);
        }
    }
}
