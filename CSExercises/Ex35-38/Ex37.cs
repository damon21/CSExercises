using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            int i;
            string x, y,z;
            Console.Write("Enter a sentence/phrase: ");
            string a = Console.ReadLine();
            string[] A = a.Split(' ');
            
            for (i=0;i<=A.Length-1;i++)
            {
                 x = A[i].Substring(0, 1);
                 y = x.ToUpper();
                 z = y + A[i].Substring(1, A[i].Length - 1);
                 Console.Write(z+" ");
           }
            Console.WriteLine();
            


        }
    }
}
