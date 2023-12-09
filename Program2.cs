//1.2/1
using System;

class Program 
{
    static void Main() 
    {
        int[] descendingArray = new int[100];
        descendingArray[0] = 300;
        
        for (int i = 1; i < 100; i++) 
        {
            descendingArray[i] = descendingArray[i - 1] - 3; 
        }
        
        Console.WriteLine("Нисходящий массив:");
        foreach (var number in descendingArray) 
        {
            Console.WriteLine(number + " ");
        }
      
    }
}

//1.2/2

using System;

class Program 
{
    static void Main() 
    {
        int[] oddNumbersArray = new int[100];
        int currentNumber = 1;
        
        for (int i = 0; i < 100; i++) 
        {
            oddNumbersArray[i] = currentNumber;
            currentNumber += 2;
        }
        
        Console.WriteLine("Массив нечетных чисел:");
        foreach (var number in oddNumbersArray) 
        {
            Console.WriteLine(number + " ");
        }
      
    }
}

//1.2/3

using System;

class Program 
{
    static void Main() 
    {
        int n = 5;
        int[,] matrix = new int[n, n];
        
        for (int i = 0; i < n; i++) 
        {
            matrix[0, i] = 1;
            matrix[i, 0] = 1;
        }
        
        for (int i = 1; i < n; i++) 
        {
            for (int j = 1; j < n; j++) 
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }
        
        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        
    }
}

//1.2/4

using System; 
using System.Collections.Generic; 
using System.Linq; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        int[,] temperature = new int[12, 30]; 
        Random random = new Random(); 
 
        for (int month = 0; month < 12; month++) 
        { 
            for (int day = 0; day < 30; day++) 
            { 
                if (month == 0 || month == 1 || month == 10 || month == 11)  
                { 
                    temperature[month, day] = random.Next(-20, 0); 
                } 
                else 
                { 
                    temperature[month, day] = random.Next(0, 40); 
                } 
            } 
        } 
 
        int[] averageTemperatures = CalculateAverageTemperatures(temperature); 
 
        Dictionary<string, int> averageTemperaturesByMonth = new Dictionary<string, int> 
        { 
            { "Январь", averageTemperatures[0] }, 
            { "Февраль", averageTemperatures[1] }, 
            { "Март", averageTemperatures[2] }, 
            { "Апрель", averageTemperatures[3] }, 
            { "Май", averageTemperatures[4] }, 
            { "Июнь", averageTemperatures[5] }, 
            { "Июль", averageTemperatures[6] }, 
            { "Август", averageTemperatures[7] }, 
            { "Сентябрь", averageTemperatures[8] }, 
            { "Октябрь", averageTemperatures[9] }, 
            { "Ноябрь", averageTemperatures[10] }, 
            { "Декабрь", averageTemperatures[11] } 
        }; 
 
        var sortedTemperatures = averageTemperaturesByMonth.OrderBy(pair => pair.Value); 
 
        foreach (var kvp in sortedTemperatures) 
        { 
            Console.WriteLine($"{kvp.Key}: {kvp.Value} градусов Цельсия"); 
        } 
    } 
 
    static int[] CalculateAverageTemperatures(int[,] temperature) 
    { 
        int months = temperature.GetLength(0);  
        int days = temperature.GetLength(1);  
 
        int[] averageTemperatures = new int[months]; 
 
        for (int month = 0; month < months; month++) 
        { 
            int sum = 0; 
 
            for (int day = 0; day < days; day++) 
            { 
                sum += temperature[month, day]; 
            } 
 
            averageTemperatures[month] = sum / days; 
        } 
 
        return averageTemperatures; 
    } 
}

//1.2/5

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] temperatures = new int[12, 30];

        Random random = new Random();
        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                if (month == 0  month == 10  month == 11) 
                {
                    temperatures[month, day] = random.Next(-20, 0); 
                }
                else
                {
                    temperatures[month, day] = random.Next(0, 40); 
                }
            }
        }

        Dictionary<string, List<int>> monthlyAverages = CalculateMonthlyAverages(temperatures);

        List<KeyValuePair<string, List<int>>> sortedAverages = new List<KeyValuePair<string, List<int>>>(monthlyAverages);
        sortedAverages.Sort((x, y) => GetAverageTemperature(x.Value).CompareTo(GetAverageTemperature(y.Value)));

        foreach (var kvp in sortedAverages)
        {
            Console.WriteLine($"Месяц: {kvp.Key}");
            Console.WriteLine($"Средняя температура: {GetAverageTemperature(kvp.Value)}");
            Console.WriteLine();
        }
    }

    static Dictionary<string, List<int>> CalculateMonthlyAverages(int[,] temperatures)
    {
        Dictionary<string, List<int>> monthlyAverages = new Dictionary<string, List<int>>();

        for (int month = 0; month < 12; month++)
        {
            string monthName = GetMonthName(month);
            List<int> monthlyTemperatures = new List<int>();

            for (int day = 0; day < 30; day++)
            {
                monthlyTemperatures.Add(temperatures[month, day]);
            }

            monthlyAverages.Add(monthName, monthlyTemperatures);
        }

        return monthlyAverages;
    }

    static string GetMonthName(int month)
    {
        string[] monthNames = {
            "Январь", "Февраль", "Март",
            "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь",
            "Октябрь", "Ноябрь", "Декабрь"
        };

        return monthNames[month];
    }

    static int GetAverageTemperature(List<int> temperatures)
    {
        int sum = 0;
        foreach (int temperature in temperatures)
        {
            sum += temperature;
        }

        int average = sum / temperatures.Count;
        return average;
    }
}