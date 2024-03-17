using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Średnia: {Avg(numbers)}");
    }

    public static double Avg(int[] numbers)
    {
        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }
}