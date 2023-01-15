// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetMultiply(num)}");


int GetMultiply(int number)
{
int result = 0;
for (int i = 1; i <= number; i++)
{
result += i;
}
return result;
}