//1.6/1
using System;
using System.IO;
using System.Linq;
using CLSCompliantAttribute = System.CLSCompliantAttribute;
using Console = System.Console;
using ConsoleKeyInfo = System.ConsoleKeyInfo;
using Convert = System.Convert;

class Program
{
    static void Main()
    {
        string path = @"C:\Users\TTIT\numsTask1.txt";
        string[] lines = File.ReadAllLines(path);
        
        string content = string.Join(" ", lines);
        string[] words = content.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Слова нечетной длины:");
        foreach (string word in words)
        {
            if (word.Length % 2 != 0)
            {
                Console.WriteLine(word);
            }
        }
        
        string outputPath = @"C:\Users\TTIT\numsTask1.txt";
        File.WriteAllLines(outputPath, words.Where(word => word.Length % 2 != 0));
    }
}


//1.6/2

using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string path = @"C:\Users\TTIT\numsTask2.txt";

        string[] lines = File.ReadAllLines(path);

        StringBuilder concatenatedWords = new StringBuilder();
        foreach (string line in lines)
        {
            string[] words = line.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            concatenatedWords.Append(string.Join(" ", words));
            concatenatedWords.Append(" "); 
        }

        concatenatedWords.Length--;

        Console.WriteLine("Результирующая строка:");
        Console.WriteLine(concatenatedWords);

        string outputPath = @"C:\Users\TTIT\numsTask2.txt";
        File.WriteAllText(outputPath, concatenatedWords.ToString());
    }
}

//1.6/3
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 && number % 10 == 0)
        {
            Console.WriteLine("Число не является четным и кратным 10.");
        }
        else
        {
            Console.WriteLine("Число не является четным и кратным 10.");
        }
    }
}

//1.6/4

using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        
        Console.WriteLine("Введите положительные числа (для завершения введите отрицательное число):");
        Console.Write ("Введите число а: ");
        int a = Convert. ToInt32(Console. ReadLine());

        if (a <= 0)
        {
            Console.WriteLine("Число а должно быть положительным.");
            return;
        }
        
        int number;
        do
        {
            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                break;
            }

            if (number % a == 0)
            {
                sum += number;
            }
        } while (true);
        Console.WriteLine("Сумма чисел, делящихся на " + а + "нацело: " + sum);
    }
}


//1.6/5

using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console. ReadLine());
        
        Console.Write ("Введите количество столбцов: ");
        int m = int.Parse (Console. ReadLine());
        
        int[,] a = new int [n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = rnd. Next(0, 2);
            }
        }
        int[,] newMatrix = new int[n, m + 1];
        
        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < m; j++)
            {
                rowSum += a[i, j];
            }

            newMatrix[i, m] = (rowSum % 2 == 0) ? 0 : 1;

            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = a[i, j];
            }
        }
        Console.WriteLine("Исходная матрица:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(a[i, j] + " ");
            }

            Console.WriteLine();

        }
        Console.WriteLine("Исходная матрица с новым столбцом:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(newMatrix[i, j] + " ");

            }
            Console.WriteLine();
        }
    }
}
//1.6/6

using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int m = int.Parse(Console.ReadLine());

        int[,] a = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = rnd.Next(0, 2); 
            }
        }

        int[,] newMatrix = new int[n, m + 1];

        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < m; j++)
            {
                rowSum += a[i, j];
            }

            newMatrix[i, m] = (rowSum % 2 == 0) ? 0 : 1;

            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = a[i, j];
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Исходная матрица с новым столбцом:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


        


    
        
    




        

