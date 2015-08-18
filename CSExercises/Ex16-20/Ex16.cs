namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Your name: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Your gender(M or F): ");
            string gender = System.Console.ReadLine();
            

            
            if( gender == "M")
            {
                System.Console.WriteLine("Good Morning Mr {0}", name);
            }
            if (gender == "F")
            {
                System.Console.WriteLine("Good Morning Ms {0}", name);
            }
        }
    }
}