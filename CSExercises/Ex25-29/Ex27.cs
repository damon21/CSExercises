using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X \t Y \t");
            Console.WriteLine("------------");
            
            for ( int x = 1; x <=20; x++)
            {
                Console.Write("{0:0.0} \t", x);
                Console.Write("{0:0.0} \t\t", 2 * x * x - 4 * x + 3);
                Console.WriteLine();
            }
            
        
        }
    }
}
