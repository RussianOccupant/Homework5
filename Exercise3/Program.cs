// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double MaxElement(double[] array) // ищем максимальный элемент
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double MinElement(double[] array)
{

    double min = MaxElement(array); // обращаемся к функции с поиском максимального элемента, присваиваем мин максимальное значение
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) // проверяем что меньше
        {
            min = array[i];
        }
    }
    return min;
}
void Main()
{
    Console.Write("Введите желаемое количество элементов массива: ");
    int k = int.Parse(Console.ReadLine()!);
    Console.Write("Введите начальное значение интевала элементов массива: ");          // здесь пользователь сам вводит желаемое
    int start = int.Parse(Console.ReadLine()!);                                        // количество, минимальное и максимальное значение 
    Console.Write("Введите конечное значение интевала элементов массива: ");
    int end = int.Parse(Console.ReadLine()!);
    double[] array = GetArray(k, start, end);
    Console.WriteLine(String.Join(", ", array));
    double min = MinElement(array);
    double max = MaxElement(array);
    Console.WriteLine($"Разница между максимальным и минимальным значением равна {max - min}"); // выводим разницу между макс и мин эл массива 

}
Main(); // образаемся к функции для пользоваеля














