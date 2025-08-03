namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fahrenheit temperature.");
            double x =  double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Celsius temperature.");
            double y = double.Parse(Console.ReadLine());
            
            Console.WriteLine(TempConverter.FahrenheitToCelsius(x));
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(y));
        }
    }
}
