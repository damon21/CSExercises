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
            
            char[] A = {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
            int temp = i;
            string sum = "";
            do
            {
                sum =sum + A[temp % 16];
                temp = temp / 16;
            }
            while (temp > 0);
            char[] charArray = sum.ToCharArray();
            
                Array.Reverse(charArray);
            return new string(charArray);
        }
            
               

                
           



            
        }
    }

