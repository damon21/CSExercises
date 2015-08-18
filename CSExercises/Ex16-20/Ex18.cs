using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your marks: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x>=80 && x<100)
            {
                Console.WriteLine("You scored {0} marks which is A grade", x);
            }
            else  if (x >= 60 && x < 80)
            {
                Console.WriteLine("You scored {0} marks which is B grade", x);
            }
            else if (x >= 40 && x < 60)
            {
                Console.WriteLine("You scored {0} marks which is C grade", x);
            }
            else if (x >= 0 && x < 40)
            {
                Console.WriteLine("You scored {0} marks which is F grade", x);
            }
            else
                Console.WriteLine("Error");
        }
    }
}