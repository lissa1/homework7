// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
int m = InputInt("введите число строк ");
int n = InputInt("введите число столбцов ");
double[,] num = new double[m, n];

FillandPrintArray(num);

void FillandPrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


