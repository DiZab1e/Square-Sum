using System;
public static class Kata
{
    public static int SquareSum(int[] numbers)
    {
        var total = 0;
        for (var i = 0; i < numbers.Length; i++)
        {
            total += numbers[i] * numbers[i];
        }
        return total;
    }
}