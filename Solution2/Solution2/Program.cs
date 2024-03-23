// See https://aka.ms/new-console-template for more information

public class AverageCalculator
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The array cannot be null or empty.");
        }

        int sum = 0;
        foreach (int nume in numbers)
        {
            sum += nume;
        }

        return (double)sum / numbers.Length;
    }
}