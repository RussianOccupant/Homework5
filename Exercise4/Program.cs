// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. 
// Реализовать невозрастающую сортировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]
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

double[] SortArray(double[] array)
{
    double temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}
double[] arr = GetArray(10, 0, 10);
Console.WriteLine($"Исходный массив: ");
Console.WriteLine(String.Join(", ", arr));
double[] array = SortArray(arr);
Console.WriteLine($"Отсортированный массив: ");
Console.WriteLine(String.Join(", ", array));
