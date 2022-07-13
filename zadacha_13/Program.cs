// Задача 13:
// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет

// Математический вариант решения
Console.Write("Введите число :  ");
int num = int.Parse(Console.ReadLine());
for (int i = 1; (num > 1000); i *= 10)
{
    num = num / i;
}
if (num > 99) Console.WriteLine($"Третья цифра  :  {num % 10}");
else Console.WriteLine("Нет третьей цифры");