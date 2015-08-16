using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square root of {0} is {1}", x, Math.Sqrt(x));
        }
    }
}
