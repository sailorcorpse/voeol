//1.1/1

using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 100);
        }

        int min = numbers[0];
        int minIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
                minIndex = i;
            }
        }

        Console.WriteLine("Случайные числа:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Номер минимального элемента: " + minIndex);
    }
}


//1.1/2

using System;
using System.Collections.Generic;
using System.Linq;

class Program 
{
    static void Main() 
    {
        List<int> numbers = new List<int>();
        while (true) 
        {
            Console.WriteLine("Введите число (введите 0 для остановки программы):");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 0) 
            {
                break;
            }
            numbers.Add(input);
        }
        
        if (numbers.Count > 0) 
        {
            int sum = numbers.Sum();
            int product = numbers.Aggregate((a,b) => a * b);
            double average = numbers.Average();
            
            Console.WriteLine($"Сумма всех элементов: {sum}");
            Console.WriteLine($"Произведение всех элементов: {product}");
            Console.WriteLine($"Среднее среди всех элементов: {average}");
        }
        else 
        {
            Console.WriteLine("Элементы не были введены");
        }
    }
}

//1.1/3

using System;
using System.Collections.Generic;
using System.Linq;
class Program 
{
    static void Main() 
    {
        List <string> elements = new List<string>(); //список, где хранится только строки
        while (true) 
        {
            Console.WriteLine("Введите элемент (нажмите Enter с пустым вводом для отстановки):");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) 
            {
                break;
            }
            elements.Add(input);
        }
        if (elements.Count > 0) 
        {
            string shortest = elements.OrderBy(s => s.Length).First(); //сортировка элементов в порядке возрастания
            string longest = elements.OrderByDescending(s => s.Length).First(); //сортировка элементов в порядке убывания
            
            Console.WriteLine($"Самый короткий элемент: {shortest}");
            Console.WriteLine($"Самый длинный элемент: {longest}");
            
        }
        else 
        {
            Console.WriteLine("Элементы не были введены.");
        }
    }
}

//1.1/4

using System;

class Program 
{
    static void Main() 
    {
        int startRange, endRange;
        //ToInt32(Single) Преобразует значение заданного числа с плавающей запятой одиночной точности в эквивалентное 32-битовое целое число со знаком.
        Console.WriteLine("Введите начало диапазона:");
        startRange = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите конец диапазона:");
        endRange = Convert.ToInt32(Console.ReadLine());
        //Range создаёт последовательность целых чисел
        int[] filledArray = FillArrayWithRandomNumbers(startRange, endRange);
        
        Console.WriteLine("Случайно сгенерированные числа:");
        for (int i = 0; i < filledArray.Length; i++) 
        {
            Console.WriteLine(filledArray[i] + " ");  
        }
    }
    
    static int[] FillArrayWithRandomNumbers(int start, int end) 
    {
        Random rnd = new Random();
        int[] array = new int[10];
        
        for (int i = 0; i < array.Length; i++) 
        {
            array[i] = rnd.Next(start, end  + 1);
        }
        return array;
    }
}

//1.1/5

using System;

class Program 
{
    static void Main() 
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();
        
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;
        //программа использует метод Split для разделения введенного предложения на слова, которые затем сохраняются в массиве строк words.
        input = "Start " + input + " End";
        
        Console.WriteLine("Модифицированное предложение: " + input);
        Console.WriteLine("Количество слов в предложении: " + wordCount);
      
    }
}



