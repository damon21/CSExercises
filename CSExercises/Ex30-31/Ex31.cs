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

            Console.WriteLine("Perfect number(1-1000): ");
            
            for (N = 1; N <= 1000; N++)
            {
                int sum = 0;

                for (int i = 1; i < N; i++)
                {
                    if (N % i == 0)
                        sum = sum + i;
                }


                if (sum == N)
                    Console.WriteLine("{0} \t", N);
            }
            
                }
            }
        }
   
  