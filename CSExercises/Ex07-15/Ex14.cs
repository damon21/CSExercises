namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c;
            double area;
            System.Console.WriteLine("Enter the lengths of a trianglle's three sides: ");
            System.Console.Write("side a= ");
            a = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("side b= ");
            b = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("side c= ");
            c = System.Convert.ToDouble(System.Console.ReadLine());
            double s = (a + b + c) / 2;
            area = System.Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            System.Console.WriteLine("AREA = squareroot({0}*{1}*{2}*{3}) = {4})", s, s - a, s - b, s - c, area);
        }
    }
}