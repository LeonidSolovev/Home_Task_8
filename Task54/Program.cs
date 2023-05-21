// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = NewArray(GetUserInput("Укажите размер массива по горизонтали: ", "Ошибка ввода!"), GetUserInput("Укажите размер массива по вертикали: ", "Ошибка ввода!"), GetUserInput("Укажите минимальное значение: ",
 "Ошибка ввода!"), GetUserInput("Укажите максимальное значение: ", "Ошибка ввода!"));

PrintArray(array);

Console.WriteLine("------");

int[,] bubbledArray = BubbleSort(array);

PrintArray(bubbledArray);

int[,] BubbleSort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            for (int q = 0; q < arr.GetLength(1) - j; q++)
            {
                if (arr[i, q] > arr[i, q + 1])
                {
                    Swap(ref arr[i, q], ref arr[i, q + 1]);
                }
            }
        }
    }
    return arr;
}
static void Swap(ref int e1, ref int e2)
{
    var temp = e1;
    e1 = e2;
    e2 = temp;
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
