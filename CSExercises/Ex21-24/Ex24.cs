using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            int N;
            Console.Write("Enter a number: ");
            N = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int G = r.Next(1, N + 1);
            Console.WriteLine("The guess number is {0}",G);
            

            double A = Convert.ToDouble(N);
            double B = Convert.ToDouble(G);
            double square = B * B;

            while (square != N)
            {
                B = (B + A / B) / 2;
                square = Math.Round(B * B, 5);
                B = Math.Round(B, 5);
                Console.WriteLine("The square root of {0} : {1}", N,B);
            }
            












        }
    }
}
