// See https://aka.ms/new-console-template for more information

public class AverageCalculator
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The array cannot be null OR empty.");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
}

public static class Program
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Average: {AverageCalculator.CalculateAverage(array)}");
        Console.WriteLine($"Max value: {FindMaxValue(array)}");
    }

    public static int FindMaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The array is either null or empty.");
        }

        int max = numbers[0]; // Initialize max with the first element of the array

        // Iterate through the array to find the maximum value
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }
}
