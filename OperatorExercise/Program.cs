namespace OperatorExercise
{
    public class Program
    {

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static void Main(string[] args)
        {
            //Exercise 1
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            
            int division = a / b;
            int modulus = a % b;
            
            Console.WriteLine($"{a}/{b} is {division} remainder {modulus}");
            
            //Exercise 2
            Console.WriteLine("Input the radius of a circle:");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of the circle with radius of {radius} is {area}");
        }
    }
}
