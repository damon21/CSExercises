using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount(dollar.cents): ");
            double a = Convert.ToDouble(Console.ReadLine());
            int b = Convert.ToInt32(a * 100);
            int i;
            int n1 = b / 100;
            int n2 = (b / 10) - n1*10;
            int n3 = b - (n1 * 100 + n2 * 10);


            if (b % 5 != 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                for (i = 0; i < n1; i++)
                {
                    Console.WriteLine("100c");
                }

                if (n2 >= 5)
                {
                    for (i = 0; i < n2 / 5; i++)
                    {
                        Console.WriteLine("50c");
                    }
                }


                if ((n2 % 5) % 2 == 0)
                {
                    for (i = 0; i < (n2 % 5) / 2; i++)
                    {
                        Console.WriteLine("20c");
                    }
                }

                else
                {
                    if ((n2 % 5) > 2)
                    {
                        Console.WriteLine("20c");
                        Console.WriteLine("10c");
                    }
                    else
                        Console.WriteLine("10c");


                }



                if (n3 == 5)
                {
                    Console.WriteLine("5c");
                }
            }

            









        }



    }
}

