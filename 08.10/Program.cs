using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое значение: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Введите второе знаечние: ");
            int second = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Выберите действие: \n 1. Сложение \n 2. вычитание  \n 3. умножение \n 4. деление");
            int three = int.Parse(Console.ReadLine());
            switch(three)
            {
                case 1:
                    Console.WriteLine("Результат: " + Addition(first, second));
                    break;
                case 2:
                    Console.WriteLine("Результат: " + Subtraction(first, second));
                    break;
                case 3:
                    Console.WriteLine("Результат: " + Multiplication(first, second));
                    break;
                case 4:
                    Console.WriteLine("Результат: " + Division(first, second));
                    break;
                default:
                    Console.WriteLine("Вы ввели неверное значение!");
                    break;
            }
                Console.ReadKey();
        }
        public static int Addition( int one, int two)
        {
            return one + two;
        }
        public static int Subtraction(int three, int four)
        {
            return three - four;
        }
        public static int Multiplication(int five, int six)
        {
            return five * six;
        }
        public static double Division( int seven, int eight)
        {
            if (eight != 0)
            {
                return seven / eight;
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя!");
                return eight;
            }
        }
    }
}
