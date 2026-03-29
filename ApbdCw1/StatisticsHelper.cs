namespace ApbdCw1;

public class StatisticsHelper
{
public static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        return 0;
    
    double sum = 0;
    foreach (var num in numbers)
        sum += num;
    return sum / numbers.Length;
}

public static int CalculateMax(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        throw new ArgumentException("Array cannot be empty");
    int max = numbers[0];
    foreach (int num in numbers)
        if (num > max) max = num;
    return max;
}
public static int CalculateMin(int[] numbers)
{
    throw new NotImplementedException();
}

} 
