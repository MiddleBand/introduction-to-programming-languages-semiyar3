// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int value = 2;
for (int power = 0; power <= 4; power++)
Console.WriteLine($"{value} в степени {power} = {(long)Math.Pow(value, power)} ");
_____________________________________________________________________________________________________________________________________________________________________

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
_____________________________________________________________________________________________________________________________________________________________________

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(" | ", array)} ] ");


int[] GetBinaryArray(int size)
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
result[i] = new Random().Next(16);
}

return result;
}

или так

int[] array = {11,27,38,4,45,611,76,8,};

Console.WriteLine($" {array[0]} {array[1]} {array[2]} {array[3]} {array[4]} {array[5]} {array[6]} {array[7]}");
// Console.WriteLine($" {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]} -> [{array[0]} {array[1]} {array[2]} {array[3]} {array[4]} {array[5]} {array[6]} {array[7]}]");
