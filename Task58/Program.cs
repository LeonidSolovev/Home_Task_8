// // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstArray = NewArray(2, 2, 1, 5);
int[,] secondArray = NewArray(2, 2, 1, 5);
PrintArray(firstArray);
Console.WriteLine("-----");
PrintArray(secondArray);
Console.WriteLine("-----");
int[,] resArray = ProdArray(firstArray, secondArray);
PrintArray(resArray);


int[,] ProdArray(int[,] arr1,int[,] arr2)
{
    // Не придумал, как сделать циклом((
    int[,] resArr = new int[arr1.GetLength(0),arr1.GetLength(1)];
    resArr[0,0] = arr1[0,0]*arr2[0,0] + arr1[0,1]*arr2[1,0];
    resArr[1,0] = arr1[1,0]*arr2[0,0] + arr1[1,1]*arr2[1,0];
    resArr[0,1] = arr1[0,0]*arr2[0,1] + arr1[0,1]*arr2[1,1];
    resArr[1,1] = arr1[1,0]*arr2[0,1] + arr1[1,1]*arr2[1,1];
    return resArr;
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