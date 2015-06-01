namespace CalcTest2
{
    public class Calc
    {
        public static double Result1;
        public static double Result2;
        public static string Operation;

        public static void CopyResult()
        {
            Result2 = Result1;
        }
        public static void SetOperation(string value)
        {
            Calc.Operation = value;
        }
        public static double ClearResult()
        {
            return Result1 = 0;
        }

        public static double ReturnResult()
        {
            
            return Result1;
        }

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