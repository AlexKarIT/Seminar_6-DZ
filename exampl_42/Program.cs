/*
Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//Метод принуждения к вводу числа:
static double Number()
{
    Console.WriteLine($"Введите значение переменной: ");
    double number = 0;
    while (!double.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine($"Вы ввели не число! Введите число");
    }
    return number;
}

Console.Write("Вводим b1... ");
double b1 = Number();
Console.Write("Вводим k1... ");
double k1 = Number();
Console.Write("Вводим b2... ");
double b2 = Number();
Console.Write("Вводим k2... ");
double k2 = Number();
double x = Math.Round((b2 - b1) / (k1 - k2), 3);
double y = Math.Round(k2 * x + b2, 3);

Console.WriteLine($"Точка пересечения: {x}, {y}");
Console.WriteLine("Результат округлен до тысячных");
