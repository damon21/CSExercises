using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter four real values :");
            Console.Write("x1= ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1= ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2= ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2= ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double a = x2 - x1;
            double b = y2 - y1;
            double c = Math.Pow(a, 2);
            double d = Math.Pow(b, 2);
            Console.WriteLine("Using distance= square root of [(x2-x1)^2+(y2-y1)^2]");
            Console.WriteLine("distance= square root of {0}+{1}=  {2}", c, d, Math.Sqrt(c + d));
            


        }
    }
}
