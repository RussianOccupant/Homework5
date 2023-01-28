/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int Array21(int[] array)
{
    int count2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        {
            count2++;

        }
    }
    return count2;
}

int[] array = GetArray(10, 99, 999); // создаем массив из 10 элементов для лучшего отображения в консоли
Console.WriteLine(String.Join(", ", array));
int count = Array21(array);
Console.WriteLine($"{count} - количество четных элементов в массиве");
Console.WriteLine($"{array.Length - count} - количество нечетных элементов массива");


