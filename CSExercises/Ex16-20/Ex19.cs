using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("The distance(km) is ");
            double distance = Convert.ToDouble(Console.ReadLine());
            distance = Math.Ceiling(distance * 10) / 10;
            double a = (distance - 9) * 10 * 0.05;
            double b = 8.5 * 10 * 0.04;
            double c = (distance - 0.5) * 10 * 0.04;
            double d = 2.40;
            if(distance >9)
            {
                Console.WriteLine("The cost is ${0:0.00}", a + b + d);

            }
            if (distance > 0.5 && distance <= 9)
            {
                Console.WriteLine("The cost is ${0:0.00}", d + c);
            }
     
            if (distance <= 0.5)
            {
                Console.WriteLine("The cost is ${0:0.00}", d);
            }
                
        }
    }
}