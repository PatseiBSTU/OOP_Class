using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" x = " + x);
            Console.WriteLine(" y = " + y);
            Console.WriteLine("Сложение   " + Calculator.Plus(x, y));
            Console.WriteLine("Умножение   " + Calculator.Multiplication(x, y));
            Console.WriteLine("Вычитание   " + Calculator.Minus(x, y));
            y = Calculator.pi;
            Console.WriteLine(" y = " + y);
            Console.WriteLine("Деление   " + Calculator.Division(x, y));
            String oop = "Объектно-ориентированное программровнаие";
            char letter = 'о';
             if (   oop.IsLetter(letter) )
                Console.WriteLine(letter + " " + "встрсяечает в строке " + oop.CountLetter(letter) +  "  раз ") ;
             else
                Console.WriteLine(letter + " " + "нет в строке");
            Console.WriteLine("Синус   " + String.Format("{0:0.00}", Calculator.Sin(x)));
            Console.WriteLine("Косинус   " + String.Format("{0:0.00}", Calculator.Cos(x)));
            Console.WriteLine("Тангенс   " + String.Format("{0:0.00}", Calculator.Tan(x)));

            //анонимный тип
            var student = new { Id =  Guid.NewGuid() , course = "4" };
            Console.WriteLine(student.Id + "   "  +  student.course);

        }
    }
}
