using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            int i;
            Console.Write("Please enter a phrase: ");
            string a = Console.ReadLine();

            int sum = 0;
            for (i=0;i<a.Length;i++)
            {
                if (a[i]=='a'||a[i]=='e'||a[i]=='i'||a[i]=='o'||a[i]=='u')
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine("Total number of vowels: {0}", sum);

            int A = 0, E = 0, I = 0, O = 0, U = 0;
            for (i=0;i<a.Length;i++)
            {
                
                if(a[i]=='a')
                {
                    A = A + 1;
                }
                
                if(a[i]=='e')
                {
                    E = E + 1;
                }
                
                if(a[i]=='i')
                {
                    I = I + 1;
                }
                
                if(a[i]=='o')
                {
                    O = O + 1;
                }
                
                if(a[i]=='u')
                {
                    U = U + 1;
                }
                


            }
            Console.WriteLine("Number of a:{0}", A);
            Console.WriteLine("Number of e:{0}", E);
            Console.WriteLine("Number of i:{0}", I);
            Console.WriteLine("Number of o:{0}", O);
            Console.WriteLine("Number of u:{0}", U);




            
            

            

           
            
            

           




            



        }
    }
}
