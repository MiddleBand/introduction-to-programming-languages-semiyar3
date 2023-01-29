// ﻿Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно ПАЛИНДРОМ.

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num/10000%10;
int b = num%10;
int c = num/1000%10;
int d = num/10%10;
int e = num/100%10;

while(num>100000); 
if(a==b && c==d) Console.WriteLine($"{a}{c}{e}{d}{b} - палиндромом ");  
else Console.WriteLine($"{a}{c}{e}{d}{b} - не палиндромом ");

// ﻿Задача 19 другое решение

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string FillingString = Console.ReadLine();
int length = FillingString.Length;
if (length == 5)
{
if (FillingString[0] == FillingString[4] && FillingString[1] == FillingString[3])
{
 Console.WriteLine($"{FillingString} - Палиндром");
 }
 else
 {
 Console.WriteLine($"{FillingString} - Не палиндром");
 }
}
else
{
Console.WriteLine($"Ошибка: {FillingString} - Не является пятизначным");
}

    

// ﻿Задача 21 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Введите значение X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double z = Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2));  

Console.WriteLine($"d={z:f3}");

// ﻿Задача 21 другое решение

int x1 = ReadInt("Введите х для точки 1: ");
int y1 = ReadInt("Введите y для точки 1: ");
int z1 = ReadInt("Введите z для точки 1: ");
int x2 = ReadInt("Введите х для точки 2: ");
int y2 = ReadInt("Введите y для точки 2: ");
int z2 = ReadInt("Введите z для точки 2: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;
double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}


    
// ﻿Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.    

Console.Clear();
Console.Write("Введите значение X: ");
int X = int.Parse(Console.ReadLine());

for(int i=1; i<=X; i++)
{
//   Console.WriteLine($" {i*i*i}");
    //  Console.WriteLine();
Console.WriteLine("{0}\t{1}\t{2}\t{3}",i, "куб числа " + (i), "=", i*i*i);
}

// ﻿Задача 23 другое решение

Console.Clear();
Console.Write("Введите число ");
int SpecifiedNumber = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count < SpecifiedNumber)
{
int num = Convert.ToInt32(Math.Pow(count, 3));
Console.Write($"{num}, ");
count++;
}
Console.Write($"{Math.Pow(SpecifiedNumber, 3)}");
Console.WriteLine();  
    




// ﻿Задача 
// Найти сумму числе от одного до заданного
    
Console.Clear();   
int SumFrom_1_ToAGivenSpecifiedNumber(int SpecifiedNumber)
{
 int sum = 0;
 for (int i = 1; i <= SpecifiedNumber; i++)
 {
 sum += i;
 }

return sum;
}

Console.Write("Введите число: ");

int SpecifiedNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumFrom_1_ToAGivenSpecifiedNumber(SpecifiedNumber));

// ﻿Задача другое решение

void GetSumNums(int number)
{
int sum = 0;
for (int i = 1; i <= Math.Abs(number); i++)
{
sum += i;
}
Console.WriteLine($"Cумма цифр от 1 до {Math.Abs(number)}: {sum}");
}

Console.WriteLine("Введите число A");
GetSumNums(Convert.ToInt32(Console.ReadLine()));




// ﻿Задача 
// Найти сумму цифр из которых состоит число

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int NumbersQuantity = GetCountNums(num);
Console.WriteLine($"Количество цифр = {NumbersQuantity}");

// Console.WriteLine($"Количество цифр = {GetCountNums(168)}");

int GetCountNums(int number)
{
int count = 0;
while(number>0)
{
count++;
number/=10;
}
return count;
}




//Напишите программу, которая принимает
//на вход число N и выдаёт произведение чисел от 1 до N.

Console.Clear();   
int GetMultiply(int SpecifiedNumber)
{
 int multiply = 1;
 for (int i = 1; i <= SpecifiedNumber; i++)
 {
 multiply *= i;
 }

return multiply;
}

Console.Write("Введите число: ");

int SpecifiedNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetMultiply(SpecifiedNumber));




// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(" , ", array)} ] ");


int[] GetBinaryArray(int size)
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
result[i] = new Random().Next(2);
}
return result;
}




// Создание и вывод массива 
// БОЛЬШОЙ ОБСОЛЮТНО ЛОГИЧЕСКИ МНЕ НЕПОНЯТНЫЙ КОД ИЗ МАССИВОВ С СЫЛКАМИ И ЦИКЛАМИ

int[] CreateRandomArray(int N, int start, int end)
{
int[] RandomArray = new int[N];
for (int i = 0; i < N; i++)
{
RandomArray[i] = new Random().Next(start, end + 1);
}
return RandomArray;
}

int[] CreateArray()
{
Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива");
array[i] = Convert.ToInt32(Console.ReadLine());
}
return array;
}

void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

Console.Clear();

Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);
ShowArray(myRandomArray);
Console.WriteLine("-------");
int[] myArray = CreateArray();
ShowArray(myArray);

int [] Array = CreateRandomArray(12, -9, 9);
ShowArray(Array);

int negative = 0;
int positive = 0;

for (int i=0; i < Array.Length; i++){
if (Array[i] > 0) positive += Array[i];
if (Array[i] < 0) negative += Array[i];
}

Console.WriteLine($"Сумма отрицательных {negative}");
Console.WriteLine($"Сумма положительных {positive}");


int[] InversArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] *= -1;
}
return array;
}







///////////////////////
//Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

00000000







int[] CreateRandomArray(int N, int start, int end){
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int[] CreateArray(){
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] Arra = CreateRandomArray(4, -10, 10);

ShowArray(Arra);

for (int i=0; i < Arra.Length; i++){
    Arra[i] = Arra[i] * -1;
}

ShowArray(Arra);





int[] CreateRandomArray(int N, int start, int end){
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int[] CreateArray(){
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

bool checkNum (int [] array, int num) {
    bool finded = false;

    for (int i=0; i < array.Length; i++)
        if (array[i] == num)
            finded = true;

    return finded;
}

int [] Array = CreateArray();
ShowArray(Array);

Console.Write("Введите искомое число: ");
string stringNum = Console.ReadLine();
int intNum = Convert.ToInt32(stringNum);

bool finded = checkNum(Array, intNum);

if (finded == true) 
    Console.Write("Искомое число существует");
else
    Console.Write("Искомое число не существует");
                  
                  
     
                  
 // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int value = 2;
for (int power = 0; power <= 4; power++)
   Console.WriteLine($"{value} в степени {power} = {(long)Math.Pow(value, power)} ");
                  
                  
                  
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
                  
                  
                  
                  
                  
/ Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
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


                  
                  
                  
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
                  
                  
                  
                  
 // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

                  
                  
                  
                  
 // Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

                  
                  
Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}




// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] > 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них больше 0");

void FillArrayNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");




Console.Clear();

string [,] table = new string [2,5];
table [1,2] = "слово";
for(int rows = 0; rows < 2; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine ($"-{table [rows, columns]}-");
    }
}



Console.Clear();

void PrintArray(int[,] matr)
{
// for(int i = 0; i < 3; i++)
 for(int i = 0; i < matr.GetLength(0); i++)
 {
    // for(int j = 0; j < 4; j++)
    for(int j = 0; j < matr.GetLength(1); j++)
    {
    Console.Write($"{matr [i,j]} ");
    }
    Console.WriteLine();
 }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
 {
    // for(int j = 0; j < 4; j++)
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10);
    }
 }  
}

int[,] matrix = new int[3,4];

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);



Console.Clear();

int[,] pic = new int[,] {
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, 
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, 
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, 
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, 
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, 
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, 
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, 
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 }, 
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 }, 
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 }, 
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 }, 
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
};

void PrintImage(int[,] image) 
{ for (int i = 0; i < image.GetLength(0); i++) 
  { 
    for (int j = 0; j < image.GetLength(1); j++) 
    { 
        if(image[i,j] == 0) Console.Write($" "); 
        else Console.Write($"+"); 
    } 
    Console.WriteLine(); 
  } 
} 
void FillImage(int row, int col) 
{ 
    if (pic[row, col] == 0) 
    { 
        pic[row, col] = 1; 
        FillImage(row - 1, col); 
        FillImage(row, col - 1); 
        FillImage(row + 1, col); 
        FillImage(row, col + 1); 
    } 
} 
PrintImage(pic); 
FillImage(13, 13); 
PrintImage(pic);




Console.Clear();

int Factorial(int n) 
{ 
    // 1! = 1 
    // 0! = 1 
    if(n == 1) return 1; 
    else return n * Factorial(n-1); 
} 
Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6




Console.Clear();

double Factorial(int n) 
{ 
    // 1! = 1 
    // 0! = 1 
    if(n == 1) return 1; 
    else return n * Factorial(n-1); 
} 
for (int i = 1; i < 40; i++) 
{ 
    Console.WriteLine($"{i}! = {Factorial(i)}");
}




Console.Clear();

int Fibonacci(int n) 
{ 
    if(n == 1 || n == 2) return 1; 
    else return Fibonacci(n-1) + Fibonacci(n-2); 
} 
for (int i = 1; i < 10; i++)
{ 
    Console.WriteLine(Fibonacci(i)); 
}



Console.Clear();

double Fibonacci(int n) 
{ 
    if(n == 1 || n == 2) return 1; 
    else return Fibonacci(n-1) + Fibonacci(n-2); 
}  

for (int i = 1; i < 50; i++) 
{ 
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}



// /Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
int[,] result = new int[m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
result[i, j] = new Random().Next(minValue, maxValue + 1);
}
}
return result;
}

void PrintArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Console.Write($"{inArray[i,j]} ");
}
Console.WriteLine();
}
}




// Матрица случайных чисел
Console.Clear();

int [,] matrix = new int[4,4];
FillArray(matrix);
Console.WriteLine("Задача 48.");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Задача 49.");
FillArraySqr(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Задача 51.");
FillArrayDiag(matrix);

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($"{matr[i,j]} ");
}
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i,j] = i + j;
}
}
}

void FillArraySqr(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
if (i % 2 == 0 && j % 2 == 0) matr[i,j] = matr[i,j] * matr[i,j];
}
}
}

void FillArrayDiag(int




// 0/ Матрица случайных чисел
Console.Clear();

int [,] matrix = new int[4,4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FillArrayMidl(matrix);


void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($"{matr[i,j]} ");
}
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i,j] = i + j;
}
}
}

void FillArrayMidl(int[,] matr)
{
Console.Write("Среднее: ");
for (int i = 0; i < matr.GetLength(1); i++)
{
double sum = 0;
for (int j = 0; j < matr.GetLength(0); j++)
{
sum += matr[i,j];
}
Console.Write($"{sum/matr.GetLength(0)}, ");
}
}
                   
                   
                   
 
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.Write("Введите значение элемента: ");
int element=int.Parse(Console.ReadLine());

if(FindeElemrnt(array, element))
{
    Console.WriteLine("Найден");
}
else
{
    Console.WriteLine("Не найден");
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
 int[,] result = new int[m, n];
 for (int i = 0; i < m; i++)
 {
  for (int j = 0; j < n; j++)
   {
   result[i, j] = new Random().Next(minValue, maxValue + 1);
   }
 }
 return result;
}

void PrintArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Console.Write($"{inArray[i,j]} ");
}
Console.WriteLine();
}
}

bool FindeElemrnt(int[,] array, int el)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == el) return true;
        }
    }
    return false;
}
                   
                   
                
 
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
                   
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
 int[,] result = new int[m, n];
 for (int i = 0; i < m; i++)
 {
  for (int j = 0; j < n; j++)
   {
   result[i, j] = new Random().Next(minValue, maxValue + 1);
   }
 }
 return result;
}

void PrintArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Console.Write($"{inArray[i,j]} ");
}
Console.WriteLine();
}
}                   

                   
                   
                   
//                   
void PrintArray(int[,] matr) // Создание матрицы
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int [,] matr) // Заполнение массива рандомными данными
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,100);
        }
    }
}

void ChangeRow(int [,] array){

  int temp = 0;

  for(int i=0; i < array.GetLength(0); i++){
    temp = array[0, i];
    array[0, i] = array[array.GetLength(0)-1, i];
    array[array.GetLength(0)-1, i] = temp;
  }

}


int [, ] array = new int [5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

ChangeRow(array);
PrintArray(array);
                   
                   
                   
//                   
void PrintArray(int[,] matr) // Создание матрицы
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int [,] matr) // Заполнение массива рандомными данными
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,100);
        }
    }
}

void ChangeRow(int [,] array){

  int temp = 0;

  for(int i=0; i < array.GetLength(0); i++){
    temp = array[0, i];
    array[0, i] = array[array.GetLength(0)-1, i];
    array[array.GetLength(0)-1, i] = temp;
  }

}

int [,] Transposition (int [,] array){

  int [,] newArray = new int [array.GetLength(1), array.GetLength(0)];

  // Производим транспонирование
  for(int i=0; i<newArray.GetLength(0); i++)
    for(int j=0; j<newArray.GetLength(1); j++)
      newArray[i,j] = array[j,i];

  return newArray;
}

int [,] array = new int [7, 5];
FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

int [, ] newArray = Transposition(array);
PrintArray(newArray);
