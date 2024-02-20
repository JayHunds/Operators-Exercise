namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
        var a = 17;
        var b = 4;
        var quotient = a / (double)b;
        var remainder = a % b;
        int sum = a + b;
        int product = a * b;
        int difference = a - b;

        Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

        Console.WriteLine("Please enter the radius of your circle:");
        var userInput = Console.ReadLine();

        var radius = double.Parse(userInput);

        Console.WriteLine($"Area of circle with radius {radius} is {AreaOfCircle(radius)}");
    }

    public static double AreaOfCircle(double radius)
    {
        var area = Math.PI * Math.Pow(radius, 2);
        return area;
        }
    }
}
