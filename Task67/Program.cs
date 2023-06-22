// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453->12
// 45->9

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Введите число:");
int chislo = ReturnSumm(m);
Console.WriteLine(chislo);

int ReturnSumm(int chislo)
{
    if(chislo < 10 ) // Последнее число, которое будет делиться с остатком (между 1 и 9)
    {
        return chislo;
    }
    return chislo % 10 + ReturnSumm(chislo/10);
}
