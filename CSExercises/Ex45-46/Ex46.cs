using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Part1");
            Console.WriteLine("Number \t Count");

            int[] a = new int[10];
            Random r = new Random();
            
            for (int i = 0; i < 50; i++)
            {
                int N = r.Next(0, 10);
                a[N]= a[N]+1;
            }
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("{0} \t {1}", j, a[j]);
            }
            Console.WriteLine();



            Console.WriteLine("Part 2");
            Console.WriteLine("Number");

            for ( int i=0;i<10;i++)
            {
                Console.Write(i + "\t");
                for(int j=0;j<a[i];j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();





        }
    }
}
