//===
//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//

// Задать массив
// Заполнить массив случайными числами
// Распечатать массив
// Найти сумму

int[] CreateArray(int size)
{
    return new int[size];
}

int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    int i = 0;
    while (i < size)
    {
        array[i] = GetIntValue(min, max);
        i++;
    }
}

void Print(int[] array)
{
    int i = 0;
    int size = array.Length;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

int sumNegative(int[] array)
{
    int sum = 0;
    int length = array.Length;
    
    for ( int i = 0; i < length; i++)
    {
        if (array[i] < 0) 
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int sumPositive(int[] array)
{
    int sum = 0;
    int length = array.Length;
    
    for ( int i = 0; i < length; i++)
    {
        if (array[i] > 0) 
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] array = CreateArray(12);
Fill(array, -9, 10);
Print(array);
Console.WriteLine(sumPositive(array)); 
Console.WriteLine(sumNegative(array));
