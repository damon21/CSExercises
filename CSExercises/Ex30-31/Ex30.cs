using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int N;


            for (N = 5; N <= 10000; N++)
            {
                int count = 0;

                for (int i = 2; i <= N; i++)
                {


                    if (N % i == 0)
                    {

                        count++;
                    }


                }


                if (count == 1)
                    Console.Write("{0} \t", N);
            }
                
                

                
                
                    
                
             
           


            } 
        }
    }

