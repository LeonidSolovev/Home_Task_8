// // Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] array = NewArray(2, 2, 2, GetUserInput("Укажите минимальное значение: ", "Ошибка ввода!"), GetUserInput("Укажите максимальное значение: ", "Ошибка ввода!"));

PrintArray(array);

static void PrintArray(int[,,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j},{k}) ");
            }

            Console.WriteLine();
        }
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
static int[,,] NewArray(int size1, int size2, int size3, int from, int to)
{
    int[,,] arr = new int[size1, size2, size3];
    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        for (int k = 0; k < size2; k++)
        {
            for (int j = 0; j < size3; j++)
                arr[i, k, j] = new Random().Next(from, to + 1);
        }

    }
    return arr;
}