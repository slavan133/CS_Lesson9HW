// Задача 69. Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// А=3 B=5 => 243 (3^5)

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = Prompt("Введите число A:");
int b = Prompt("Введите число B:");
Console.WriteLine(ReturnStepen(a,b));

int ReturnStepen(int a, int b)
{
    if(b == 1 ) // Последнее число, которое будет делиться с остатком (между 1 и 9)
    {
        return a;
    }
    return a*ReturnStepen(a, b-1);
}
