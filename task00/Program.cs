// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

int[] Input(string abc) // Записываем массив из строки, преобразуем строковой массив в числовой//На вход принимаем сообщение для пользователя
{
    Console.Write($"{abc} ");
    string[] input = Console.ReadLine()!.Split(',');
    int[] numbers = new int[input.Length];
    Console.WriteLine(input.Length);
    for (int i = 0; i < input.Length; i++)
        numbers[i] = Convert.ToInt32(input[i]);

    return numbers;
}

int[] array = Input("Введите трехзначные числа через запятую (без пробела)");

int countA = 0; //Счетчик для четных
int countB = 0; //Счетчик для нечетных

foreach (int i in array)
{
    if (i % 2 == 0)
        countA += 1;
    else
        countB += 1;
}
Console.WriteLine($"Количество четных элементов = {countA} \nКоличество нечетных элементов = {countB}");