using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int x = 88;
            int guess;

            do
            {
                Console.Write("Enter an integer: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == x)
                {
                    Console.WriteLine("Lucky  you");
                }
                else
                    Console.WriteLine("Enter again");
            }
            while (guess != x);
          
            


        }
    }
}
