// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Введите M:");
int n = Prompt("Введите N:");
Console.WriteLine("Сумма в промежутке M N:");
Console.WriteLine(SummNumbers(m,n));  

int SummNumbers(int start, int finish)
{
    if (start == finish)
    {
      return start;
    }
    return start + SummNumbers(start+1, finish);
}
