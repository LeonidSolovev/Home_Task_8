// Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] array = new int[4, 4];

PrintArray(FillSpiral(array));


int[,] FillSpiral(int[,] arr)
{
    int count = 1;

    for (int i = 0; i < 4; i++)
    {
        arr[0, i] = count;
        count++;
    }
    for (int j = 1; j < 4; j++)
    {
        arr[j, arr.GetLength(0) - 1] = count;
        count++;
    }
    for (int i = 2; i >= 0; i--)
    {
        arr[arr.GetLength(1) - 1, i] = count;
        count++;
    }
    for (int j = arr.GetLength(1) - 2; j > 0; j--)
    {
        arr[j, 0] = count;
        count++;
    }
    for (int i = 1; i < 3; i++)
    {
        arr[1, i] = count;
        count++;
    }
    for (int j = 1; j < 3; j++)
    {
        arr[j, arr.GetLength(0) - 2] = count;
        count++;
    }
    for (int i = 1; i >= 1; i--)
    {
        arr[arr.GetLength(1) - 2, i] = count;
        count++;
    }
    return arr;

}


void PrintArray(int[,] arr)
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