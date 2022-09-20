using System;
    Console.WriteLine("Введите количество элементов");
    int n =int.Parse(Console.ReadLine());
    string[] ArrString;
    ArrString = new string[n];
    Console.WriteLine("Введите элементы");
    for (int i = 0; i < n; i++)
        {
        ArrString[i] = (Console.ReadLine());
        }
    Console.WriteLine("Массив имеет следующий вид:");
    for (int i = 0; i < n; i++)

    {
        Console.Write($"{ArrString[i]}\t");
    }
    Console.WriteLine("\nПреобразованный массив имеет следующий вид:");
    for (int i = 0; i < n; i++)
    {
        if (ArrString[i].Length <= 3)
        {
            Console.Write($"{ArrString[i]}\t");
        }
        else 
        {
            continue;
        } 
    }