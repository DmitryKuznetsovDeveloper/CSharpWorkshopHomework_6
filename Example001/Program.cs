// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Метод получения числа от пользователя
int InputUser(string str)
{
    Console.Write($"{str}  --> ");
    return Convert.ToInt32(Console.ReadLine());
}

//Метод создания массива с ручным заполнением от пользователя
int[] CreateArrayUser(int size)
{
    int[] array = new int[size];
    for (int i = 0, j = 1; i < array.Length; i++, j++)
    {
        array[i] = InputUser($"Введите цифру {j} элемента");
    }
    return array;
}

//Метод который выводит массив
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}  ");
    }
    Console.WriteLine();
}

//Метод который выводит сколько элементов массива больше 0
int NumbersGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int userInput = InputUser("Введите общее количество цифр которые будем сравнивать");
int[] myArray = CreateArrayUser(userInput);
PrintArray(myArray);
Console.WriteLine($"Количество чисел которые больше нуля = {NumbersGreaterZero(myArray)}");
