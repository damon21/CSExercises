using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X \t Y \t");
            Console.WriteLine("------------");

            for (int x = -5; x <= 5; x++)
            {
                Console.Write("{0:0.0} \t", x);
                int y = 2 * x * x - 4 * x + 3;
                Console.Write("{0:0.0} \t\t", y);
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int x = -5; x <= 5; x++)
            {
                int y = 2 * x * x - 4 * x + 3;
                for (int i = 0; i <= y; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }







        }
    }
}
