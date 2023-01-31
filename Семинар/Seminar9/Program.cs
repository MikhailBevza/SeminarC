// Написать програму, 
/*
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write($"{num} ");
}

ShowNums(5);
*/

// 
/*
int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(1234));

// f(1234) -> 4 + f(123)
// f(123) -> 3 + f(12)
// f(12) -> 2 + f(1)
// f(1) -> 1 + f(0)
// f(0) -> 0
// f(1) -> 1 + 0 = 1
// f(12) -> 2 + 1 = 3
// f(123) -> 3 + 3 = 6
// f(1234) -> 4 + 6 = 10
*/

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа от M до N

void ShowNums(int m, int n)
{
    Console.Write($"{m} ");
    if(m > n) ShowNums(m - 1, n);
    if(m < n) ShowNums(m + 1, n);
    
}

Console.Write("Введите первое значение: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе значение: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(m, n);


// Напишите программу, которая на вход принимает два числа A и B и возводит число A в целую степень B
/*
double NumsDegree(double a, int b)
{
    if(b > 0) return NumsDegree(a, b-1) * a;
    else if(b < 0) return NumsDegree(a, b + 1) * 1 / a;
    else return 1;
}

Console.Write("Введите первое число: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

double num = NumsDegree(a, b);
Console.WriteLine(num);
*/
