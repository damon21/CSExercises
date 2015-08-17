using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int factorial;
            int num = 1;
            Console.Write("Enter a number: ");
            bool res = Int32.TryParse(Console.ReadLine(), out factorial);

            if(res == true)
            {
                for (int i = 1; i <= factorial; i++)
                {
                    num = num * i;
                    if (i != factorial)
                        Console.Write(i + "*");
                    else
                        Console.Write(i);
                }
                Console.WriteLine("=" + num);


                num = 1;
                for (int i = factorial; i > 0; i--)
                {
                    num = num * i;
                    if (i != 1)
                        Console.Write(i + "*");
                    else
                        Console.Write(i);
                }
                Console.WriteLine("=" + num);


            }
        }
    }
}
