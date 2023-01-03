// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите положительное число:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = 1;
// if (n < 1)
// {
//     Console.WriteLine("Ввели не положительное число");
// }
// Console.WriteLine(NumbersRec(n, m));

// string NumbersRec (int a, int b)
// {
//     if (a <= b) return NumbersRec (a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersRec(1, n));


// ________________________________________________________________________________________

// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите положительное число:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// int SumRec (int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumRec(n));

// _________________________________________________________________________________________________

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите положительное число M:  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите положительное число N:  ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine("A(m, n) = " +Akkerman(m, n));