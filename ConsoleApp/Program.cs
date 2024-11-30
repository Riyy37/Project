using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        //Task1

        //static void Main(string[] args)
        //{
        //    SayHello();
        //    SayBye();
        //    Console.Read();
        //}
        //public static void SayHello()
        //{
        //    Console.WriteLine("Hello");
        //}
        //public static void SayBye()
        //{
        //    Console.WriteLine("Bye");
        //}


        //Task2

        //static int TwoNum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //static void Main()
        //{
        //    Console.Write("Введите первое число: ");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Введите второе число: ");
        //    int num2 = Convert.ToInt32(Console.ReadLine());
        //    int sum = TwoNum(num1, num2);
        //    Console.WriteLine("Сумма двух чисел: " + sum);
        //    Console.ReadLine();
        //}


        //Task3

        //static double MathFunction(double a)
        //{
        //    return 12 * Math.Pow(a, 2) + 7 * a - 6;
        //}
        //static void Main()
        //{
        //    Console.Write("Введите значение а: ");
        //    double a = Convert.ToDouble(Console.ReadLine());
        //    double b = MathFunction(a);
        //    Console.WriteLine($"При значении а = {a} равно b = {b}");
        //    Console.ReadLine();
        //}


        //Task4

        //static int Plus(int num1, int num2)
        //{
        //    return num1 + num2;
        //}
        //static int Minus(int num1, int num2)
        //{
        //    return num1 - num2;
        //}

        //static int Multiply(int num1, int num2)
        //{
        //    return (num1 * num2);
        //}

        //static double Divide(int num1, int num2)
        //{
        //    if (num2 == 0)
        //    {
        //        Console.WriteLine("Частное значений равно: Нельзя делить на ноль!");
        //        return double.NaN;
        //    }
        //    if (num1 == 0)
        //    {
        //        Console.WriteLine("Частное значений равно: Нельзя делить на ноль!");
        //        return double.NaN;
        //    }
        //     return (double)num1 / num2;

        //}

        //static void Main()
        //{
        //    Console.Write("Введите первое значение: ");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Введите второе значение: ");
        //    int num2 = Convert.ToInt32(Console.ReadLine());

        //    int sum = Plus(num1, num2);
        //    int ras = Minus(num1, num2);
        //    int umn = Multiply(num1, num2);
        //    double del = Divide(num1, num2);

        //    Console.WriteLine($"Сумма значений равна: {sum}");
        //    Console.WriteLine($"Разность значений равна: {ras}");
        //    Console.WriteLine($"Произведение значений равно: {umn}");

        //    if (!double.IsNaN(del))
        //    {
        //        Console.WriteLine($"Частное значений равно: {del}");
        //    }



        //    Console.ReadLine();

        //}


        //Task5

        //static double F(double x1, double y1, double x2, double y2)
        //{
        //    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        //}
        //static double D(double a, double b, double c)
        //{
        //    return a + b + c;
        //}

        //static void Main()
        //{
        //    Console.Write("Введите координаты первой точки: ");
        //    double x1=Convert.ToDouble(Console.ReadLine());

        //    double y1 = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Введите координаты второй точки: ");
        //    double x2 = Convert.ToDouble(Console.ReadLine());

        //    double y2 = Convert.ToDouble(Console.ReadLine());
        //    double res = F(x1,y1,x2,y2);
        //    Console.WriteLine($"Длина отрезка равна: {res:F2}");

        //    Console.WriteLine("------");

        //    Console.Write("Введите первую сторону треугольника: ");
        //    double side1 = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Введите вторую сторону треугольника: ");
        //    double side2 = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Введите третью сторону треугольника: ");
        //    double side3 = Convert.ToDouble(Console.ReadLine());
        //    double perimetr = D(side1, side2, side3);
        //    Console.WriteLine($"Периметр треугольника равен: {perimetr}");

        //    Console.ReadLine();

        //}


    }


}



