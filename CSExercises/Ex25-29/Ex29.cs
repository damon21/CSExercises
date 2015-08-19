using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < N; i++)
            {
                if (N % i == 0)
                    sum = sum + i;
            }

            if (sum == N)
                Console.WriteLine("This is a perfect number");
            else
                Console.WriteLine("This is not a perfect number");
            
                
            }
        }
    }

