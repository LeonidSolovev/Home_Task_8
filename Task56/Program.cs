// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = NewArray(GetUserInput("Укажите размер массива по горизонтали: ", "Ошибка ввода!"), GetUserInput("Укажите размер массива по вертикали: ", "Ошибка ввода!"), GetUserInput("Укажите минимальное значение: ",
 "Ошибка ввода!"), GetUserInput("Укажите максимальное значение: ", "Ошибка ввода!"));

PrintArray(array);

Console.WriteLine("------");

int minString = FindMinString(array);

Console.WriteLine($"{minString+1} строка");

int FindMinString(int [,] arr)
{
    int minStringNumber =0;
    int min = arr[0,0];
    for (int i = 0; i<arr.GetLength(0);i++)
    {
        for (int j = 0; j <arr.GetLength(1); j++)
        {
            if (min>arr[i,j])
            {
                min = arr[i,j];
                minStringNumber = i;
            }
        }
    }
    return minStringNumber;
}

static int[,] NewArray(int size1, int size2, int from, int to)
{
    int[,] arr = new int[size1, size2];
    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    }
    return arr;
}
static void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
static int GetUserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }

}

