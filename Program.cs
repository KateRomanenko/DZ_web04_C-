// Задача 1. Напишите цикл, который принимает на вход два числа (А и В) и возводит А в натуральную степень В

/*Console.WriteLine("введите число A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("введите число B");
int B = int.Parse(Console.ReadLine());

int res = 1;

for (int i = 1; i <= B; i++)
{
    res *= A;
}

Console.WriteLine(res);*/

// Задача 2. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
// 452 -> 11;
// 82 -> 10;
// 9012 -> 12;

/* Console.WriteLine("введите число ");
int num = int.Parse(Console.ReadLine());

int res = 0;

while (num > 0)
{
    res += num % 10;
    num /=10;
}

Console.WriteLine(+res); */

// Задача 3. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

   void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
   while (index < length)
    {
        collection [index] = new Random().Next(9);
        index++;
    }
}
int [] mass = new int [8];
FillArray(mass);
Console.WriteLine(mass);

for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
