using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
           

           int i,green, red;

            for (green=0; green<A.Length-1; green++)
            {
                for (red=green+1; red<A.Length; red++)
                {
                    if(A[green] > A[red])
                    {
                        int x = A[red];
                        A[red] = A[green];
                        A[green] = x;
                    }


                }

                for (i = A.Length - 1; i >= 0; i--)
                {
                    Console.Write("{0} \t", A[i]);
                }
                Console.WriteLine();
               
            }
           ;

        }
    }
}
