using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double minimum = 2.4;
            double fare = minimum + distance * 0.4;
            Console.WriteLine("The total fare:{0}", Math.Ceiling(fare));
        }
    }
    }
