using System;

class Program
{
    static void Main()
    {
        int[] array1 = RandomArray(10);
        int[] array2 = RandomArray(10);
        int[] array3 = RandomArray(10);

        Console.WriteLine("Сумма первого массива: " + Sum(array1));
        Console.WriteLine("Сумма второго массива: " + Sum(array2));
        Console.WriteLine("Сумма третьего массива: " + Sum(array3));
    }

    static int[] RandomArray(int n)
    {
        Random rand = new Random();
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(0, 51);
        }
        return array;
    }

    static int Sum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }
}
