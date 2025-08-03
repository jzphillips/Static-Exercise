namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number below.");
            double x =  double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter another.");
            double y = double.Parse(Console.ReadLine());
            
            Console.WriteLine(TempConverter.FahrenheitToCelsius(x));
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(y));
        }
    }
}
