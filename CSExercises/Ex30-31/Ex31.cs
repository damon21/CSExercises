using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int N;
            int i;

            for (N = 1; N <= 1000; N++)
            {
                int sum = 0;
                for ( i = 1; i < N; i++)
                {
                    sum = sum + i;

                    if (sum == N)
                    {
                        Console.Write("{0} \t", sum);
                        break;
                    }
                }
            }
        }
    }
}
  