using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp5
{
    internal class Program
    {
        /// <summary>
        /// Определить статический метод int Centimeters (int m, int c); Task1
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    int m = InPut("Введите число метров: ");
        //    int c = InPut("Введите число сантиметров: ");
        //    int res = Centimeters(c, m);
        //    OutPut(res);
        //    Console.ReadKey();
        //}
        //static int Centimeters(int m, int c)
        //{
        //    return m * 100 + c;
        //}
        //static int InPut(string message)
        //{
        //    Console.Write(message);
        //    return int.Parse(Console.ReadLine());
        //}
        //static void OutPut(int res)
        //{
        //    Console.WriteLine($"Результат: {res} cм");
        //}


        /// <summary>
        /// Определить статический метод int Kop (int r, int k); Task2
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    int r = InPut("Введите число рублей: ");
        //    int k = InPut("Введите число копеек: ");
        //    int res = Kop(r, k);
        //    OutPut(res);
        //    Console.ReadKey();
        //}
        //static int Kop(int r, int k)
        //{
        //    return r * 100 + k;
        //}
        //static int InPut(string message)
        //{
        //    Console.Write(message);
        //    return int.Parse(Console.ReadLine());
        //}
        //static void OutPut(int res)
        //{
        //    Console.WriteLine($"Результат: {res}");
        //}

        /// <summary>
        /// Найти минимальное из трех целых чисел, используя вспомогательные методы; Task3
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    int a = InPut("Введите число 1: ");
        //    int b = InPut("Введите число 2: ");
        //    int c = InPut("Введите число 3: ");
        //    int res = Min(a,b,c);
        //    Output(res);
        //    Console.ReadKey();
        //}
        //static int Min(int a, int b, int c)
        //{
        //    return Math.Min(a, Math.Min(b, c));
        //}
        //static int InPut(string message)
        //{
        //    Console.Write(message);
        //    return int.Parse(Console.ReadLine());
        //}
        //static void Output(int res)
        //{
        //    Console.WriteLine($"Самое минимальное число: {res}");
        //}

        /// <summary>
        ///  Рассчитать значение z=min(2a,b+a)+min(2a-b,b); Task4
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    int a = InPut("Введите первое число: ");
        //    int b = InPut("Введите второе число: ");
        //    int z = Function(a, b);
        //    OutPut(z);
        //    Console.ReadKey();
        //}
        //static int Min(int a, int b)
        //{
        //    return (a<b)?a:b;
        //}
        //static int Function(int a, int b)
        //{
        //    return Min(2 * a, b + a) + Min(2*a - b, b);
        //}
        //static int InPut(string message)
        //{
        //    Console.Write(message);
        //    return int.Parse(Console.ReadLine());
        //}
        //static void OutPut(int z)
        //{
        //    Console.WriteLine($"z = {z}");
        //}

        /// <summary>
        ///  Рассчитать значение y, определив и используя статический метод; Task5
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"y = {Function(5) + Function(12) + Function(19):F2}");
        //    Console.ReadKey();
        //}
        //static double Function(int y)
        //{
        //    return (Math.Sqrt(y) + y) / 3;
        //}

        /// <summary>
        ///  Рассчитать значение y, определив и используя статический метод; Task6
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"{Function(15, 8) + Function(6, 12) + Function(7, 21):F2}");
        //    Console.ReadKey();
        //}
        //static double Function(int y, int x)
        //{
        //    return (y + Math.Sqrt(x)) / (x + Math.Sqrt(y));
        //}
    }
}
