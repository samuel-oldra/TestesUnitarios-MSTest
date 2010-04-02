using System;

namespace ProjetoExemplo
{
    public class FuncMath
    {
        #region Public Methods

        public static int Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }

        public static int Soma(int a, int b)
        {
            return a + b;
        }

        public static double Soma(double a, double b)
        {
            return a + b;
        }

        #endregion Public Methods
    }
}