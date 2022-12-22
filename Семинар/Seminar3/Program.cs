// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void GetDiapazone(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");
}

Console.Write("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int Quadrant(double x, double y)
{
    if(x > 0) return (y > 0) ? 1 : 4;
    else return (y > 0) ? 2: 3;    
}

Console.Write("Input x: ");
double x1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Input y: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Quadrant(x1, y1));
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void Nums(int number)
{
    int count = 1;
    while(count <= number)
    {
        Console.Write(Math.Pow(count, 2) + " ");
        count++;
    }
}

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

Nums(n);
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Length(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    
}

Console.Write("Input x: ");
double x1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Input y: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input x: ");
double x2 = Convert.ToDouble(Console.ReadLine());


Console.Write("Input y: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write(Length(x1, y1, x2, y2));
*/

