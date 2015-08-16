using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the salary:");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The total income:{1}", salary, salary * 1.13);

        }
    }
}
