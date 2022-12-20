


/*
int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result; 
}

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of a number {randNumber} is {newNumber}");
*/
/*
bool IsEven(int num)
{
    if(num % 2 == 0) 
        return true;
    else
        return false;
}
*/

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int MaxNumber(int number)
{
    if(number / 10 > number % 10 ) 
        return number / 10;
    else 
        return number % 10;
    
}

int randNumber = new Random().Next(10, 100);
Console.WriteLine($"Число: {randNumber}");
Console.WriteLine($"Наибольшее цифра из числа: {MaxNumber(randNumber)}");
*/


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.

/*
bool MultipleOfFirst(int number1, int number2)
{
    if(number2 % number1 == 0)
        return true;
    else
        return false;
}

Console.Write("input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(MultipleOfFirst(num1, num2))
{
    Console.WriteLine("Второе число является кратное первому");
}
else
{
    Console.WriteLine("Второе число не является кратное первому");
}
*/


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*
bool SquareNumbers(int number1, int number2)
{
    int squarenum1 = number1 * number1;
    int squarenum2 = number2 * number2;

    if(squarenum1 == number2 || squarenum2 == number1)
        return true;
    else
        return false;
}

Console.Write("input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(SquareNumbers(num1, num2))
    Console.WriteLine("Одно число является квадратом другого");
else
    Console.WriteLine("ни одно число не является квадратом другого");
*/


