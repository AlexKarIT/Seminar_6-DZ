/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
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

// Метод записи массива справо - налево (честно стырен с семинара!!!)
int[] CopyReverseArray(int[] array)
{
    int size = array.Length; 
    int[] result = new int[size]; // Копия - такой же размер
    int last = size - 1;
    for (int i = 0; i < size; i++) // i++ - слево - направо
    {
        result[i] = array[last - i]; // Последний элемент - текущий
    }
    return result;
}

//Ввод числа в десятичном формате
Console.WriteLine($"Введите число в десятичном формате : ");
int dec = Convert.ToInt32 (NumberPlus());


//Получение массива остатков деления на 2
int[] array1 = new int[1];
int i = 0;
while (dec>0)
{
    Array.Resize(ref array1, i+1);
    array1[i] = dec%2;
    dec /=2;
    i++;  
}


//Вывод массива
Console.WriteLine($"Ваше число в двоичном формате: {string.Join("", CopyReverseArray(array1))}");