// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");
static double GetAverage(int[] numbers)
{
    double result2 = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result2 += numbers[i];
    }

    return result2 / numbers.Length;
}
static double GetMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max) max = numbers[i];
    }
    return max;
}


int[] numbers = { 1, 2, 3, 4 };
double average = GetAverage(numbers);
Console.WriteLine(average);
Console.WriteLine(GetMax(numbers));





