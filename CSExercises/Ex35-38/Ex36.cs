using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a word/phrase: ");
            string a = Console.ReadLine();
            int i;
            
            if(a.Length % 2==0)
            {
                
                
                for(i=0;i <=(a.Length/2);i++)
                {
                    if (a[i] != a[(a.Length-1) - i])
                    {
                        Console.WriteLine("Not Palindrome");
                        break;
                    }
                    
                    if(i==a.Length/2)
                        Console.WriteLine("Palindrome");
  
                }
               
                
            }
           
            
            
            if(a.Length % 2!=0)
            {
                

                for(i=0;i<=((a.Length-1)/2);i++)
                {
                    
                    if (a[i] != a[(a.Length - 1) - i])
                    {
                        Console.WriteLine("Not Palindrome");
                        break;
                    }

                    if(i==(a.Length-1)/2)
                    
                        Console.WriteLine("Palindrome");
  

                    
                   

                }
                
                




                    

                }
           }

            
            

            
            


        }
    }
