/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Неверный ввод");
    return;
}

int SummMN(int numM, int numN) 
{
   if (numM == numN) return numM;
  return numM + SummMN(numM + 1, numN);   
}

int result = SummMN(numberM, numberN);
Console.WriteLine(result);
