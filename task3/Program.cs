// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
System.Console.WriteLine("Задайте значение неотрицательнoe числo m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте значение неотрицательнoe числo n");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(AkkermanFunctoin(m, n));

double AkkermanFunctoin(double num1, double num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    if (num1 > 0 && num2 == 0)
    {
        return AkkermanFunctoin(num1 - 1, 1);
    }
    return AkkermanFunctoin(num1 - 1,
    AkkermanFunctoin(num1, num2 - 1));
}