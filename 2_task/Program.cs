// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9
int m = InputInt("введите число строк ");
int n = InputInt("введите число столбцов ");
int[,] array = new int[m, n];
Console.WriteLine("Введите числа через запятую первое - номер строки, вторая - столбца: ");
string numbersString = Console.ReadLine() ?? "";
int[] numbers = ParseArray(numbersString, ',');
int i = numbers[0];
int j = numbers[1];
if (i >= array.GetLength(0) || j >= array.GetLength(1))
{
   Console.WriteLine("такого числа в массиве нет");
}
else
{   
    FillandPrintArray(array);
    int result = array[numbers[0] - 1, numbers[1] - 1];
    Console.WriteLine(result);
}


int[] ParseArray(string input, char separator)
{
    int[] numbers = new int[GetCountNumbersInString(input)];
    string subString = String.Empty;
    int numbersIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == separator)
        {
            numbers[numbersIndex++] = Convert.ToInt32(subString);
            subString = String.Empty;
        }
        else
        {
            subString += input[i];
        }
    }
    numbers[numbersIndex] = Convert.ToInt32(subString);
    return numbers;
}
int GetCountNumbersInString(string numbers)
{
    int countNumbers = 1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == ',')
            countNumbers++;
    }
    return countNumbers;
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillandPrintArray(int[,] array)
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
