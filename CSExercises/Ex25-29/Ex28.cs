using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            
            int count = 0;



            for (int i = 2; i <= N; i++)
            {
                
                if ( N % i == 0)
                {
                    count++;

                }
            }

            if (count == 1)
                Console.WriteLine("This is a prime number");
            else
                Console.WriteLine("This is not a prime number");
                    
                
                
                             
            }
        }
    }

