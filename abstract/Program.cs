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





//////////////////////
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int c = GetCountNums(num);
Console.WriteLine($"Количество цифр = {c}");

Console.WriteLine($"Количество цифр = {GetCountNums(16)}");


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



Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


int GetMultiply(int number)
{
int result = 1;
for (int i = 2; i <= number; i++)
{
result *= i;
}
return result;
}



/ //Напишите программу, которая принимает
// //на вход число N и выдаёт произведение чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


int GetMultiply(int number)
{
int result = 1;
for (int i = 2; i <= number; i++)
{
result *= i;
}
return result;
}


// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(" // ", array)} ] ");


int[] GetBinaryArray(int size)
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
result[i] = new Random().Next(2);
}
return result;
}




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






// // Создание и вывод массива

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








//Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

Clear();
Write("Введите элементы массива через пробел: ");
string elements = ReadLine();
int[] baseArray = GetArrayFromString(elements);
Write("Введите число: ");
int n = int.Parse(ReadLine());
if (FindElement(baseArray, n))
{
WriteLine("Да");
}
else
{
WriteLine("Нет");
}


int[] GetArrayFromString(string stringArray)
{
string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] res = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
res[i] = int.Parse(nums[i]);
}
return res;
}

bool FindElement(int[] array, int el)
{
foreach (var item in array)
{
if (el == item) return true;
}
return false;
}







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
