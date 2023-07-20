// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Input(string abc) // Записываем массив из строки, преобразуем строковой массив в числовой//На вход принимаем сообщение для пользователя
{
    Console.Write($"{abc} ");
    string[] input = Console.ReadLine()!.Split(',');
    int[] numbers = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
        numbers[i] = Convert.ToInt32(input[i]);

    return numbers;
}

int[] EvenOrOdd(int[] array) //Функция нахождения количества четных и нечетных элементов массива, на выходе выдает массив где элемент [0] - количество четных, элемент [1] - количество нечетных;
{
    int[] count = new int[2];

    foreach (int i in array)
    {
        if (i % 2 == 0)
            count[0] += 1;
        else
            count[1] += 1;
    }
    return count;
}

int[] array = Input("Введите трехзначные числа через запятую (без пробела)");
Console.WriteLine($"Количество четных элементов = {EvenOrOdd(array)[0]} \nКоличество нечетных элементов = {EvenOrOdd(array)[1]}");