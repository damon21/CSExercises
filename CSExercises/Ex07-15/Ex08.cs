using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a temperature in Centigrade scale:");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tenmperature in Fahrenheit:{1}", C, 1.8 * C + 32);
        }
    }
}
