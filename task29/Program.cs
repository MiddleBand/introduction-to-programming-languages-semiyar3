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




int[] array = {11,27,38,4,45,611,76,8,};

Console.WriteLine($" {array[0]} {array[1]} {array[2]} {array[3]} {array[4]} {array[5]} {array[6]} {array[7]}");
// Console.WriteLine($" {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]} -> [{array[0]} {array[1]} {array[2]} {array[3]} {array[4]} {array[5]} {array[6]} {array[7]}]");


