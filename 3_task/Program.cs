// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
int m = InputInt("введите число строк ");
int n = InputInt("введите число столбцов ");
double[,] numbers = new double[m, n];
double[] result = new double[n];
FillandPrintArray(numbers);
FindSumInColumn(numbers, result);

void FillandPrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FindSumInColumn(double[,] array, double[] result)
{
    for (int i = 0, k = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[k] = sum / 5;
        Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно: {result[k]}");
        k++;
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
