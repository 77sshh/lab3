using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Для завершения работы программы введите 'стоп' ");
            Console.WriteLine("Для продолжения нажмите 'Enter' или введите любое сообщение");
            string input = Console.ReadLine();
            while (input != "стоп")
            {
                try
                {
                    Console.WriteLine("Введите значение радиуса");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите угол");
                    double angledegrees = double.Parse(Console.ReadLine());
                    double result = TRPO_Lab3.Lib.Class1.CircleSegment(radius, angledegrees);
                    Console.WriteLine("Результат: " + result);
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Для продолжения нажмите 'Enter' или введите любое сообщение");
                    Console.ReadLine();
                }
            }
        }
    }
}