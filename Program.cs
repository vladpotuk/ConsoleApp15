using System;

class Program
{
    static void Main()
    {
        
        int[] array = { 3, 8, 5, 2, 10, 6, 1, 9, 4, 7 };

        Console.WriteLine("Масив:");
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.Write("Введіть число для порівняння: ");
        if (int.TryParse(Console.ReadLine(), out int comparison))
        {
            int count = 0;
            foreach (var num in array)
            {
                if (num < comparison)
                {
                    count++;
                }
            }
            Console.WriteLine($"Кількість значень у масиві менших за {comparison}: {count}");
        }
        else
        {
            Console.WriteLine("Некоректне введення. Будь ласка, введіть ціле число.");
        }

        Console.ReadLine(); 
    }
}

