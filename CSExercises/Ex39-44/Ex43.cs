using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex43
    {

        public static void Main(string[] args)
        {

            for (int A=1; A<=100; A++)
            {
                Console.WriteLine("The hexadecimal of {0} is {1}", A, Hex(A));
            }
        }








        public static string Hex(int i)
        {
            int sum = 0;
            int x = 0;
            while (i>=1)
            {
                sum = sum + (i % 2) * (int)Math.Pow(10, x);
                x++;

                i = i / 2;
            }
            string SUM = Convert.ToString(sum);

            return SUM;
            



            
        }
    }
}
