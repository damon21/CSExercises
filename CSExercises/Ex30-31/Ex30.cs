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
            int i;

            for ( N=5; N<=10000; N++)
            {
                for (i = 2; i <= N; i++)
                {
                    if (N % i == 0)
                        break;
                }

                if (N == i)
                    Console.Write("{0} \t", i);
                
                    
                }
                
                

                
                
                    
                
             
           


            } 
        }
    }

