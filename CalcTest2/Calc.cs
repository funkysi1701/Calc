namespace CalcTest2
{
    public class Calc
    {
        public static double Addition(double value1, double value2)
        {
            return value1 + value2;
        }

        public static double Subtraction(double value1, double value2)
        {
            return value1 - value2;
        }

        public static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        public static double Divide(double value1, double value2)
        {
            return value1 / value2;
        }

        public static double SquareRoot(double value1)
        {
            return System.Math.Sqrt(value1);
        }

        public static double Square(double value1)
        {
            return value1 * value1;
        }

        public static double ChangeSign(double value1)
        {
            return -1 * value1;
        }
    }
}