//1.4/1

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        long result = CalculateProduct(n);

        Console.WriteLine($"Произведение натуральных чисел, кратных трём и не превышающих {n}, равно {result}");
    }

    static long CalculateProduct(int n)
    {
        long product = 1;

        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }

        return product;
    }
}

//1.4/2

using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = File.ReadAllText(@"C:\Users\public.COPP\numsTask2.txt");
        string[] elements = input.Split(';');
        
        double sumOfPositiveNumbers = 0;
        foreach (string element in elements)
        {
            double number = Convert.ToDouble(element);
            if (number <= 0)
            {
                break;
            }
            sumOfPositiveNumbers += (number > 0) ? number : 0;
        }
       
        File.WriteAllText(@"C:\Users\public.COPP\numsTask2.txt", sumOfPositiveNumbers.ToString());
    }
}

//1.4/3

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\public.COPP\numsTask3.txt");
        string[] nums = lines[0].Split(new char[] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
        int min, max;
        if (nums.Length > 0 && int.TryParse(nums[0], out int firstNumber))
        {
            min = firstNumber;
            max = firstNumber;

            foreach (var num in nums)
            {
                if (int.TryParse(num, out int currentNumber))
                {
                    if (currentNumber == 0)
                    {
                        break;
                    }

                    if (currentNumber < min)
                    {
                        min = currentNumber;
                    }

                    if (currentNumber > max)
                    {
                        max = currentNumber;
                    }
                }

            }

            double result = (double)min / max;
            Console.WriteLine($"Отношение минимального и максимального элементов: {result}");
        }

    }
}

//1.4/4

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\public.COPP\numsTask4.txt");
        string[] nums = lines[0].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (int.Parse(nums[i]) == int.Parse(nums[i + 1]) - 1)
            {
                count++;
            }
        }
        File.WriteAllText(@"C:\Users\public.COPP\numsTask4.txt", count.ToString());
    }
}


    
    