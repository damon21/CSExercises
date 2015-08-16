namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int x;
            int y, z = 0;
            System.Console.Write("Enter a three-digit integer: ");
            x = System.Convert.ToInt32(System.Console.ReadLine());

            for (int i = x; i > 0; i = i / 10)
            {
                y = i % 10;
                z = z + y * y * y;

            }

            if (z == x)
                System.Console.WriteLine("This is Armstrong Number");
            else
                System.Console.WriteLine("Sorry, this is not Armstrong Number");
              

            }
        }
    }