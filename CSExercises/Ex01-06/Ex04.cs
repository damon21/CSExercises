﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a double:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square root of {0} is {1}", x, Math.Sqrt(x));
        }
    }
}
