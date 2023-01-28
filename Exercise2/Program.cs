/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

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

int PosIndex(int[] array)
{   int sum = 0;
    for (int i = 1; i < array.Length; i++) // сразу пропускаем 0, так как он не относится ни к четным, ни к нечетным (Чтобы цикл делал на один оборот меньше)
    {
        if ( i % 2 != 0) // проверяем на четность
        {   
            sum = sum + array[i]; // прибавляем значение на нечетной позиции
        }
    }
    return sum;
}
int[] array = GetArray(10, 0, 100); // определяем массив в 10 элементов от 0 до 9 для лучшего отображения в консоли
Console.WriteLine(String.Join(", ", array));
int sum = PosIndex(array);
Console.WriteLine($"{sum} - Сумма элементов, стоящих на нечетных позициях");






