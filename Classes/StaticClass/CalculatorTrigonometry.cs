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
        #region Trigonometry
        public static double Sin(double a) => Math.Sin(a);
        public static double Cos(double a) => Math.Cos(a);
        public static double Tan(double a) => Math.Tan(a);
        #endregion
    }
}
