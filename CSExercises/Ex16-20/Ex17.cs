namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Your name: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Your gender(M or F): ");
            string gender = System.Console.ReadLine();
            System.Console.Write("Your age: ");
            int age = System.Convert.ToInt32(System.Console.ReadLine());

            if (gender == "M")
            {
                if (age >= 40)
                {
                    System.Console.WriteLine("Good Morning Uncle {0}", name);
                }
                else
                    System.Console.WriteLine("Good Morning Mr {0}", name);
            }



            if (gender == "F")
            {
                if (age >= 40)
                {
                    System.Console.WriteLine("Good Morning Aunty {0}", name);
                }
                else
                    System.Console.WriteLine("Good Morning Ms {0}", name);

            }
        }
    }
}