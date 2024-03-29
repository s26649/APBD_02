﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Średnia: " + Avg(numbers));
    }

    public static double Avg(int[] numbers)
    {
        double suma = 0;
        foreach (int num in numbers)
        {
            suma += number;
        }
        return suma / numbers.Length;
    }
    
    public static int Max(int[] numbers)
    {
        int maxValue = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxValue)
                maxValue = number;
        }
        return maxValue;
    }
}