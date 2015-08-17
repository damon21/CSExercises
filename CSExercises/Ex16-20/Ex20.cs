using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter quantity for TV: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int total = 900*x + 500*y + 700*z;

            if (total >10000)
            {
                Console.WriteLine("Total price for this order is {0}", (900 * x + 500 * y) * 0.85 + 700 * z);
            }
            if (total >5000 && total <10000)
            {
                Console.WriteLine("Total price for this order is {0}", (900 * x + 500 * y) * 0.9 + 700 * z);
            }
            if (total <5000)
            {
                Console.WriteLine("Total price for this order is {0}", total);
            }

        }
    }
}