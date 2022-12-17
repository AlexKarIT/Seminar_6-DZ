/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

//Метод принуждения к вводу числа >0:
static double NumberPlus()
{
    double number = 0;
    while (!double.TryParse(Console.ReadLine(), out number) || number <= 0)
    {
        Console.WriteLine($"Вы ввели не число или не положительное число! Введите число");
    }
    return number;
}


//Ввод количества чисел М
Console.WriteLine("Введите количество чисел для ввода (М):");
int M = (int)NumberPlus();
int[] array1 = new int[M];

//Метод принуждения к вводу числа:
static double Number()
{
    Console.WriteLine("Введите очередное число: ");
    double number = 0;
    while (!double.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine($"Вы ввели не число! Введите число");
    }
    return number;
}

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = (int)Number();
}


//Вывод массива
Console.WriteLine($"Вы ввели: {string.Join(", ", array1)}");


//Подсчёт чисел больше нуля
int count = 0;
foreach (int item in array1)
{
    if (item > 0) count++;
}


Console.WriteLine($"Количество чисел больше нуля: {count}");