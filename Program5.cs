//1.5/1

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\public.COPP\numsTask1.txt");
        string[] nums = lines[0].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int minIndex = 0;
        int min = int.Parse(nums[0]);
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (int.Parse(nums[i]) < min)
            {
                min = int.Parse(nums[i]);
                minIndex = i; 
            }
        }

        long product = 1;
        for (int i = minIndex + 1; i < nums.Length; i++)
        {
            product *= int.Parse(nums[i]);
        }
        File.WriteAllText(@"C:\Users\public.COPP\numsTask1.txt", product.ToString());
    }
}

//1.5/2

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\public.COPP\numsTask2.txt");
        string[] nums = lines[0].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        double[] doubleArray = Array.ConvertAll(nums, s => double.Parse(s));
        Array.Sort(doubleArray);

        string sortedNumbers = string.Join(";", doubleArray.Select(d => d.ToString()));
        
        File.WriteAllText(@"C:\Users\public.COPP\numsTask2.txt", sortedNumbers.ToString());
    }
}

//1.5/3

using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\TTIT\numsTask3.txt";
        string[] lines = File.ReadAllLines(filePath);
        string[] nums = lines[0].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = Array.ConvertAll(nums, int.Parse);

        int minIndex = Array.IndexOf(numbers, numbers.Min());

        double average = 0;
        for (int i = 0; i < minIndex; i++)
        {
            average += numbers[i];
        }
        average /= minIndex;

        Console.WriteLine("Среднее арифметическое элементов до минимального: " + average);
    }
}


//1.5/4

using System;
using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\TTIT\numsTask4.txt";
        string[] lines = File.ReadAllLines(filePath);
        int[] numbers = lines[0].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int max = numbers.Max();
        int sum = 0;

        foreach (int num in numbers)
        {
            if (Math.Abs(num - max) == 1)
            {
                sum += num;
            }
        }

        File.WriteAllText(@"C:\Users\TTIT\numsTask4.txt", sum.ToString());
    }
}

//1.5/5

using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\TTIT\numsTask5.txt";
        string[] lines = File.ReadAllLines(filePath);
        int[] numbers = lines[0].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int minIndex = Array.IndexOf(numbers, numbers.Min());
        int maxIndex = Array.IndexOf(numbers, numbers.Max());

        int start = Math.Min(minIndex, maxIndex) + 1;
        int end = Math.Max(minIndex, maxIndex);
        int sum = 0;
        int count = 0;

        for (int i = start; i < end; i++)
        {
            sum += numbers[i];
            count++;
        }

        double average = count > 0 ? (double)sum / count : 0.0;

        File.WriteAllText(filePath, average.ToString());
    }
}
