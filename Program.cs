/*
// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. 

Console.WriteLine("Введите  число:");
int number = Convert.ToInt32(Console.ReadLine());

// Метод вывода натуральных чисел 
void NumberCounter (int number)
    {
    if (number < 0) return;
    if (number == 0) return;
    Console.Write("{0,2},", number);
    NumberCounter (number - 1);
    }
if (number < 0) Console.Write($"ВЫ ввели отриательное число {number} ");
NumberCounter(number);

*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. 

/*

Console.WriteLine("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

// Метод нахождения суммы натуральных элементов
void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM == numberN)
        {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum+numberM}"); 
        return; 
        }
    if (numberM > numberN) sum = sum + (numberM--);
    if (numberM < numberN) sum = sum + (numberN--);
       NumberSum(numberM, numberN, sum);
}
NumberSum(numberM, numberN, 0);


*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


void AkkermanFunction(int m, int n)
{
    Console.Write($"A(m,n) = {Akkerman(m, n)}"); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0)  return Akkerman(m - 1, 1);
    else return (Akkerman(m - 1, Akkerman(m, n - 1)));
    
}

AkkermanFunction(m,n);
