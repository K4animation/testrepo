using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wpisz wartości a, b oraz c w równaniu kwadratowym ax^2 + b + c\n");
        
        Console.Write("Podaj wartość a = ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wartość b = ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wartość c = ");
        double c = Convert.ToDouble(Console.ReadLine());

        Pierwiastki.ObliczPierwiastki(a, b, c);

        Console.ReadKey();
    }
}
