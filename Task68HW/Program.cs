// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Введите M:");
int n = Prompt("Введите N:");
Console.WriteLine("Функция Аккермана для M и N:");
Console.WriteLine(Ackerman(m,n));

int Ackerman (int m, int n)
{
    if (m==0) return n+1;
    else if (m > 0 && n == 0) return Ackerman(m-1, 1);
    else if (m > 0 && n >0) return Ackerman(m-1, Ackerman(m,n-1));
    return Ackerman(m,n);
}