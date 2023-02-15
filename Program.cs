// Показать натуральные числа от N до 1, N задано
/*
void PrintNumber(int n)
{
    if (n < 1) return;
    PrintNumber(n - 1);
    Console.Write(n + "\t");
}
PrintNumber(10);
*/





//Показать натуральные числа от M до N, N и M заданы
/*
void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    Console.Write(n + "\t");
}
PrintNumber(5, 10);
*/




//Найти сумму элементов от M до N, N и M заданы
/*
int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine(Sum(1, 10));
*/



// Написать программу вычисления функции Аккермана
/*
int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return A(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return A(m - 1, A(m, n - 1));
    }
    else
    {
        return n + 1;
    }
}
Console.WriteLine(A(0, 0));
*/


// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
/*
Console.Write("Сколько раз складывать числа? - ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число? - ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число? - ");
int b = int.Parse(Console.ReadLine()!);
int Fibonachi(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;
    return Fibonachi(x, y, num - 1) + Fibonachi(x, y, num - 2);
}
for (int i = 1; i < N; i++)
{
    Console.Write(Fibonachi(a, b, i) + " ");
}
*/