// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Введите m:");
int n = Prompt("Введите n:");
Console.WriteLine(PrintNumbers(m,n));  

// функция вызывает сама себя... до получения n
string PrintNumbers(int start, int finish) //отличие от for- у for знаем длину. в рекурсии мы ее не знаем
{
    if (start == finish)
    {
      return start.ToString();
    }
    return start + " " + PrintNumbers(start + 1, finish); //Напр. 1 и 5. 1==5? нет. start+1 это 1+1=2. Далее 2==5? Нет. далее... 
}
//  Условие внутри if выполняется в самом конце! После всей матрешки функции.