using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Integer \t Square roots of integer");
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(i + "\t\t" + SQT(i));
            }
        }

        public static double SQT(int y)
        {
            double a;
            a = Math.Round(Math.Sqrt(y), 2);
            return a;

        }
    }



}
