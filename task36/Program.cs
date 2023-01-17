// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] numbers = {-4, -6, 89, 6};
int lengthOfNumbers = numbers.Length;
int i = 0;
int sum = 0;

for (i = 0; i < lengthOfNumbers; i++)
 if(i % 2 == 1) 
 sum = sum + numbers[i];

Console.WriteLine(sum);