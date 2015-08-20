using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            int[] N = new int[5] { 63, 29, 75, 82, 55 };

            string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };

            Console.WriteLine("Name \tmark");

            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(name[i] + " \t" + N[i]);
            }
            Console.WriteLine();




            Console.WriteLine("First report Sorted in secending order of the Marks:");
            int green, red;

            for (green=0; green<N.Length-1; green++)
            {
                for( red = green+1;red < N.Length;red++)
                {
                    if(N[green]<N[red])
                    {
                        int tmp = N[green];
                        N[green] = N[red];
                        N[red] = tmp;

                    }
                }
                
             
            }

            for (i=0; i<N.Length;i++)
            {
                Console.Write(N[i]+"\t");
            }
            Console.WriteLine("\n");
            




            Console.WriteLine("Second report sorted on student names alphabetically:");
            for (green = 0; green < name.Length - 1; green++)
            {
                for (red = green+1; red < name.Length; red++)
                {
                    if (name[green].CompareTo(name[red]) > 0)
                    {
                        string TMP = name[green];
                        name[green] = name[red];
                        name[red] = TMP;

                    }
                }
            }

            for (i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + "\t");
            }
            Console.WriteLine("\n");






        }











    }
        }

