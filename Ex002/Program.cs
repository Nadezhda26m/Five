
//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//===
//
//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве
//

//Создать массив
//
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

void Umn(int[] array, int [] arrayTwo)
{
    int size = arrayTwo.Length;
    int i = 0;
    while (i < size)
    {
        arrayTwo[i] = array[i] * (- 1);
        i++;
    }
}


int[] array = CreateArray(12);
Fill(array, -9, 10);
Print(array);
int[] arrayTwo = CreateArray(12);
Umn(array, arrayTwo);
Print(arrayTwo);