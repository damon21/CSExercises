using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            
            int[] sales = new int[12];
            int i, min, max, average;
            int sum = 0;
            

            for (i = 0; i < 12; i++)
            {
                Console.Write("Enter sales for month {0}: ", i+1);
                sales[i] = Convert.ToInt32(Console.ReadLine());
               
                
                sum = sum + sales[i];
            }
            average = sum / 12;
            min = 0;
            max = 0;


            for (i = 0; i < 12; i++)
            {
                if (sales[min] > sales[i])
                {
                    min = i;
                }
                if (sales[max] < sales[i])
                    max = i;
            }
            


            Console.WriteLine("Maximum Sales:{0}", max);
            Console.WriteLine("Minimum Sales:{0}", min);
            Console.WriteLine("Average Sales:{0}", average);
        }
    }


            



        }


