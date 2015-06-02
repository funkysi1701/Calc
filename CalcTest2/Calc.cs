using System.Collections.Generic;
using System.Collections;
using System;

namespace CalcTest2
{
    public class Calc
    {
        
        public static ArrayList Result;
        public static string Operation;
        public static string Screen;

        public static void CreateResult()
        {
            Result = new ArrayList();
        }

        public static void SetOperation(string value)
        {
            Calc.Operation = value;
        }
        public static string ClearResult()
        {
            return "0";
        }

        public static void Evaluate(double value1, double value2)
        {
            if (Calc.Operation == "+")
            {

                Calc.Result.Add(Calc.Addition(value2, value1));

            }
            if (Calc.Operation == "-")
            {

                Calc.Result.Add(Calc.Subtraction(value2, value1));
            }
            if (Calc.Operation == "*")
            {

                Calc.Result.Add(Calc.Multiply(value2, value1));
            }
            if (Calc.Operation == "/")
            {

                Calc.Result.Add(Calc.Divide(value2, value1));
            }
        }
        public static string ReturnResult()
        {
            return Result[Result.Count - 1].ToString();
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