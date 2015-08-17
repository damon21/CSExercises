using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();

            int secretNumber = r.Next(0, 10);
            int guess;
            int count = 0;

            do
            {
                count++;

                Console.Write("Enter your guess(0-9): ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)

                {
                    if (count <= 2)
                        Console.WriteLine("You are a Wizard");
                    else if (count > 2 && count <= 5)
                        Console.WriteLine("You are a good guess");
                    else
                        Console.WriteLine("You are lousy");
                }
                else
                    Console.WriteLine("Try again");
            } while (guess != secretNumber);
            


            
        }
    }
}
