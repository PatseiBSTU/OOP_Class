using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{

    //частичный статический класс
    static partial class Calculator
    {
        public static double pi = Math.PI;
        public static double Multiplication(double a, double b) => a * b;
        public static double Plus(double a, double b) => a + b;
        public static double Division(double a, double b) => a / b;
        public static double Minus(double a, double b) => a - b;

        public static int Random() => new Random().Next(100);
        //метод расшиирения
        public static bool IsLetter(this String st, char a)
        {
            for (Int32 index = 0; index < st.Length; index++)
                if (st[index] == a) return true;
            return false;
        }
      
        //метод расшиирения
        public static int CountLetter(this String st, char a)
        {
            int count = 0;
            for (Int32 index = 0; index < st.Length; index++)
                if (st[index] == a) count++;
            return count;
        }
    }
}
