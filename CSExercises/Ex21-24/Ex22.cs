using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A, B, C, HCF, LCM;


            Console.Write("Enter A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            B = Convert.ToInt32(Console.ReadLine());
           

            C = (A * B);

            do
            {
                if (A > B)
                {
                    A = A - B;
                }
                else
                {
                    B = B - A;
                }


                if (A == B)
                {
                    
                        HCF = A;
                    
                        Console.WriteLine("HCF: {0}", HCF);
                        LCM = C / HCF;
                        Console.WriteLine("LCM: {0}", LCM);
                    
                }
            } while (A != B);
        }
    }
}



                