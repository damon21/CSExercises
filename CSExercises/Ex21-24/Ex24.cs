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
            Console.Write("Enter an integer: ");
            N = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int G = r.Next(1, N+1);
            Console.WriteLine("The random number is " + G);
            
            double C = Convert.ToDouble(N);
            double D = Convert.ToDouble(G);
            double square = D * D;
            
            while(square != C)
            {
                D= (D + C / D) / 2;
                square = Math.Round(D * D, 5);
                D = Math.Round(D, 5);

                
                Console.WriteLine("The square root: {0}", D);

            
                
                    
                
                    
                    
          }
            
            
            
            
           

            
            

        }
    }
}
