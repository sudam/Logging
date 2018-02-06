using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingDemo
{
    class Program
    {
        static double SafeDivision(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
                throw new System.DivideByZeroException();
            return firstNumber / secondNumber;
        }

        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double result;

            try
            {
                result = SafeDivision(firstNumber, secondNumber);
                Console.WriteLine("Result: {0}", result);
                Console.ReadKey();
            }
            catch (DivideByZeroException e)
            {
                Log.Error("Attempted divide by Zero.");
            }
        }
    }
}
