using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {

            int[,] A = new int[,]
            {
                {56,84,68,29},
                {94,73,31,89},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72},
           
            };

            int i, j;
            double total;



            for (i = 0; i < A.GetLength(0); i++)
            {
                total = 0;
                for (j = 0; j < A.GetLength(1); j++)
                {
                    total = total + A[i, j];
                }
                Console.WriteLine("total of student {0}: {1}", i + 1, total);

            }



            double average, x, variance, SD;
            double sum;



            for (j = 0; j < A.GetLength(1); j++)
            {
                sum = 0;
                for (i = 0; i < A.GetLength(0); i++)
                {
                    sum = sum + A[i, j];
                }

                average = sum / 12;

                Console.WriteLine("The class average of marks for subject {0}: {1:0.0}", j + 1, average);





                x = 0;

                for (i = 0; i < A.GetLength(0); i++)
                {
                    x = x + Math.Pow((A[i, j] - average), 2);//Math.Pow is for double.
                }

                variance = x / 12;
                SD = Math.Sqrt(variance);
                Console.WriteLine("The standard deviation of marks for subjuect {0}: {1:0.0}", j + 1, SD);
            }






                double overall = 0;
                for (i = 0; i < A.GetLength(0); i++)
                {


                    for (j = 0; j < A.GetLength(1); j++)
                    {

                        overall = overall + A[i, j];

                    }
                }

                double AVERAGE = overall / 48;
                Console.WriteLine("the overall average :{0:0.0}", AVERAGE);





            }
        }
    }

