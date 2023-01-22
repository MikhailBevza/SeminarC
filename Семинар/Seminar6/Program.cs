/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

// Написать программу на разворот массива

void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

// Задача 1. Даны три числа, может ли существовать треугольник. 

bool Triangle(int firstSide, int secondSide, int thirdSide)
{
    return (firstSide + secondSide > thirdSide) && (secondSide + thirdSide > firstSide) && (firstSide + thirdSide > secondSide);
}
*/

// Задача 2. Не использую рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a, b.


/*
Console.Write("input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
*/

/*
ReverseArray(newArray);
ShowArray(newArray);
*/
/*
Console.Write("Введите первое число: ");
int firstSide = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondSide = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

if(Triangle(firstSide, secondSide, thirdSide))
    Console.WriteLine("Треугольник может существовать.");
else 
    Console.WriteLine("Треугольник не может существовать.");
*/


// Задача 2. Не использую рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a, b.
/*
void Fibonachi(int firstNum, int secondNum, double[] array)
{
    array[0] = firstNum;
    array[1] = secondNum;

    for(int i = 2; i < array.Length; i++)
        array[i] = array[i-1] + array[i-2];

}

void ShowArrayDouble(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

Console.Write("Введите количестов элементов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[n];

Fibonachi(firstNum, secondNum, arr);
ShowArrayDouble(arr);
*/

// Напишите программу, которая будет создавать копию массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 101);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
        newArray[i] = array[i];
    
    return newArray;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size);
ShowArray(newArray);

int[] copyArray = CopyArray(newArray);

newArray[5] = 200;
ShowArray(newArray);
ShowArray(copyArray);