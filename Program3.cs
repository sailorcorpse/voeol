//1.3/1

using System;
using System.IO;


class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\TTIT\input.txt");

        string[] selectedNumbersStr = lines[0].Split(' ');
        int[] selectedNumbers = Array.ConvertAll(selectedNumbersStr, int.Parse);

        int n = int.Parse(lines[1]);

        using (StreamWriter writer = new StreamWriter(@"C:\Users\TTIT\output.txt"))
        {
            for (int i = 2; i < n + 2; i++)
            {
                string[] ticketNumbersStr = lines[i].Split(' ');
                int[] ticketNumbers = Array.ConvertAll(ticketNumbersStr, int.Parse);

                int count = 0;
                foreach (int number in ticketNumbers)
                {
                    if (Array.Exists(selectedNumbers, x => x == number))
                    {
                        count++;
                        if (count >= 3)
                        {
                            break;
                        }
                            
                    }
                }
                if (count >= 3)
                {
                    writer.WriteLine("Lucky");
                }
                else
                {
                    writer.WriteLine("Unlucky");
                }
            }
        }
        Console.WriteLine("Готово! Результаты записаны в файл Output.txt.");
    }
}

//1.3/2

using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        string input = File.ReadAllText(@"C:\Users\public.COPP\nums.txt");
        int[] numbers = input.Split(new char[] { ' ', ',' }).Select(int.Parse).ToArray();

        int[] oddNumbers = numbers.Where(n => n % 2 != 0).ToArray();

        File.WriteAllText(@"C:\Users\public.COPP\nums.txt", string.Join(" ", oddNumbers));
    }
}

//1.3/3

using System;

class Program
{
    static void Main()
    {
        int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        int maxWater = MaxWaterContainer(heights);
        Console.WriteLine($"Максимальный объем воды: {maxWater}");
    }

    static int MaxWaterContainer(int[] height)
    {
        int maxWater = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int h = Math.Min(height[left], height[right]);
            int w = right - left;
            int currentWater = h * w;

            maxWater = Math.Max(maxWater, currentWater);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxWater;
    }
}
