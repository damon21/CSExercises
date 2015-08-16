using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the value of X :");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Using the formula: y = 2X^2-4X+3");
            double a = Math.Pow(X, 2);
            double b = 4 * X;
            Console.WriteLine("The value of y = 2*X^2-4*X+3={0}-{1}+3={2}", 2*a,b,2*a-b+3);
        }
    }
}
