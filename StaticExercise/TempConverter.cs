namespace StaticExercise;

 public static class TempConverter
{
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double conversion = (fahrenheit - 32) * 5 / 9;
        return (conversion);
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        double reverse = (celsius * 9 / 5) + 32;
        return reverse;
    }
}