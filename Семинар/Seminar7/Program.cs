
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
    
        Console.WriteLine();
    } 
    Console.WriteLine();
}
/*
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/


// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле A[i,j] = i + j
/*
int[,] Create2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = i + j;
    
    return array;
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dArray(rows, columns);
Show2dArray(newArray);
*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные и замените эти элементы на их квадраты 
/*
int[,] SquareOfElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i,j] *= array[i,j];
        }
    }
    return array;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

SquareOfElements(newArray);
Show2dArray(newArray);
*/

// Задайте двумерный массив. находящихся на главной диагонали с индексами(0,0) (1,1) и т.д.

int SumOfElementsDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum += array[i,i];
    }

    return sum;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

int sumElements = SumOfElementsDiagonal(newArray);
Console.WriteLine("Сумма элементов по диагонали:" + sumElements);