//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
  
// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num/10000%10;
// int b = num%10;
// int c = num/1000%10;
// int d = num/10%10;
// int e = num/100%10;

// while((num>100000) && (num<100000)); 
// if(a==b && c==d) 
//   {
//   Console.WriteLine($"{a}{c}{e}{d}{b} - палиндромом ");
//   }  
// else 
//   {
//   Console.WriteLine($"{a}{c}{e}{d}{b} - не палиндромом ");
//   }

// КАК ТУТ ЗАЦИКЛИТЬ ЧТОБЫ В ТЕРМИНАЛЕ НЕ ПРИХОДИЛОСЬ ПОСТОЯННО ЗАПУСКААТЬ ПРОГРАММУ, А ПРОСТО ВВОДИТЬ ПЯТИЗНАЧНОЕ ОДИН ЗА ДРУГИМ?


// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;
// if (len == 5)
// {
// if (number[0] == number[4] && number[1] == number[3])
// {
// Console.WriteLine($"{number} - Палиндром");
// }
// else
// {
// Console.WriteLine($"{number} - Не палиндром");
// }
// }
// else
// {
// Console.WriteLine($"Ошибка: {number} - Не является пятизначным");
// }

    

//Задача 21 
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите значение X: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение Z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение X: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение Z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double z = Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2));  

// Console.WriteLine($"d={z:f3}");

//ГДЕ МОЖНО НАЙТИ ИНФ О ТОМ КАКИЕ ФУНКЦИИ БЫВАЮТ В C#?





// int x1 = ReadInt("Введите х для точки 1: ");
// int y1 = ReadInt("Введите y для точки 1: ");
// int z1 = ReadInt("Введите z для точки 1: ");
// int x2 = ReadInt("Введите х для точки 2: ");
// int y2 = ReadInt("Введите y для точки 2: ");
// int z2 = ReadInt("Введите z для точки 2: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z2 - z1;
// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine("Расстояние = " + length);

// int ReadInt(string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }



    
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.    

// Console.Write("Введите значение X: ");
// int X = int.Parse(Console.ReadLine());

// for(int i=1; i<=X; i++)
// {
// //   Console.WriteLine($" {i*i*i}");
//      Console.WriteLine();
//      Console.WriteLine("{0}\t{1}\t{2}\t{3}",i, "куб" + (i), "=", i*i*i);
// }



// Console.Write("Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Clear();

// int count = 1;

// while(count < N)
// {
// int num = Convert.ToInt32(Math.Pow(count, 3));
// Console.Write($"{num}, ");
// count++;
// }
// Console.Write($"{Math.Pow(N, 3)}");
    

// Найти сумму числе от одного до заданного
    
// int summa(int number)
// {
// int sum = 0;
// for (int i = 1; i <= number; i++)
// {
// sum += i;
// }

// return sum;
// }

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(summa(number));





// void GetSumNums(int number)
// {
// int sum = 0;
// for (int i = 1; i <= Math.Abs(number); i++)
// {
// sum += i;
// }
// Console.WriteLine($"Cумма цифр от 1 до {Math.Abs(number)}: {sum}");
// }

// Console.Clear();

// // GetSumNums(-5);
// // GetSumNums(58);
// // GetSumNums(25);
// // GetSumNums(16);

// Console.WriteLine("Введите число A");
// int n = Convert.ToInt32(Console.ReadLine());
// GetSumNums(n);

// Console.WriteLine("Введите число A");
// GetSumNums(Convert.ToInt32(Console.ReadLine()));






// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int c = GetCountNums(num);
// Console.WriteLine($"Количество цифр = {c}");

// Console.WriteLine($"Количество цифр = {GetCountNums(16)}");


// int GetCountNums(int number)
// {
// int count = 0;
// while(number>0)
// {
// count++;
// number/=10;
// }
// return count;
// }



// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


// int GetMultiply(int number)
// {
// int result = 1;
// for (int i = 2; i <= number; i++)
// {
// result *= i;
// }
// return result;
// }



// / //Напишите программу, которая принимает
// // //на вход число N и выдаёт произведение чисел от 1 до N.

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


// int GetMultiply(int number)
// {
// int result = 1;
// for (int i = 2; i <= number; i++)
// {
// result *= i;
// }
// return result;
// }


// // Напишите программу, которая выводит массив из 8 элементов,
// // заполненный нулями и единицами в случайном порядке.

// int[] array = GetBinaryArray(8);
// Console.WriteLine($" [ {String.Join(" // ", array)} ] ");


// int[] GetBinaryArray(int size)
// {
// int[] result = new int[size];
// for (int i = 0; i < size; i++)
// {
// result[i] = new Random().Next(2);
// }
// return result;
// }




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